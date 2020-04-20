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
using MyMessage;

namespace LMS
{
    public partial class frmOnHand : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmIssueBook frmissue;


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      // WS_EX_COMPOSITED
                return handleParam;
            }
        }

        public frmOnHand(frmIssueBook fissue)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmissue = fissue;
        }

        private void FrmOnHand_Load(object sender, EventArgs e)
        {
            BooksOnHand();
            BooksOverdue();
        }

        

        public void BooksOnHand()
        {
            flowLayoutPanel1.Controls.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT borrowID, studentID, bookTitle, dateBorrowed, dueDate, status  FROM tblBorrowedBook WHERE status = 'Not Returned' AND studentNum = @studentNum", cn);
            cm.Parameters.AddWithValue("@studentNum", frmissue.lblStudNo.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                ucBooksOnHand uc = new ucBooksOnHand(this);
                uc.Dock = DockStyle.Top;
                uc.lblBorrowID.Text = dr["borrowID"].ToString();
                uc.lblStudentID.Text = dr["studentID"].ToString();
                uc.lblBookName.Text = dr["bookTitle"].ToString();
                uc.lblDateBorrowed.Text = Convert.ToDateTime(dr["dateBorrowed"]).ToString("MM/dd/yyyy");
                uc.lblDueDate.Text = Convert.ToDateTime(dr["dueDate"]).ToString("MM/dd/yyyy");
                uc.lblStatus.Text = dr["status"].ToString();
                uc.dtDueDate.Value = Convert.ToDateTime(dr["dueDate"]);
                flowLayoutPanel1.Controls.Add(uc);
            }
            dr.Close();
            cn.Close();
        }

        public void BooksOverdue()
        {
            cn.Open();
            cm = new SqlCommand("SELECT borrowID, bookTitle, studentID, dateBorrowed, dueDate, status  FROM tblBorrowedBook WHERE status = 'Overdue' AND studentNum = @studentNum", cn);
            cm.Parameters.AddWithValue("@studentNum", frmissue.lblStudNo.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                ucBooksOnHand uc = new ucBooksOnHand(this);
                uc.Dock = DockStyle.Top;
                uc.lblBorrowID.Text = dr["borrowID"].ToString();
                uc.lblStudentID.Text = dr["studentID"].ToString();
                uc.lblBookName.Text = dr["bookTitle"].ToString();
                uc.lblDateBorrowed.Text = Convert.ToDateTime(dr["dateBorrowed"]).ToString("MM/dd/yyyy");
                uc.lblDueDate.Text = Convert.ToDateTime(dr["dueDate"]).ToString("MM/dd/yyyy");
                uc.lblStatus.Text = dr["status"].ToString();
                uc.dtDueDate.Value = Convert.ToDateTime(dr["dueDate"]);
                flowLayoutPanel1.Controls.Add(uc);
            }
            dr.Close();
            cn.Close();
        }

        public void RefreshAll()
        {
            frmissue.Clear();
            frmissue.LoadDetails();
            frmissue.BooksOnHand();
            frmissue.BooksOverdue();
            frmissue.LoadRecords();
            frmissue.CountFine();
            frmissue.Overdue();
            frmissue.LostBook();
            frmissue.DamagedBook();
        }
    }
}
