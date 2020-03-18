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
            frmAddEditStudent frm = new frmAddEditStudent();
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
                gunaDataGridView1.Rows.Add(i, dr["studID"].ToString(), dr["stNumber"].ToString(), dr["stLname"].ToString(), dr["stFname"].ToString(), dr["stCourse"].ToString(), dr["styear"].ToString(), dr["stGender"].ToString(), dr["stContact"].ToString(), dr["stEmail"].ToString(), dr["stAddress"].ToString());
            }
            dr.Close();
            cn.Close();
        }
    }
}
