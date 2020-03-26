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

namespace LMS
{
    public partial class frmBookList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmBookList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
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
            cboSubject.SelectedIndex = 0;
        }

        public void LoadRecords()
        {
            int i = 0;
            gunaDataGridView1.Rows.Clear();
            cn.Open();
            //cm = new SqlCommand("SELECT * FROM tblBook WHERE bookTitle LIKE '" + txtSearch.Text + "%'", cn);
            cm = new SqlCommand("SELECT b.*, (SELECT COUNT(*) FROM tblBorrowedBook bb WHERE bb.status = 'Not Returned' AND bb.bookID = b.bookID) AS BookBorrowed, (SELECT COUNT(*) FROM tblBorrowedBook bb WHERE bb.status = 'Lost' AND bb.bookID = b.bookID) AS BookLost FROM tblBook b WHERE bookTitle LIKE '" + txtSearch.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                gunaDataGridView1.Rows.Add(i, dr["bookID"].ToString(), dr["bookTitle"].ToString(), dr["bookISBN"].ToString(), dr["subject"].ToString(), dr["genre"].ToString(), dr["mediaType"].ToString(), dr["language"].ToString(), dr["author"].ToString(), dr["publisher"].ToString(), dr["price"].ToString(), dr["pubYear"].ToString(), dr["allCopies"].ToString(), dr["availableCopies"].ToString(), dr["BookBorrowed"].ToString(), dr["BookLost"].ToString());//, dr["lostCopies"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadSubjects()
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblBook WHERE subject LIKE '" + cboSubject.SelectedIndex.ToString() + "%'", cn);
            cm.ExecuteNonQuery();
            cn.Close();
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
            lblPrice.Text = gunaDataGridView1[10, e.RowIndex].Value.ToString();
            lblYear.Text = gunaDataGridView1[11, e.RowIndex].Value.ToString();
            lblAllCopies.Text = gunaDataGridView1[12, e.RowIndex].Value.ToString();
            lblAvailable.Text = gunaDataGridView1[13, e.RowIndex].Value.ToString();
            lblBorrowed.Text = gunaDataGridView1[14, e.RowIndex].Value.ToString();
            lblLost.Text = gunaDataGridView1[15, e.RowIndex].Value.ToString();

            string colName = gunaDataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmAddEditBook frm = new frmAddEditBook(this);
                frm.btnSave.Enabled = false;
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
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblBook WHERE bookID like '" + gunaDataGridView1[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    popupNotifier.ContentText = "Record has been successfully removed!";
                    popupNotifier.Popup();
                    LoadRecords();
                }
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
            frm.ShowDialog();
        }
    }
}
