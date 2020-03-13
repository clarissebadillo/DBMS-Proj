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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set current date and time
            timer1.Start();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
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
            frmBook frm = new frmBook();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
