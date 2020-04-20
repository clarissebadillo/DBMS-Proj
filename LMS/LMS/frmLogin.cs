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
    public partial class frmLogin : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        string name = "";
        Form1 frm = new Form1();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      // WS_EX_COMPOSITED
                return handleParam;
            }
        }

        public frmLogin()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        public void Login()
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblUser WHERE username = @username AND password = @password AND status = 'Active'", cn);
            cm.Parameters.AddWithValue("@username", txtUsername.Text);
            cm.Parameters.AddWithValue("@password", txtPassword.Text);
            dr = cm.ExecuteReader();
            if (dr.Read())
            {

                name = dr["fullName"].ToString();

                frm.lblLibrarian.Text = name;
                frm.Show();
                frm.Dashboard();
                this.Hide();

                popupNotifier.ContentText = "Welcome back " + name + "! Ready to start working?";
                popupNotifier.Popup();

                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                txtUsername.Focus();
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.FocusedState.BorderColor = Color.FromArgb(232, 17, 35);
                guna2Transition1.ShowSync(pnlError);
                lblErrorMessage.Text = "Inavlid username or password!" + Environment.NewLine + "Please try again.";
            }
            dr.Close();
            cn.Close();
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(pnlError);
        }

        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "")
            {
                txtUsername.Focus();
                txtUsername.FocusedState.BorderColor = Color.FromArgb(232, 17, 35);
                guna2Transition1.ShowSync(pnlError);
                lblErrorMessage.Text = "Please enter the username.";
            }
            else if (txtPassword.Text == "")
            {
                txtPassword.Focus();
                txtPassword.FocusedState.BorderColor = Color.FromArgb(232, 17, 35);
                guna2Transition1.ShowSync(pnlError);
                lblErrorMessage.Text = "Please enter the password.";
            }
            else
            {
                Login();
                Logs();
            }
        }

        void Logs()
        {
            var details = name + " logged in";

            cn.Open();
            cm = new SqlCommand("INSERT INTO tblLogs VALUES (@details, GETDATE())", cn);
            cm.Parameters.AddWithValue("@details", details);
            cm.ExecuteNonQuery();
            cn.Close();
        }
    }
}
