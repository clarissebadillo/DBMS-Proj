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
    public partial class frmAcquireBooks : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmBookList frm;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      // WS_EX_COMPOSITED
                return handleParam;
            }
        }

        public frmAcquireBooks(frmBookList flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frm = flist;
        }

        private void FrmAcquireBooks_Load(object sender, EventArgs e)
        {
            //
        }
        
        void GetCopies()
        {
            
        }

        private void BtnAddCopies_Click(object sender, EventArgs e)
        {
            try
            {
                if (MyMessageBox.ShowMessage("Are you sure you want to add new copies?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblBook SET allCopies = allcopies + @addCopy, availableCopies = availableCopies + @addAvailCopy WHERE bookTitle = @bookTitle", cn);
                    cm.Parameters.AddWithValue("@addCopy", txtCopies.Text);
                    cm.Parameters.AddWithValue("@addAvailCopy", txtCopies.Text);
                    cm.Parameters.AddWithValue("@bookTitle", lblBookTitle.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    Logs();

                    frm.gunaDataGridView1.Rows.Clear();
                    frm.LoadRecords();
                    this.Close();

                    popupNotifier.ContentText = "Copies successfully added!";
                    popupNotifier.Popup();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Logs()
        {
            var details = lblLibrarian.Text + " added " + txtCopies.Text + " new copies of " + lblBookTitle.Text + "";

            cn.Open();
            cm = new SqlCommand("INSERT INTO tblLogs VALUES (@details, GETDATE())", cn);
            cm.Parameters.AddWithValue("@details", details);
            cm.ExecuteNonQuery();
            cn.Close();
        }
    }
}
