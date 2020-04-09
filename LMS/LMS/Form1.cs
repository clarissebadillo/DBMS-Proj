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
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        public Form1()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private const int cs = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cs;
                return cp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set current date and time
            timer1.Start();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();

            //form shadow
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
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

            frmBookList frm = new frmBookList();
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

            frmStudentList frm = new frmStudentList();
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

            frmIssueBook frm = new frmIssueBook();
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

            frmReport frm = new frmReport();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
