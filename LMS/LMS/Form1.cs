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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      // WS_EX_COMPOSITED
                return handleParam;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set current date and time
            timer1.Start();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();

            //form shadow
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        public void ShowIssueBook()
        {
            frmIssueBook frm = new frmIssueBook();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Set current time
            lblTime.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

        private void BtnPin_Click(object sender, EventArgs e)
        {
            btnPin.Visible = false;
            btnUnpin.Visible = true;
            pnlMenu.Visible = false;
            pnlMenu.Width = 50;
            pnlMenuAnimation.ShowSync(pnlMenu);
        }

        private void BtnUnpin_Click(object sender, EventArgs e)
        {
            btnUnpin.Visible = false;
            btnPin.Visible = true;
            pnlMenu.Visible = false;
            pnlMenu.Width = 190;
            pnlMenuAnimation.ShowSync(pnlMenu);
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            frmBookList frm = new frmBookList(this);
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            frmStudentList frm = new frmStudentList();
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
