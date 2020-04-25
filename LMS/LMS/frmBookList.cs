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
using MyMessage;

namespace LMS
{
    public partial class frmBookList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        Form1 frm1;

        string admin;

        public frmBookList(Form1 f1)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frm1 = f1;
            admin = frm1.lblLibrarian.Text;

            LoadRecords();
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

        private void FrmBookList_Load(object sender, EventArgs e)
        {
            //DataGridView Padding
            gunaDataGridView1.Columns[3].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView1.Columns[4].DefaultCellStyle.Padding = new Padding(30, 0, 0, 0);
            gunaDataGridView1.Columns[5].DefaultCellStyle.Padding = new Padding(30, 0, 0, 0);
            gunaDataGridView1.Columns[8].DefaultCellStyle.Padding = new Padding(30, 0, 0, 0);

            gunaDataGridView1.Columns[3].HeaderCell.Style.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView1.Columns[4].HeaderCell.Style.Padding = new Padding(30, 0, 0, 0);
            gunaDataGridView1.Columns[5].HeaderCell.Style.Padding = new Padding(30, 0, 0, 0);
            gunaDataGridView1.Columns[8].HeaderCell.Style.Padding = new Padding(30, 0, 0, 0);

            LoadAllSubjects();
            cboSubject.SelectedItem = "All Subjects";
        }

        void LoadAllSubjects()
        {
            cboSubject.Items.Clear();
            cboSubject.Items.Add("All Subjects");
            cn.Open();
            cm = new SqlCommand("SELECT subject FROM tblSubjects", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cboSubject.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
            cboSubject.Items.Add("Others");
        }

        public void LoadRecords()
        {
            int i = 0;
            gunaDataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT b.*, (SELECT COUNT(*) FROM tblBorrowedBook bb WHERE bb.status IN ('Not Returned', 'Overdue') AND bb.bookID = b.bookID) AS BookBorrowed, (SELECT COUNT(*) FROM tblBorrowedBook bb WHERE bb.status = 'Lost' AND bb.bookID = b.bookID) AS BookLost FROM tblBook b WHERE bookTitle LIKE '" + txtSearch.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                gunaDataGridView1.Rows.Add(i, dr["bookID"].ToString(), dr["bookTitle"].ToString(), dr["bookISBN"].ToString(), dr["subject"].ToString(), dr["genre"].ToString(), dr["mediaType"].ToString(), dr["language"].ToString(), dr["author"].ToString(), dr["publisher"].ToString(), dr["price"].ToString(), dr["pubYear"].ToString(), dr["allCopies"].ToString(), dr["availableCopies"].ToString(), dr["BookBorrowed"].ToString(), dr["BookLost"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        //Combobox search
        public void LoadSubjects()
        {
            int i = 0;
            if (cboSubject.Text == "All Subjects")
            {
                gunaDataGridView1.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT b.*, (SELECT COUNT(*) FROM tblBorrowedBook bb WHERE bb.status IN ('Not Returned', 'Overdue') AND bb.bookID = b.bookID) AS BookBorrowed, (SELECT COUNT(*) FROM tblBorrowedBook bb WHERE bb.status = 'Lost' AND bb.bookID = b.bookID) AS BookLost FROM tblBook b", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    gunaDataGridView1.Rows.Add(i, dr["bookID"].ToString(), dr["bookTitle"].ToString(), dr["bookISBN"].ToString(), dr["subject"].ToString(), dr["genre"].ToString(), dr["mediaType"].ToString(), dr["language"].ToString(), dr["author"].ToString(), dr["publisher"].ToString(), dr["price"].ToString(), dr["pubYear"].ToString(), dr["allCopies"].ToString(), dr["availableCopies"].ToString(), dr["BookBorrowed"].ToString(), dr["BookLost"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            else
            {
                gunaDataGridView1.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT b.*, (SELECT COUNT(*) FROM tblBorrowedBook bb WHERE bb.status IN ('Not Returned', 'Overdue') AND bb.bookID = b.bookID) AS BookBorrowed, (SELECT COUNT(*) FROM tblBorrowedBook bb WHERE bb.status = 'Lost' AND bb.bookID = b.bookID) AS BookLost FROM tblBook b WHERE subject LIKE '" + cboSubject.Text + "%'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    gunaDataGridView1.Rows.Add(i, dr["bookID"].ToString(), dr["bookTitle"].ToString(), dr["bookISBN"].ToString(), dr["subject"].ToString(), dr["genre"].ToString(), dr["mediaType"].ToString(), dr["language"].ToString(), dr["author"].ToString(), dr["publisher"].ToString(), dr["price"].ToString(), dr["pubYear"].ToString(), dr["allCopies"].ToString(), dr["availableCopies"].ToString(), dr["BookBorrowed"].ToString(), dr["BookLost"].ToString());
                }
                dr.Close();
                cn.Close();
            }
        }


        private void GunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Load to labels
            lblBookTitle.Text = gunaDataGridView1[2, e.RowIndex].Value.ToString();
            lblISBN.Text = gunaDataGridView1[3, e.RowIndex].Value.ToString();
            lblSubject.Text = gunaDataGridView1[4, e.RowIndex].Value.ToString();
            lblGenre.Text = gunaDataGridView1[5, e.RowIndex].Value.ToString();
            lblMediaType.Text = gunaDataGridView1[6, e.RowIndex].Value.ToString();
            lblLanguage.Text = gunaDataGridView1[7, e.RowIndex].Value.ToString();
            lblAuthor.Text = gunaDataGridView1[8, e.RowIndex].Value.ToString();
            lblPublisher.Text = gunaDataGridView1[9, e.RowIndex].Value.ToString();
            lblPrice.Text = "₱" + Convert.ToDouble(gunaDataGridView1[10, e.RowIndex].Value).ToString("N");
            lblYear.Text = gunaDataGridView1[11, e.RowIndex].Value.ToString();
            lblAllCopies.Text = gunaDataGridView1[12, e.RowIndex].Value.ToString();
            lblAvailable.Text = gunaDataGridView1[13, e.RowIndex].Value.ToString();
            lblBorrowed.Text = gunaDataGridView1[14, e.RowIndex].Value.ToString();
            lblLost.Text = gunaDataGridView1[15, e.RowIndex].Value.ToString();

            string colName = gunaDataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmAddEditBook frm = new frmAddEditBook(this);
                frm.lblLibrarian.Text = admin;
                frm.btnSave.Enabled = false;
                frm.txtCopies.Enabled = false;
                frm.lblTitle.Text = "Edit Book Details";
                frm.lblID.Text = gunaDataGridView1[1, e.RowIndex].Value.ToString();
                frm.txtTitle.Text = gunaDataGridView1[2, e.RowIndex].Value.ToString();
                frm.txtISBN.Text = gunaDataGridView1[3, e.RowIndex].Value.ToString();
                frm.cboSubject.Text = gunaDataGridView1[4, e.RowIndex].Value.ToString();
                frm.cboGenre.Text = gunaDataGridView1[5, e.RowIndex].Value.ToString();
                frm.cboMediaType.Text = gunaDataGridView1[6, e.RowIndex].Value.ToString();
                frm.txtLanguage.Text = gunaDataGridView1[7, e.RowIndex].Value.ToString();
                frm.txtAuthor.Text = gunaDataGridView1[8, e.RowIndex].Value.ToString();
                frm.txtPublisher.Text = gunaDataGridView1[9, e.RowIndex].Value.ToString();
                frm.txtPrice.Text = gunaDataGridView1[10, e.RowIndex].Value.ToString();
                frm.txtYear.Text = gunaDataGridView1[11, e.RowIndex].Value.ToString();
                frm.txtCopies.Text = gunaDataGridView1[12, e.RowIndex].Value.ToString();
                frm.ShowDialog();
            }
            else if (colName == "AddCopy")
            {
                frmAcquireBooks frm = new frmAcquireBooks(this);
                frm.lblLibrarian.Text = admin;
                frm.lblBookTitle.Text = gunaDataGridView1[2, e.RowIndex].Value.ToString();
                frm.lblAlLCopies.Text = gunaDataGridView1[12, e.RowIndex].Value.ToString();
                frm.lblAvailCopies.Text = gunaDataGridView1[13, e.RowIndex].Value.ToString();
                frm.ShowDialog();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void CboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadSubjects();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            frmAddEditBook frm = new frmAddEditBook(this);
            frm.btnUpdate.Enabled = false;
            frm.lblLibrarian.Text = admin;
            frm.ShowDialog();
        }

        private void CboSubject_TextChanged(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        void RemoveBookLogs()
        {
            var details = frm1.lblLibrarian.Text + " removed " + lblBookTitle.Text + " from the book list";

            cn.Open();
            cm = new SqlCommand("INSERT INTO tblLogs VALUES (@details, GETDATE())", cn);
            cm.Parameters.AddWithValue("@details", details);
            cm.ExecuteNonQuery();
            cn.Close();
        }

    }
}
