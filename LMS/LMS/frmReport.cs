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
        }
    }
}
