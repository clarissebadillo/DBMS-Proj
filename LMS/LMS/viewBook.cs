using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LMS
{
    public partial class viewBook : UserControl
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmListOfBooks frmlist;

        public viewBook(frmListOfBooks flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmlist = flist;
        }


        public void RetrieveData()
        {
            frmAddBook frm = new frmAddBook(frmlist);
            frmListOfBooks f = new frmListOfBooks();
            cn.Open();
            cm = new SqlCommand("SELECT * from tblBook WHERE bookID = @bookID", cn);
            cm.Parameters.AddWithValue("@bookID", lblID.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                frm.btnSave.Enabled = false;
                frm.lblTitle.Text = "Edit Book Details";
                frm.lblID.Text = dr["bookID"].ToString();
                frm.txtTitle.Text = dr["bookTitle"].ToString();
                frm.txtISBN.Text = dr["bookISBN"].ToString();
                frm.cboSubject.Text = dr["subject"].ToString();
                frm.cboGenre.Text = dr["genre"].ToString();
                frm.cboMediaType.Text = dr["mediaType"].ToString();
                frm.txtLanguage.Text = dr["language"].ToString();
                frm.txtAuthor.Text = dr["author"].ToString();
                frm.txtPublisher.Text = dr["publisher"].ToString();
                frm.txtPrice.Text = dr["price"].ToString();
                frm.txtYear.Text = dr["pubYear"].ToString();
                frm.txtCopies.Text = dr["allCopies"].ToString();
                frm.txtCopies.Text = dr["availableCopies"].ToString();
            }
            dr.Close();
            cn.Close();
            frm.Show();
        }

        public void LoadToLabels()
        {
            cn.Open();
            cm = new SqlCommand("SELECT b.*, (SELECT COUNT(*) FROM tblBorrowedBook bb WHERE bb.status IN ('Not Returned', 'Overdue') AND bb.bookID = b.bookID) AS BookBorrowed, (SELECT COUNT(*) FROM tblBorrowedBook bb WHERE bb.status = 'Lost' AND bb.bookID = b.bookID) AS BookLost FROM tblBook b WHERE bookID = @bookID", cn);
            cm.Parameters.AddWithValue("@bookID", lblID.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                frmlist.lblBookTitle.Text = dr["bookTitle"].ToString();
                frmlist.lblISBN.Text = dr["bookISBN"].ToString();
                frmlist.lblSubject.Text = dr["subject"].ToString();
                frmlist.lblGenre.Text = dr["genre"].ToString();
                frmlist.lblMediaType.Text = dr["mediaType"].ToString();
                frmlist.lblLanguage.Text = dr["language"].ToString();
                frmlist.lblAuthor.Text = dr["author"].ToString();
                frmlist.lblPublisher.Text = dr["publisher"].ToString();
                frmlist.lblPrice.Text = dr["price"].ToString();
                frmlist.lblYear.Text = dr["pubYear"].ToString();
                frmlist.lblAllCopies.Text = dr["allCopies"].ToString();
                frmlist.lblAvailable.Text = dr["availableCopies"].ToString();
                frmlist.lblBorrowed.Text = dr["BookBorrowed"].ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
             RetrieveData();
        }

        private void GunaLinePanel1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(234, 162, 44);
            //panel1.Visible = true;
        }

        private void GunaLinePanel1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            //panel1.Visible = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove " + lblBookName.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("DELETE from tblBook WHERE bookID = @bookID", cn);
                cm.Parameters.AddWithValue("@bookID", lblID.Text);
                cm.ExecuteNonQuery();
                cn.Close();

                popupNotifier.ContentText = "Record has been successfully removed!";
                popupNotifier.Popup();
                frmlist.RetrieveBook();
            }
        }

        private void GunaLinePanel1_Click(object sender, EventArgs e)
        {
            LoadToLabels();
        }
    }
}
