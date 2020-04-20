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
using KimToo;
using MyMessage;


namespace LMS
{
    public partial class frmPayment : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmIssueBook frmissue;
        

        public frmPayment(frmIssueBook fissue)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmissue = fissue;
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

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            LoadPending();
            GetTotalAmount();

            dtPaymentDate.Value = DateTime.Now;
            dtDueDate.Value = dtPaymentDate.Value.AddMonths(1);

            gunaDataGridView1.Columns[1].ReadOnly = true;
            gunaDataGridView1.Columns[2].ReadOnly = true;
            gunaDataGridView1.Columns[3].ReadOnly = false;
            gunaDataGridView1.Columns[4].ReadOnly = false;
            gunaDataGridView1.Columns[5].ReadOnly = true;

            gunaDataGridView1.Columns[1].DefaultCellStyle.Padding = new Padding(35, 0, 0, 0);
            gunaDataGridView1.Columns[1].HeaderCell.Style.Padding = new Padding(30, 0, 0, 0);
            gunaDataGridView1.Columns[5].DefaultCellStyle.Padding = new Padding(20, 0, 40, 0);
            gunaDataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }


        //INVOICE REPORT
        private void BtnPrintInvoice_Click(object sender, EventArgs e)
        {
            printReport.Clear();
            printReport.AddImage(Properties.Resources.school_logo, "width = 120, style = 'float:left'");
            printReport.AddString("<h3 style = 'margin: 20px 0 0 0'>  &nbsp &nbspSTATE UNIVERSITY LIBRARY</h3>");
            printReport.AddString("<h5 style = 'margin:5px 0'> &nbsp &nbsp Sample Address, Sample Address, Sample Address");
            printReport.AddString("<h5 style = 'margin:8px 0'> &nbsp &nbsp +63 900000000");
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddString("<h3 style = 'float:right', style='font-family: Segoe UI'>INVOICE</h3>");
            printReport.AddString("<h5 style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Student Name: &nbsp<b>" + lblName.Text + "</b></h5>");
            printReport.AddString("<h5 style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Student Number: &nbsp<b>" + lblStudentNum.Text + "</b></h5>");
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddHorizontalRule();
            printReport.AddLineBreak();
            printReport.AddString("<p style = 'font-size: 12px', style='font-family: Segoe UI', style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Status &nbsp&nbsp&nbsp <b>PENDING</b></p>");
            printReport.AddString("<p style = 'font-size: 12px', style='font-family: Segoe UI', style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Date &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp" + Convert.ToDateTime(dtPaymentDate.Value).ToString("dd MMMM yyyy") + "</p>");
            printReport.AddString("<p style = 'font-size: 12px', style='font-family: Segoe UI', style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Term &nbsp&nbsp&nbsp&nbsp One month</p>");
            printReport.AddString("<p style = 'font-size: 12px', style='font-family: Segoe UI', style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Due &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp" + Convert.ToDateTime(dtDueDate.Value).ToString("dd MMMM yyyy") + "</p>");
            printReport.AddLineBreak();
            printReport.AddHorizontalRule();
            printReport.AddLineBreak();
            printReport.AddString("<p style = 'font-weight: normal', style='font-family: Segoe UI'>The student <b>" + lblName.Text + "</b>, student number: <b>" + lblStudentNum.Text + "</b> have pending charges of:</p>");
            printReport.AddDatagridView(gunaDataGridView1);
            printReport.AddString("<h6 style = 'margin: 8px 0 0 0', style = 'float:right', style='font-family: Segoe UI', style = 'fonte-weight: normal'>AMOUNT DUE &nbsp&nbsp&nbsp<span style = 'font-size: 16px'>" + lblTotalAmount.Text + "</span></h6>");
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddString("<p style = 'font-size: 11px', style='font-family: Segoe UI', style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Note: Please pay the exact amount indicated above on or before the payment due date. <br> Payments less than the amount will not be processed.</p>");
            printReport.AddLineBreak();
            printReport.AddString("<p style = 'font-size: 11px', style='font-family: Segoe UI', style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Generated by: " + lblLibrarianName.Text + "</p>");
            printReport.ShowPrintPreviewDialog();
        }


        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MyMessageBox.ShowMessage("Proceed processing the payment made by " + lblName.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblPayment VALUES (@studentID, @totalPayment, @paymentDate, @summaryDesc, @librarian)", cn);
                    cm.Parameters.AddWithValue("@studentID", lblStudentID.Text);
                    cm.Parameters.AddWithValue("@totalPayment", lblAmount.Text);
                    cm.Parameters.AddWithValue("@paymentDate", dtPaymentDate.Value);
                    cm.Parameters.AddWithValue("@summaryDesc", txtSummaryRprt.Text);
                    cm.Parameters.AddWithValue("@librarian", lblLibrarianName.Text);
                    cm.ExecuteNonQuery();
                    lblTotalAmount.Text = "₱0.00";
                    cn.Close();
                    Logs();
                    UpdatePaymentStat();
                    LoadPending();
                    ClearPayment();
                    RefreshAll();

                    popupNotifier.ContentText = "Payment has been successfully processed!";
                    popupNotifier.Popup();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdatePaymentStat()
        {
            cn.Open();
            cm = new SqlCommand("UPDATE tblBorrowedBook SET paymentStatus = 'Cleared' WHERE paymentStatus = 'Pending' AND studentNum = @studentNum", cn);
            cm.Parameters.AddWithValue("@studentNum", lblStudentNum.Text);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        public void LoadPending()
        {
            int i = 0;
            gunaDataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT borrowID, bookTitle, status, totalFine FROM tblBorrowedBook WHERE status IN('Lost', 'Damaged', 'Returned') AND paymentStatus = 'Pending' AND studentNum = @studentNum", cn);
            cm.Parameters.AddWithValue("@studentNum", frmissue.lblStudNo.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                gunaDataGridView1.Rows.Add(i, dr["borrowID"].ToString(), dr["bookTitle"].ToString(), "", dr["status"].ToString(), dr["totalFine"].ToString());
            }
            dr.Close();
            cn.Close();

            cn.Open();
            cm = new SqlCommand("SELECT (firstName + ' ' + lastName) AS Name, studentNum, studentID FROM tblStudent WHERE studentNum = @studentNum", cn);
            cm.Parameters.AddWithValue("@studentNum", frmissue.lblStudNo.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                lblStudentID.Text = dr["studentID"].ToString();
                lblName.Text = dr["Name"].ToString();
                lblStudentNum.Text = dr["studentNum"].ToString();
            }
            dr.Close();
            cn.Close();
        }

        public void GetTotalAmount()
        {
            Double sum = 0;
            for (int i = 0; i < gunaDataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(gunaDataGridView1.Rows[i].Cells[5].Value);
            }

            lblAmount.Text = sum.ToString();
            lblTotalAmount.Text = "₱" + Convert.ToDouble(lblAmount.Text).ToString("N");
        }


        //RECEIPT
        private void BtnPrintReceipt_Click(object sender, EventArgs e)
        {
            gunaDataGridView1.Columns.Add("PaymentStatus", "PAYMENT");
            for (int i = 0; i < gunaDataGridView1.Rows.Count; i++)
            {
                gunaDataGridView1.Rows[i].Cells[6].Value = "Cleared";

            }

            printReport.Clear();
            printReport.AddImage(Properties.Resources.school_logo, "width = 120, style = 'float:left'");
            printReport.AddString("<h3 style = 'margin: 20px 0 0 0'>  &nbsp &nbspSTATE UNIVERSITY LIBRARY</h3>");
            printReport.AddString("<h5 style = 'margin:5px 0'> &nbsp &nbsp Sample Address, Sample Address, Sample Address");
            printReport.AddString("<h5 style = 'margin:8px 0'> &nbsp &nbsp +63 900000000");
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddString("<h3 style = 'float:right', style='font-family: Segoe UI'>PAYMENT RECEIPT</h3>");
            printReport.AddString("<h5 style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Student Name: &nbsp<b>" + lblName.Text + "</b></h5>");
            printReport.AddString("<h5 style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Student Number: &nbsp<b>" + lblStudentNum.Text + "</b></h5>");
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddHorizontalRule();
            printReport.AddString("<p style = 'font-weight: normal', style='font-family: Segoe UI'>The student <b>" + lblName.Text + "</b>, student number: <b>" + lblStudentNum.Text + "</b> has no record of pending charges.</p>");
            printReport.AddDatagridView(gunaDataGridView1);
            printReport.AddLineBreak();
            printReport.AddString("<p style = 'font-size: 12px', style='font-family: Segoe UI', style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Status &nbsp&nbsp&nbsp <b>CLEARED</b></p>");
            printReport.AddString("<p style = 'font-size: 12px', style='font-family: Segoe UI', style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Date &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp" + Convert.ToDateTime(dtPaymentDate.Value).ToString("dd MMMM yyyy") + "</p>");
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddString("<p style = 'font-size: 12px', style='font-family: Segoe UI', style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Payment received by: " + lblLibrarianName.Text +"</p>");
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddString("<pre style = 'float: right', style = 'margin: 5px 0 0 0'>___________________________________ <br>        School Administrator</pre>");
            printReport.AddString("<pre>___________________________________ <br>            Librarian</pre>");
            printReport.ShowPrintPreviewDialog();
        }

        public void ClearPayment()
        {
            cn.Open();
            cm = new SqlCommand("UPDATE tblBorrowedBook SET totalFine = 0 WHERE studentNum = @studentNum", cn);
            cm.Parameters.AddWithValue("@studentNum", frmissue.lblStudNo.Text);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        public void RefreshAll()
        {
            frmissue.Clear();
            frmissue.LoadDetails();
            frmissue.CountFine();
            frmissue.CountClearedPayments();
        }

        void Logs()
        {
            var details = lblLibrarianName.Text + " received fine/penalty payment from " + lblName.Text + "";

            cn.Open();
            cm = new SqlCommand("INSERT INTO tblLogs VALUES (@details, GETDATE())", cn);
            cm.Parameters.AddWithValue("@details", details);
            cm.ExecuteNonQuery();
            cn.Close();
        }
    }
}
