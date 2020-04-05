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
    public partial class frmPayment : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmPayment()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            gunaDataGridView1.Columns[1].ReadOnly = true;
            gunaDataGridView1.Columns[2].ReadOnly = true;
            gunaDataGridView1.Columns[3].ReadOnly = false;
            gunaDataGridView1.Columns[4].ReadOnly = true;
            gunaDataGridView1.Columns[5].ReadOnly = true;

            gunaDataGridView1.Columns[1].DefaultCellStyle.Padding = new Padding(30, 0, 30, 0);
            gunaDataGridView1.Columns[5].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
        }
    }
}
