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

namespace LMS
{
    public partial class frmStudentList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string stitle = "Library Management System";

        public frmStudentList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadRecords();
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddEditStudent frm = new frmAddEditStudent(this);
            frm.btnUpdate.Enabled = false;
            frm.Show();
        }

        public void LoadRecords()
        {
            int i = 0;
            gunaDataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblStudent WHERE stLname LIKE '" + txtSearch.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                gunaDataGridView1.Rows.Add(i, dr["studID"].ToString(), dr["stNumber"].ToString(), dr["stLname"].ToString(), dr["stFname"].ToString(), dr["stCourse"].ToString(), dr["stYear"].ToString(), dr["stGender"].ToString(), dr["stContact"].ToString(), dr["stEmail"].ToString(), dr["stAddress"].ToString(), dr["stImage"]);
            }
            dr.Close();
            cn.Close();
        }

        


        private void GunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colName = gunaDataGridView1.Columns[e.ColumnIndex].Name;

            if (colName == "Edit")
            {
                frmAddEditStudent frm = new frmAddEditStudent(this);
                frm.btnSave.Enabled = false;
                frm.lblTitle.Text = "Edit Book Details";
                frm.lblID.Text = gunaDataGridView1[1, e.RowIndex].Value.ToString();
                frm.txtStudNo.Text = gunaDataGridView1[2, e.RowIndex].Value.ToString();
                frm.txtLname.Text = gunaDataGridView1[3, e.RowIndex].Value.ToString();
                frm.txtFname.Text = gunaDataGridView1[4, e.RowIndex].Value.ToString();
                frm.cboCourse.Text = gunaDataGridView1[5, e.RowIndex].Value.ToString();
                frm.cboYear.Text = gunaDataGridView1[6, e.RowIndex].Value.ToString();
                frm.txtContact.Text = gunaDataGridView1[8, e.RowIndex].Value.ToString();
                frm.txtEmail.Text = gunaDataGridView1[9, e.RowIndex].Value.ToString();
                frm.txtAddress.Text = gunaDataGridView1[10, e.RowIndex].Value.ToString();
                //Load Image
                byte[] bytes = (byte[])gunaDataGridView1[11, e.RowIndex].Value;
                MemoryStream ms = new MemoryStream(bytes);
                frm.studImage.Image = Image.FromStream(ms);
                //Show
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblStudent WHERE studID like '" + gunaDataGridView1[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted!", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }
        }
    }
}
