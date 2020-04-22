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
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();


        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams handleParam = base.CreateParams;
        //        handleParam.ExStyle |= 0x02000000;      // WS_EX_COMPOSITED
        //        return handleParam;
        //    }
        //}

        public Form1()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set current date and time
            timer1.Start();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();

            //form shadow
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            //Dashboard();
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Set current time
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void BtnPin_Click(object sender, EventArgs e)
        {
            btnPin.Visible = false;
            btnUnpin.Visible = true;
            pnlMenu.Visible = false;
            pnlMenu.Width = 70;
            pnlMenuAnimation.ShowSync(pnlMenu);
        }

        private void BtnUnpin_Click(object sender, EventArgs e)
        {
            btnUnpin.Visible = false;
            btnPin.Visible = true;
            pnlMenu.Visible = false;
            pnlMenu.Width = 230;
            pnlMenuAnimation.ShowSync(pnlMenu);
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            btnDashboard.Checked = true;
            btnStudent.Checked = false;
            btnBook.Checked = false;
            btnIssueBook.Checked = false;
            btnHistory.Checked = false;
            btnReports.Checked = false;
            btnUserAccount.Checked = false;
            btnSettings.Checked = false;

            frmDashboard frm = new frmDashboard();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            btnBook.Checked = true;
            btnStudent.Checked = false;
            btnDashboard.Checked = false;
            btnIssueBook.Checked = false;
            btnHistory.Checked = false;
            btnReports.Checked = false;
            btnUserAccount.Checked = false;
            btnSettings.Checked = false;

            frmBookList frm = new frmBookList(this);
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            btnStudent.Checked = true;
            btnBook.Checked = false;
            btnDashboard.Checked = false;
            btnIssueBook.Checked = false;
            btnHistory.Checked = false;
            btnReports.Checked = false;
            btnUserAccount.Checked = false;
            btnSettings.Checked = false;

            frmStudentList frm = new frmStudentList(this);
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        
        private void BtnIssueBook_Click(object sender, EventArgs e)
        {
            btnIssueBook.Checked = true;
            btnStudent.Checked = false;
            btnBook.Checked = false;
            btnDashboard.Checked = false;
            btnHistory.Checked = false;
            btnReports.Checked = false;
            btnUserAccount.Checked = false;
            btnSettings.Checked = false;

            frmIssueBook frm = new frmIssueBook(this);
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            btnHistory.Checked = true;
            btnIssueBook.Checked = false;
            btnStudent.Checked = false;
            btnBook.Checked = false;
            btnDashboard.Checked = false;
            btnReports.Checked = false;
            btnUserAccount.Checked = false;
            btnSettings.Checked = false;

            frmHistory frm = new frmHistory();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            btnReports.Checked = true;
            btnIssueBook.Checked = false;
            btnStudent.Checked = false;
            btnBook.Checked = false;
            btnDashboard.Checked = false;
            btnHistory.Checked = false;
            btnUserAccount.Checked = false;
            btnSettings.Checked = false;

            frmReport frm = new frmReport();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void BtnUserAccount_Click(object sender, EventArgs e)
        {
            btnUserAccount.Checked = true;
            btnReports.Checked = false;
            btnIssueBook.Checked = false;
            btnStudent.Checked = false;
            btnBook.Checked = false;
            btnDashboard.Checked = false;
            btnHistory.Checked = false;
            btnSettings.Checked = false;

            frmUserAccount frm = new frmUserAccount(this);
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            btnSettings.Checked = true;
            btnUserAccount.Checked = false;
            btnReports.Checked = false;
            btnIssueBook.Checked = false;
            btnStudent.Checked = false;
            btnBook.Checked = false;
            btnDashboard.Checked = false;
            btnHistory.Checked = false;

            frmSettings frm = new frmSettings(this);
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MyMessageBox.ShowMessage("Are you sure you want to logout?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                this.Hide();
                Logs();
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
            }
        }

        void Logs()
        {
            var details = lblLibrarian.Text + " logged out";

            cn.Open();
            cm = new SqlCommand("INSERT INTO tblLogs VALUES (@details, GETDATE())", cn);
            cm.Parameters.AddWithValue("@details", details);
            cm.ExecuteNonQuery();
            cn.Close();
        }


        public void Dashboard()
        {
            btnDashboard.Checked = true;

            var frm = new frmDashboard();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            MyMessageBox.ShowMessage("Closing the application will log you out from all of your session", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (MyMessageBox.ShowMessage("Are you sure you want to log out?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Logs();
                Application.Exit();
            }
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                Size = Screen.FromHandle(Handle).WorkingArea.Size;
                Location = Screen.FromHandle(Handle).WorkingArea.Location;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

    }
}
