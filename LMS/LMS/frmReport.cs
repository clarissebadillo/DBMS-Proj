using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class frmReport : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      // WS_EX_COMPOSITED
                return handleParam;
            }
        }

        public frmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            //ACTIVITY REPORTS
            Reports.Activity activityRprt = new Reports.Activity();
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = activityRprt;
            crystalReportViewer1.Refresh();

            //STUDENT REPORTS
            Reports.Student studentRprt = new Reports.Student();
            crystalReportViewer2.ReportSource = null;
            crystalReportViewer2.ReportSource = studentRprt;
            crystalReportViewer2.Refresh();
            crystalReportViewer2.Zoom(85);

            //BOOK SUMMARY REPORTS
            Reports.BookSummary bookRprt = new Reports.BookSummary();
            crystalReportViewer3.ReportSource = null;
            crystalReportViewer3.ReportSource = bookRprt;
            crystalReportViewer3.Refresh();
            crystalReportViewer3.Zoom(85);

            //BILLING REPORTS
            Reports.Billing billingRprt = new Reports.Billing();
            crystalReportViewer4.ReportSource = null;
            crystalReportViewer4.ReportSource = billingRprt;
            crystalReportViewer4.Refresh();
        }
    }
}
