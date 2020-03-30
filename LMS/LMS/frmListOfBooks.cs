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
    public partial class frmListOfBooks : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmListOfBooks()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void FrmListOfBooks_Load(object sender, EventArgs e)
        {
            RetrieveBook();
        }

        void CountBorrowed()
        {
            cn.Open();
            cm = new SqlCommand("SELECT COUNT(*)  FROM tblBorrowedBook WHERE status IN('Not Returned', 'Overdue') AND bookID = @bookID", cn);

            cn.Close();
        }

        public void RetrieveBook()
        {
            flowLayoutPanel1.Controls.Clear();
            cn.Open();
            cm = new SqlCommand ("SELECT bookID, bookTitle, bookISBN, subject, author FROM tblBook WHERE bookTitle LIKE '" + txtSearch.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                viewBook uc = new viewBook(this);
                uc.Dock = DockStyle.Top;
                uc.lblID.Text = dr["bookID"].ToString();
                uc.lblBookName.Text = dr["bookTitle"].ToString();
                uc.lblBookISBN.Text = dr["bookISBN"].ToString();
                uc.lblSubject.Text = dr["subject"].ToString();
                uc.lblAuthor.Text = dr["author"].ToString();
                flowLayoutPanel1.Controls.Add(uc);
            }
            dr.Close();
            cn.Close();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            frmAddBook frm = new frmAddBook(this);
            frm.btnUpdate.Enabled = false;
            frm.Show();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            RetrieveBook();
        }
    }
}
