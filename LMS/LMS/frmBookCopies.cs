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
    public partial class frmBookCopies : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmAddEditBook frm;
        //SqlDataReader dr;
        
        
        public frmBookCopies(frmAddEditBook frmAdd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frm = frmAdd;
            //LoadRecords();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.Show();
        }
    }
}
