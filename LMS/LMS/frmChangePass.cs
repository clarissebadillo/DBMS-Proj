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
    public partial class frmChangePass : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmUserAccount frm;

        public frmChangePass(frmUserAccount f)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frm = f;
        }

        private void FrmChangePass_Load(object sender, EventArgs e)
        {
            GetPassword();

            txtOldPass.UseSystemPasswordChar = true;
            txtNewPass.UseSystemPasswordChar = true;
            txtRetypePass.UseSystemPasswordChar = true;
        }

        public void GetPassword()
        {
            cn.Open();
            cm = new SqlCommand("SELECT password FROM tblUser WHERE userID = @userID", cn);
            cm.Parameters.AddWithValue("@userID", frm.lblID.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                lblPassword.Text = dr["password"].ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == "" || txtNewPass.Text == "" || txtRetypePass.Text == "")
            {
                MyMessageBox.ShowMessage("Please don't leave blank spaces!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (txtNewPass.Text != txtRetypePass.Text)
            {
                txtRetypePass.Focus();
                lblPass.Visible = true;
                txtRetypePass.FocusedState.BorderColor = Color.FromArgb(232, 17, 35);
            }
            else if (txtOldPass.Text != lblPassword.Text)
            {
                MyMessageBox.ShowMessage("Please enter the correct password!", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                txtOldPass.Focus();
                lblPass.Visible = false;
                txtOldPass.FocusedState.BorderColor = Color.FromArgb(232, 17, 35);
            }
            else
            {
                try
                {
                    if (MyMessageBox.ShowMessage("Are you sure you want to change your password?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblUser SET password = @password WHERE userID = @userID", cn);
                        cm.Parameters.AddWithValue("@userID", frm.lblID.Text);
                        cm.Parameters.AddWithValue("@password", txtNewPass.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        this.Close();
                        MyMessageBox.ShowMessage("Password changed successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (txtNewPass.UseSystemPasswordChar == true)
            {
                txtNewPass.UseSystemPasswordChar = false;
            }
        }

        private void BtnHidePass_Click(object sender, EventArgs e)
        {
            btnShowPass.Visible = true;
            btnHidePass.Visible = false;

            if (txtNewPass.UseSystemPasswordChar == false)
            {
                txtNewPass.UseSystemPasswordChar = true;
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

        private void BtnShowPass3_Click(object sender, EventArgs e)
        {
            btnShowPass3.Visible = false;
            btnHidePass3.Visible = true;

            if (txtOldPass.UseSystemPasswordChar == true)
            {
                txtOldPass.UseSystemPasswordChar = false;
            }
        }

        private void BtnHidePass3_Click(object sender, EventArgs e)
        {
            btnShowPass3.Visible = true;
            btnHidePass3.Visible = false;

            if (txtOldPass.UseSystemPasswordChar == false)
            {
                txtOldPass.UseSystemPasswordChar = true;
            }
        }
    }
}
