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

namespace LMS
{
    public partial class frmPayment : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        //SqlDataReader dr;

        public frmPayment()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            dtPaymentDate.Value = DateTime.Now;
            dtDueDate.Value = dtPaymentDate.Value.AddMonths(1);

            gunaDataGridView1.Columns[1].ReadOnly = true;
            gunaDataGridView1.Columns[2].ReadOnly = true;
            gunaDataGridView1.Columns[3].ReadOnly = false;
            gunaDataGridView1.Columns[4].ReadOnly = false;
            gunaDataGridView1.Columns[5].ReadOnly = true;

            gunaDataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gunaDataGridView1.Columns[5].DefaultCellStyle.Padding = new Padding(20, 0, 40, 0);
            gunaDataGridView1.Columns[1].DefaultCellStyle.Padding = new Padding(35, 0, 0, 0);
            gunaDataGridView1.Columns[1].HeaderCell.Style.Padding = new Padding(30, 0, 0, 0);
        }

        private void BtnPrintInvoice_Click(object sender, EventArgs e)
        {
            InvoiceReport.Clear();
            InvoiceReport.AddImage(Properties.Resources.school_logo, "width = 120, style = 'float:left'");
            InvoiceReport.AddString("<h3 style = 'margin: 20px 0 0 0'>  &nbsp &nbspSTATE UNIVERSITY LIBRARY</h3>");
            InvoiceReport.AddString("<h5 style = 'margin:5px 0'> &nbsp &nbsp Sample Address, Sample Address, Sample Address");
            InvoiceReport.AddString("<h5 style = 'margin:8px 0'> &nbsp &nbsp +63 900000000");
            InvoiceReport.AddLineBreak();
            InvoiceReport.AddLineBreak();
            InvoiceReport.AddLineBreak();
            InvoiceReport.AddLineBreak();
            InvoiceReport.AddLineBreak();
            InvoiceReport.AddLineBreak();
            InvoiceReport.AddString("<h3 style = 'float:right', style='font-family: Segoe UI'>INVOICE</h3>");
            InvoiceReport.AddString("<h5 style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Student Name: &nbsp<b>" + lblName.Text + "</b></h5>");
            InvoiceReport.AddString("<h5 style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Student Number: &nbsp<b>" + lblName.Text + "</b></h5>");
            InvoiceReport.AddLineBreak();
            InvoiceReport.AddLineBreak();
            InvoiceReport.AddHorizontalRule();
            InvoiceReport.AddLineBreak();
            InvoiceReport.AddString("<p style = 'font-size: 12px', style='font-family: Segoe UI', style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Status &nbsp&nbsp&nbsp <b>PENDING</b></p>");
            InvoiceReport.AddString("<p style = 'font-size: 12px', style='font-family: Segoe UI', style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Date &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp" + Convert.ToDateTime(dtPaymentDate.Value).ToString("dd MMMM yyyy") + "</p>");
            InvoiceReport.AddString("<p style = 'font-size: 12px', style='font-family: Segoe UI', style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Term &nbsp&nbsp&nbsp&nbsp One month</p>");
            InvoiceReport.AddString("<p style = 'font-size: 12px', style='font-family: Segoe UI', style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Due &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp" + Convert.ToDateTime(dtDueDate.Value).ToString("dd MMMM yyyy") + "</p>");
            InvoiceReport.AddLineBreak();
            InvoiceReport.AddHorizontalRule();
            InvoiceReport.AddLineBreak();
            InvoiceReport.AddString("<p style = 'font-weight: normal', style='font-family: Segoe UI'>The student <b>" + lblName.Text + "</b>, Student number: <b>" + lblName.Text + "</b> have pending charges of:</p>");
            InvoiceReport.AddDatagridView(gunaDataGridView1);
            InvoiceReport.AddString("<h3 style = 'float:right', style='font-family: Segoe UI'>TOTAL</h3>");
            InvoiceReport.AddLineBreak();
            InvoiceReport.AddLineBreak();
            InvoiceReport.AddLineBreak();
            InvoiceReport.AddLineBreak();
            InvoiceReport.AddString("<p style = 'font-size: 11px', style='font-family: Segoe UI', style = 'font-weight: normal', style = 'margin: 5px 0 0 0'>Note: Please pay the exact amount indicated above on or before the payment due date. <br> Payments less than the amount will not be processed.</p>");
            InvoiceReport.ShowPrintPreviewDialog();
        }
    }
}
