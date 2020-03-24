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
        string stitle = "Library Management System";
        Form1 f1;

        public frmBookList(Form1 frm1)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadRecords();
            f1 = frm1;
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

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            frmAddEditBook frm = new frmAddEditBook(this);
            frm.btnUpdate.Enabled = false;
            frm.Show();
        }

        public void LoadRecords()
        {
            int i = 0;
            gunaDataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblBook WHERE bkTitle LIKE '" + txtSearch.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                gunaDataGridView1.Rows.Add(i, dr["bookID"].ToString(), dr["bkTitle"].ToString(), dr["bkISBN"].ToString(), dr["bkSubject"].ToString(), dr["bkGenre"].ToString(), dr["bkMediaType"].ToString(), dr["bkLanguage"].ToString(), dr["bkAuthor"].ToString(), dr["bkPublisher"].ToString(), dr["bkPrice"].ToString(), dr["bkYear"].ToString(), dr["bkAllCopies"].ToString(), dr["bkCopies"].ToString(), dr["bkLost"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadSubjects()
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblBook WHERE bkSubject LIKE '" + cboSubject.SelectedIndex.ToString() + "%'", cn);
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
                    MessageBox.Show("Record has been successfully deleted!", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnIssueBook_Click(object sender, EventArgs e)
        {
            f1.ShowIssueBook();
        }
    }
}
