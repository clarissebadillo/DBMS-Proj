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
    public partial class frmNewAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmUserAccount frm;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      // WS_EX_COMPOSITED
                return handleParam;
            }
        }

        public frmNewAccount(frmUserAccount f)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frm = f;
        }

        private void FrmNewAccount_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtRetypePass.UseSystemPasswordChar = true;
        }

        public void Clear()
        {
            txtEmail.Clear();
            txtFullName.Clear();
            txtPassword.Clear();
            txtRetypePass.Clear();
            txtUsername.Clear();
            lblPass.Visible = false;
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtRetypePass.Text == "" || txtUsername.Text == "")
            {
                MyMessageBox.ShowMessage("Please don't leave blank spaces!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text != txtRetypePass.Text)
            {
                txtRetypePass.Focus();
                lblPass.Visible = true;
                txtRetypePass.FocusedState.BorderColor = Color.FromArgb(232, 17, 35);
            }
            else
            {
                try
                {
                    if (MyMessageBox.ShowMessage("Are you sure you want to add " + txtFullName.Text + " as a new librarian?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tblUser VALUES (@username, @password, @fullName, @email, 'Active')", cn);
                        cm.Parameters.AddWithValue("@username", txtUsername.Text);
                        cm.Parameters.AddWithValue("@password", txtPassword.Text);
                        cm.Parameters.AddWithValue("@fullName", txtFullName.Text);
                        cm.Parameters.AddWithValue("@email", txtEmail.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        Logs();

                        Clear();
                        MyMessageBox.ShowMessage("Account created successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm.LoadRecords();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnShowPass_Click(object sender, EventArgs e)
        {
            btnShowPass.Visible = false;
            btnHidePass.Visible = true;

            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void BtnHidePass_Click(object sender, EventArgs e)
        {
            btnShowPass.Visible = true;
            btnHidePass.Visible = false;

            if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void BtnShowPass2_Click(object sender, EventArgs e)
        {
            btnShowPass2.Visible = false;
            btnHidePass2.Visible = true;

            if (txtRetypePass.UseSystemPasswordChar == true)
            {
                txtRetypePass.UseSystemPasswordChar = false;
            }
        }

        private void BtnHidePass2_Click(object sender, EventArgs e)
        {
            btnShowPass2.Visible = true;
            btnHidePass2.Visible = false;

            if (txtRetypePass.UseSystemPasswordChar == false)
            {
                txtRetypePass.UseSystemPasswordChar = true;
            }
        }

        void Logs()
        {
            var details = lblLibrarian.Text + " added " + txtUsername.Text + " to the user account list";

            cn.Open();
            cm = new SqlCommand("INSERT INTO tblLogs VALUES (@details, GETDATE())", cn);
            cm.Parameters.AddWithValue("@details", details);
            cm.ExecuteNonQuery();
            cn.Close();
        }

    }
}
