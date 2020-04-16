using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LMS
{
    public partial class frmHistory : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmHistory()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
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

        private void FrmHistory_Load(object sender, EventArgs e)
        {
            //BORROW HISTORY
            LoadAllBorrowHistory();

            dt1.Value = DateTime.Today.AddDays(-1);
            dt2.Value = DateTime.Now;

            cboStatus.SelectedItem = "All Records";

            //DataGridView Padding
            gunaDataGridView1.Columns[2].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView1.Columns[3].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView1.Columns[4].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView1.Columns[5].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView1.Columns[6].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView1.Columns[7].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView1.Columns[8].DefaultCellStyle.Padding = new Padding(20, 0, 20, 0);

            gunaDataGridView1.Columns[2].HeaderCell.Style.Padding = new Padding(20, 5, 0, 5);
            gunaDataGridView1.Columns[3].HeaderCell.Style.Padding = new Padding(20, 5, 0, 5);
            gunaDataGridView1.Columns[4].HeaderCell.Style.Padding = new Padding(20, 5, 0, 5);
            gunaDataGridView1.Columns[5].HeaderCell.Style.Padding = new Padding(20, 5, 0, 5);
            gunaDataGridView1.Columns[6].HeaderCell.Style.Padding = new Padding(20, 5, 0, 5);
            gunaDataGridView1.Columns[7].HeaderCell.Style.Padding = new Padding(20, 5, 0, 5);
            gunaDataGridView1.Columns[8].HeaderCell.Style.Padding = new Padding(20, 5, 20, 5);

            //RETURN HISTORY
            LoadReturnHistory();

            dtFrom.Value = DateTime.Today.AddDays(-1);
            dtTo.Value = DateTime.Now;

            gunaDataGridView2.Columns[2].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView2.Columns[3].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView2.Columns[4].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView2.Columns[5].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView2.Columns[6].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView2.Columns[7].DefaultCellStyle.Padding = new Padding(20, 0, 30, 0);

            gunaDataGridView2.Columns[2].HeaderCell.Style.Padding = new Padding(20, 5, 0, 5);
            gunaDataGridView2.Columns[3].HeaderCell.Style.Padding = new Padding(20, 5, 0, 5);
            gunaDataGridView2.Columns[4].HeaderCell.Style.Padding = new Padding(20, 5, 0, 5);
            gunaDataGridView2.Columns[5].HeaderCell.Style.Padding = new Padding(20, 5, 0, 5);
            gunaDataGridView2.Columns[6].HeaderCell.Style.Padding = new Padding(20, 5, 0, 5);
            gunaDataGridView2.Columns[7].HeaderCell.Style.Padding = new Padding(20, 5, 20, 5);

            //PAYMENT HISTORY
            LoadAllPaymentHistory();
            dt3.Value = DateTime.Today.AddDays(-1);
            dt4.Value = DateTime.Now;

            gunaDataGridView3.Columns[2].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView3.Columns[3].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView3.Columns[4].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView3.Columns[5].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView3.Columns[6].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView3.Columns[7].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            gunaDataGridView3.Columns[8].DefaultCellStyle.Padding = new Padding(20, 0, 20, 0);

            gunaDataGridView3.Columns[2].HeaderCell.Style.Padding = new Padding(20, 5, 0, 5);
            gunaDataGridView3.Columns[3].HeaderCell.Style.Padding = new Padding(20, 5, 0, 5);
            gunaDataGridView3.Columns[4].HeaderCell.Style.Padding = new Padding(20, 5, 0, 5);
            gunaDataGridView3.Columns[5].HeaderCell.Style.Padding = new Padding(20, 5, 0, 5);
            gunaDataGridView3.Columns[6].HeaderCell.Style.Padding = new Padding(20, 5, 0, 5);
            gunaDataGridView3.Columns[7].HeaderCell.Style.Padding = new Padding(20, 5, 0, 5);
            gunaDataGridView3.Columns[8].HeaderCell.Style.Padding = new Padding(20, 5, 20, 5);

            //ACTIVITY LOGS
            LoadActivityHistory();
            dt5.Value = DateTime.Today.AddDays(-1);
            dt6.Value = DateTime.Now;
        }

        public void LoadAllBorrowHistory()
        {
            int i = 0;
            if (cboStatus.Text == "All Records")
            {
                gunaDataGridView1.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT bb.borrowID,  bb.bookTitle,  bb.studentNum, (s.lastName + ' ' + s.firstName) AS Name, bb.dateBorrowed, bb.dueDate, bb.status, bb.librarian FROM tblBorrowedBook as bb INNER JOIN tblStudent AS s ON bb.studentID = s.studentID WHERE dateBorrowed BETWEEN @dt1 AND @dt2", cn);
                cm.Parameters.AddWithValue("@dt1", dt1.Value);
                cm.Parameters.AddWithValue("@dt2", dt2.Value);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    gunaDataGridView1.Rows.Add(i, dr["borrowID"].ToString(), dr["bookTitle"].ToString(), dr["studentNum"].ToString(), dr["Name"].ToString(), dr["librarian"].ToString(), Convert.ToDateTime(dr["dateBorrowed"]).ToString("MM/dd/yyyy"), Convert.ToDateTime(dr["dueDate"]).ToString("MM/dd/yyyy"), dr["status"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            else
            {
                gunaDataGridView1.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT bb.borrowID,  bb.bookTitle,  bb.studentNum, (s.lastName + ' ' + s.firstName) AS Name, bb.dateBorrowed, bb.dueDate, bb.status, bb.librarian FROM tblBorrowedBook as bb INNER JOIN tblStudent AS s ON bb.studentID = s.studentID WHERE status LIKE @status AND dateBorrowed BETWEEN @dt1 AND @dt2", cn);
                cm.Parameters.AddWithValue("@status", cboStatus.Text);
                cm.Parameters.AddWithValue("@dt1", dt1.Value);
                cm.Parameters.AddWithValue("@dt2", dt2.Value);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    gunaDataGridView1.Rows.Add(i, dr["borrowID"].ToString(), dr["bookTitle"].ToString(), dr["studentNum"].ToString(), dr["Name"].ToString(), dr["librarian"].ToString(), Convert.ToDateTime(dr["dateBorrowed"]).ToString("MM/dd/yyyy"), Convert.ToDateTime(dr["dueDate"]).ToString("MM/dd/yyyy"), dr["status"].ToString());
                }
                dr.Close();
                cn.Close();
            }
        }

        private void CboStatus_TextChanged(object sender, EventArgs e)
        {
            LoadAllBorrowHistory();
        }

        private void Dt1_ValueChanged(object sender, EventArgs e)
        {
            LoadAllBorrowHistory();
        }

        private void Dt2_ValueChanged(object sender, EventArgs e)
        {
            LoadAllBorrowHistory();
        }


        //RETURN HISTORY TAB
        public void LoadReturnHistory()
        {
            int i = 0;
            gunaDataGridView2.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT bb.borrowID,  bb.bookTitle,  bb.studentNum, (s.lastName + ' ' + s.firstName) AS Name, bb.returnedDate, bb.status, bb.librarian FROM tblBorrowedBook as bb INNER JOIN tblStudent AS s ON bb.studentID = s.studentID WHERE status = 'Returned' AND returnedDate BETWEEN @dtFrom AND @dtTo", cn);
            cm.Parameters.AddWithValue("@dtFrom", dtFrom.Value);
            cm.Parameters.AddWithValue("@dtTo", dtTo.Value);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                gunaDataGridView2.Rows.Add(i, dr["borrowID"].ToString(), dr["bookTitle"].ToString(), dr["studentNum"].ToString(), dr["Name"].ToString(), dr["librarian"].ToString(), Convert.ToDateTime(dr["returnedDate"]).ToString("MM/dd/yyyy"), dr["status"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void DtFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadReturnHistory();
        }

        private void DtTo_ValueChanged(object sender, EventArgs e)
        {
            LoadReturnHistory();
        }


        //PAYMENT HISTORY TAB
        public void LoadAllPaymentHistory()
        {
            int i = 0;
            gunaDataGridView3.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT p.paymentID, p.totalPayment, p.paymentDate, p.summaryDesc, p.librarian, (s.lastName + ' ' + s.firstName) AS Name, s.studentNum, bb.paymentStatus FROM ((tblPayment AS p INNER JOIN tblStudent AS s ON p.studentID = s.studentID) INNER JOIN tblBorrowedBook  AS bb ON p.studentID = bb.studentID) WHERE bb.paymentStatus = 'Cleared' AND paymentDate BETWEEN @dt3 AND @dt4", cn);
            cm.Parameters.AddWithValue("@dt3", dt3.Value);
            cm.Parameters.AddWithValue("@dt4", dt4.Value);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                gunaDataGridView3.Rows.Add(i, dr["paymentID"].ToString(), dr["studentNum"].ToString(), dr["Name"].ToString(), dr["summaryDesc"].ToString(), dr["librarian"].ToString(), Convert.ToDateTime(dr["paymentDate"]).ToString("MM/dd/yyyy"), dr["totalPayment"].ToString(), dr["paymentStatus"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void Dt3_ValueChanged(object sender, EventArgs e)
        {
            LoadAllPaymentHistory();
        }

        private void Dt4_ValueChanged(object sender, EventArgs e)
        {
            LoadAllPaymentHistory();
        }


        //ACTIVITY LOGS
        public void LoadActivityHistory()
        {
            int i = 0;
            gunaDataGridView4.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblLogs WHERE date BETWEEN @dt5 AND @dt6", cn);
            cm.Parameters.AddWithValue("@dt5", dt5.Value);
            cm.Parameters.AddWithValue("@dt6", dt6.Value);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                gunaDataGridView4.Rows.Add(i, dr["logID"].ToString(), dr["details"].ToString(), Convert.ToDateTime(dr["date"]).ToString("MMMM dd, yyyy HH:mm:ss"));
            }
            dr.Close();
            cn.Close();
        }

        private void Dt5_ValueChanged(object sender, EventArgs e)
        {
            LoadActivityHistory();
        }

        private void Dt6_ValueChanged(object sender, EventArgs e)
        {
            LoadActivityHistory();
        }
    }
}
