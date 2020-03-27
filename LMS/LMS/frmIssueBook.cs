﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Tulpep.NotificationWindow;

namespace LMS
{
    public partial class frmIssueBook : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmIssueBook()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      // WS_EX_COMPOSITED
                return handleParam;
            }
        }

        private void FrmIssueBook_Load(object sender, EventArgs e)
        {
            AutoCompleteStudentNo();
            LoadRecords();

            dtIssueDate.Value = DateTime.Now;
            dtDueDate.Value = dtIssueDate.Value.AddDays(7);
        }

        public void LoadRecords()
        {
            int i = 0;
            gunaDataGridView3.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT bookID, bookTitle, bookISBN, subject, author, allCopies, availableCopies FROM tblBook WHERE bookTitle LIKE '" + txtSearchBook.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                gunaDataGridView3.Rows.Add(i, dr["bookID"].ToString(), dr["bookTitle"].ToString(), dr["bookISBN"].ToString(), dr["subject"].ToString(), dr["author"].ToString(), dr["allCopies"].ToString(), dr["availableCopies"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void BooksOnHand()
        {
            cn.Open();
            cm = new SqlCommand("SELECT COUNT(*) FROM tblBorrowedBook WHERE status = 'Not Returned' AND studentNum = '" + txtSearchStud.Text + "'", cn);
            lblBooksOnHand.Text = cm.ExecuteScalar().ToString();
            cn.Close();
        }

        public void BorrowHistory()
        {
            cn.Open();
            cm = new SqlCommand("SELECT COUNT(*) FROM tblBorrowedBook WHERE studentNum = '" + lblStudNo.Text + "'", cn);
            lblHistory.Text = cm.ExecuteScalar().ToString();
            cn.Close();
        }

        public void Notif()
        {
            popupNotifier.ContentText = lblBookTitle.Text + " has been issued to " + lblName.Text + " successfully!";
            popupNotifier.Popup();
        }

        public void BorrowBook()
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to issue '" + lblBookTitle.Text + "'?", "Issue Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblBorrowedBook (studentID, bookID, studentNum, bookTitle, dateBorrowed, dueDate, status) VALUES (@studentID, @bookID, @studentNum, @bookTitle, @dateBorrowed, @dueDate, 'Not Returned')", cn);
                    cm.Parameters.AddWithValue("@studentID", lblStudID.Text);
                    cm.Parameters.AddWithValue("@studentNum", lblStudNo.Text);
                    cm.Parameters.AddWithValue("@bookID", lblBookID.Text);
                    cm.Parameters.AddWithValue("@bookTitle", lblBookTitle.Text);
                    cm.Parameters.AddWithValue("@dateBorrowed", dtIssueDate.Value);
                    cm.Parameters.AddWithValue("@dueDate", dtDueDate.Value);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    Deduction();
                    gunaDataGridView3.Rows.Clear();
                    LoadRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        public void Deduction()
        {
            cn.Open();
            cm = new SqlCommand("UPDATE tblBook SET availableCopies = availableCopies - 1 WHERE bookTitle = '" + lblBookTitle.Text + "'", cn);
            cm.ExecuteNonQuery();
            cn.Close();
            Notif();
        }

        public void AutoCompleteStudentNo()
        {
            cn.Open();
            cm = new SqlCommand("SELECT studentNum FROM tblStudent", cn);
            dr = cm.ExecuteReader();
            AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                Collection.Add(dr.GetString(0));
            }
            txtSearchStud.AutoCompleteCustomSource = Collection;
            dr.Close();
            cn.Close();
        }


        public void Clear()
        {
            lblCourse.Text = "";
            lblName.Text = "";
            lblStudNo.Text = "";
            lblYear.Text = "";
            txtSearchStud.Text = "";
            lblBookAllCopies.Text = "00";
            lblAvailable.Text = "00";
            studImage.Image = Properties.Resources.user;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TxtSearchStud_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblStudent WHERE studentNUm ='" + txtSearchStud.Text + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                lblName.Text = dr["firstName"].ToString() + " " + dr["lastName"].ToString();
                lblStudNo.Text = dr["studentNum"].ToString();
                lblCourse.Text = dr["course"].ToString();
                lblYear.Text = dr["year"].ToString();
                lblStudID.Text = dr["studentID"].ToString();
                byte[] imgbytes = (byte[])dr["image"];
                MemoryStream mstream = new MemoryStream(imgbytes);
                studImage.Image = Image.FromStream(mstream);
            }
            dr.Close();
            cn.Close();
            BooksOnHand();
            BorrowHistory();
        }

        private void BtnProccessIssue_Click(object sender, EventArgs e)
        {
            if (txtSearchStud.Text == "")
            {
                txtSearchStud.Focus();
                MessageBox.Show("Please enter the student number", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                BorrowBook();
                Clear();
            }
        }

        private void TxtSearchBook_TextChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void GunaDataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblBookAllCopies.Text = gunaDataGridView3[6, e.RowIndex].Value.ToString();
            lblAvailable.Text = gunaDataGridView3[7, e.RowIndex].Value.ToString();
            lblBookID.Text = gunaDataGridView3[1, e.RowIndex].Value.ToString();
            lblBookTitle.Text = gunaDataGridView3[2, e.RowIndex].Value.ToString();
        }

        private void LblBooksOnHand_Click(object sender, EventArgs e)
        {
            frmBooksOnHand frm = new frmBooksOnHand();
            frm.gunaDataGridView1.Rows.Clear();
            int i = 0;
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblBorrowedBook WHERE status = 'Not Returned' AND studentNum = '" + lblStudNo.Text + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                frm.gunaDataGridView1.Rows.Add(i, dr["borrowID"].ToString(), dr["studentID"].ToString(), dr["bookID"].ToString(), dr["studentNum"].ToString(), dr["bookTitle"].ToString(), Convert.ToDateTime(dr["dateBorrowed"]).ToString("MM/dd/yyyy"), Convert.ToDateTime(dr["dueDate"]).ToString("MM/dd/yyyy"), dr["returnedDate"].ToString(), dr["status"].ToString());
            }
            dr.Close();
            cn.Close();
            frm.Show();
        }
    }
}