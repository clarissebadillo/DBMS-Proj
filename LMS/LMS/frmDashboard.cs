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
            CountBooks();
            CountStudents();
            CountBorrowToday();
            CountReturnToday();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 15000;//5 seconds
            timer.Tick += new System.EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CountBooks();
            CountStudents();
            CountBorrowToday();
            CountReturnToday();
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
            cm = new SqlCommand("SELECT COUNT(*) FROM tblBorrowedBook WHERE dateBorrowed = CAST(GETDATE() AS DATE)", cn);
            lblBorrowed.Text = cm.ExecuteScalar().ToString();
            cn.Close();
        }

        public void CountReturnToday()
        {
            cn.Open();
            cm = new SqlCommand("SELECT COUNT(*) FROM tblBorrowedBook WHERE returnedDate = CAST(GETDATE() AS DATE)", cn);
            lblReturned.Text = cm.ExecuteScalar().ToString();
            cn.Close();
        }
    }
}
