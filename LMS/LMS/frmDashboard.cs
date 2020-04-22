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
using System.Windows.Forms.DataVisualization.Charting;

namespace LMS
{
    public partial class frmDashboard : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      // WS_EX_COMPOSITED
                return handleParam;
            }
        }

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
            LatestBorrower();
            LoadChart();
            ClearedPayments();
            PendingPayments();

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
            ClearedPayments();
            PendingPayments();
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

        public void ClearedPayments()
        {
            cn.Open();
            cm = new SqlCommand("SELECT ISNULL(SUM(totalPayment), 0.00) FROM tblPayment", cn);
            lblClearedPayments.Text = "₱" + Convert.ToDouble(cm.ExecuteScalar()).ToString("N");
            cn.Close();
        }

        public void PendingPayments()
        {
            cn.Open();
            cm = new SqlCommand("SELECT ISNULL(SUM(totalFine), 0.00) FROM tblBorrowedBook WHERE paymentStatus = 'Pending'", cn);
            lblPendingPayment.Text = "₱" + Convert.ToDouble(cm.ExecuteScalar()).ToString("N"); 
            cn.Close();
        }

        public void LatestBorrower()
        {
            int i = 0;
            gunaDataGridView1.Rows.Clear();
            cm = new SqlCommand("SELECT TOP 8 b.borrowID, b.studentNum, (s.firstName + ' ' + s.lastName) AS name, b.bookTitle, b.dateBorrowed FROM tblBorrowedBook b INNER JOIN tblStudent s ON b.studentID = s.studentID ORDER BY borrowID DESC", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                gunaDataGridView1.Rows.Add(i, dr["borrowID"].ToString(), dr["studentNum"].ToString(), dr["name"].ToString(), dr["bookTitle"].ToString(), Convert.ToDateTime(dr["dateBorrowed"]).ToString("MMMM dd, yyyy"));
            }
            dr.Close();
            cn.Close();
        }

        public void LoadChart()
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DateName(MONTH, paymentDate) AS month, isnull(SUM(totalPayment), 0.0) as total FROM tblPayment GROUP BY DateName(MONTH, paymentDate)", cn);
            DataSet ds = new DataSet();

            da.Fill(ds);
            chart1.DataSource = ds.Tables[0];
            Series series1 = chart1.Series["Series1"];

            chart1.Series[0].XValueMember = "month";
            chart1.Series[0].YValueMembers = "total";

            chart1.Series[0].IsValueShownAsLabel = true;

            cn.Close();
        }

    }
}
