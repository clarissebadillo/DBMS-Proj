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
    public partial class frmUserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        Form1 frm1;

        int rowIndex;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      // WS_EX_COMPOSITED
                return handleParam;
            }
        }

        public frmUserAccount(Form1 f1)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frm1 = f1;
        }

        private void FrmUserAccount_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }

        public void LoadRecords()
        {
            int i = 0;
            guna2DataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblUser", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                guna2DataGridView1.Rows.Add(i, dr["userID"].ToString(), dr["fullName"].ToString(), dr["username"].ToString(), dr["password"].ToString(), dr["email"].ToString(), dr["status"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            frmNewAccount frm = new frmNewAccount(this);
            frm.lblLibrarian.Text = frm1.lblLibrarian.Text;
            frm.Show();
        }

        private void Guna2DataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                guna2DataGridView1.ClearSelection();
                guna2DataGridView1.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                gunaContextMenuStrip1.Show(guna2DataGridView1.Location);
                gunaContextMenuStrip1.Show(Cursor.Position);
                lblID.Text = guna2DataGridView1[1, e.RowIndex].Value.ToString();
            }

            if (guna2DataGridView1[6, e.RowIndex].Value.ToString() == "Deactivated")
            {
                gunaContextMenuStrip1.Items[1].Text = "Activate Account";
                gunaContextMenuStrip1.Items[1].Image = Properties.Resources.checkmark_30px;
            }
            else
            {
                gunaContextMenuStrip1.Items[1].Text = "Deactivate Account";
                gunaContextMenuStrip1.Items[1].Image = Properties.Resources.delete_30px;
            }
        }

        private void Guna2DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.ColumnIndex == 4)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
        }

        private void Guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                e.Value = new String('\u25CF', e.Value.ToString().Length);
            }
        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePass frm = new frmChangePass(this);
            frm.Show();
        }

        private void BtnDeactivateAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (gunaContextMenuStrip1.Items[1].Text == "Deactivate Account")
                {
                    if (MyMessageBox.ShowMessage("Are you sure you want to deactivate this account?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblUser SET status = 'Deactivated' WHERE userID = @userID", cn);
                        cm.Parameters.AddWithValue("@userID", lblID.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        MyMessageBox.ShowMessage("Account deactivated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRecords();
                    }
                }
                else
                {
                    if (MyMessageBox.ShowMessage("Are you sure you want to activate this account?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblUser SET status = 'Active' WHERE userID = @userID", cn);
                        cm.Parameters.AddWithValue("@userID", lblID.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        MyMessageBox.ShowMessage("Account activated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRecords();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
