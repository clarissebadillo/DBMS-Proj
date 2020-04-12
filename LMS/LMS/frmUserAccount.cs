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
    public partial class frmUserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

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

        public frmUserAccount()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
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
                guna2DataGridView1.Rows.Add(i, dr["userID"].ToString(), dr["fullName"].ToString(), dr["username"].ToString(), dr["password"].ToString(), dr["email"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            frmNewAccount frm = new frmNewAccount(this);
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
    }
}
