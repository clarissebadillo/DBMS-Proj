using System;
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
            LoadBooks();

            dtIssueDate.Value = DateTime.Now;
            dtDueDate.Value = dtIssueDate.Value.AddDays(7);
        }

        public void Notif()
        {
            popupNotifier.ContentText = cboBooks.Text + " has been issued to " + lblName.Text + " successfully!";
            popupNotifier.Popup();
        }

        public void BorrowBook()
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to issue this book?", "Issue Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //open connection to the database
                    cn.Open();
                    //command to be executed on the database
                    cm = new SqlCommand("INSERT INTO tblBorrowedBook (studentID, bookID, studentNum, bookTitle, dateBorrowed, dueDate, status) VALUES (@studentID, @bookID, @studentNum, @bookTitle, @dateBorrowed, @dueDate, 'Not Returned')", cn);
                    //set parameters value
                    cm.Parameters.AddWithValue("@studentID", lblStudID.Text);
                    cm.Parameters.AddWithValue("@bookID", lblBookID.Text);
                    cm.Parameters.AddWithValue("@studentNum", txtSearchStud.Text);
                    cm.Parameters.AddWithValue("@bookTitle", cboBooks.Text);
                    cm.Parameters.AddWithValue("@dateBorrowed", dtIssueDate.Value);
                    cm.Parameters.AddWithValue("@dueDate", dtDueDate.Value);
                    //ask db to execute query
                    cm.ExecuteNonQuery();
                    Deduction();
                    //StudentPossession();
                    //close connection
                    cn.Close();
                    //Notif();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Deduction()
        {
            cm = new SqlCommand("UPDATE tblBook SET availableCopies = availableCopies - 1 WHERE bookTitle = '" + cboBooks.Text + "'", cn);
            cm.ExecuteNonQuery();
            Notif();
        }

        //public void StudentPossession()
        //{
        //    cm = new SqlCommand("UPDATE tblStudent SET stCopies = stCopies + 1 WHERE studID = '" + lblStudID.Text + "'", cn);
        //    cm.ExecuteNonQuery();
        //}

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

        public void LoadBooks()
        {
            cboBooks.Items.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT bookTitle FROM tblBook", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cboBooks.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void Clear()
        {
            lblAuthor.Text = "";
            lblCourse.Text = "";
            lblISBN.Text = "";
            lblName.Text = "";
            lblStudNo.Text = "";
            lblSubject.Text = "";
            lblTitle.Text = "";
            lblYear.Text = "";
            cboBooks.Items.Clear();
            txtSearchStud.Text = "";
            studImage.Image = Properties.Resources.user;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnProccessIssue_Click(object sender, EventArgs e)
        {
            if (txtSearchStud.Text == "" || cboBooks.Text == "")
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

        private void CboBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblBook WHERE bookTitle ='" + cboBooks.Text + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                lblTitle.Text = dr["bookTitle"].ToString();
                lblISBN.Text = dr["bookISBN"].ToString();
                lblSubject.Text = dr["subject"].ToString();
                lblAuthor.Text = dr["author"].ToString();
                lblBookID.Text = dr["bookID"].ToString();
            }
            dr.Close();
            cn.Close();
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
        }
    }
}
