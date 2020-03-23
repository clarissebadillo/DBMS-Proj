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
    public partial class frmDashboard : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        public frmDashboard()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            curDate.Value = DateTime.Now;
            CountBooks();
            CountStudents();
            CountBorrowToday();
        }

        public void CountBooks()
        {
            cn.Open();
            cm = new SqlCommand("SELECT COUNT(*) FROM tblBook", cn);
            lblTotalBooks.Text = cm.ExecuteScalar().ToString();
            cn.Close();
        }

        public void CountStudents()
        {
            cn.Open();
            cm = new SqlCommand("SELECT COUNT(*) FROM tblStudent", cn);
            lblTotalStudent.Text = cm.ExecuteScalar().ToString();
            cn.Close();
        }

        public void CountBorrowToday()
        {
            cn.Open();
            //cmd.CommandText = "select count(*) from borrow where date = curdate()";
            cm = new SqlCommand("SELECT COUNT(*) FROM tblIssueBook WHERE releaseDate = '" + curDate.Value + "'", cn);
            //lblBorrowed.Text = Convert.ToDateTime(cm.ExecuteScalar().ToString());
            cn.Close();
        }
    }
}
