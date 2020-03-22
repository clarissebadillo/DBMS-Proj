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
using System.IO;

namespace LMS
{
    public partial class frmIssueBook : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmIssueBook()
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

        private void FrmIssueBook_Load(object sender, EventArgs e)
        {
            AutoCompleteStudentNo();
            LoadBooks();
        }

        public void AutoCompleteStudentNo()
        {
            cn.Open();
            cm = new SqlCommand("SELECT stNumber FROM tblStudent", cn);
            dr = cm.ExecuteReader();
            AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                Collection.Add(dr.GetString(0));
            }
            txtSearchStud.AutoCompleteCustomSource = Collection;
            dr.Close();
            cn.Close();
        }

        public void LoadBooks()
        {
            cboBooks.Items.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT bkTitle FROM tblBook", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cboBooks.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtSearchStud_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblStudent WHERE stNumber ='" + txtSearchStud.Text + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                lblName.Text = dr["stFname"].ToString() + " " + dr["stLname"].ToString();
                lblStudNo.Text = dr["stNumber"].ToString();
                lblCourse.Text = dr["stCourse"].ToString();
                lblYear.Text = dr["stYear"].ToString();
                byte[] imgbytes = (byte[])dr["stImage"];
                MemoryStream mstream = new MemoryStream(imgbytes);
                studImage.Image = Image.FromStream(mstream);
            }
            dr.Close();
            cn.Close();
        }

        private void CboBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblBook WHERE bkTitle ='" + cboBooks.Text + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                lblTitle.Text = dr["bkTitle"].ToString();
                lblISBN.Text = dr["bkISBN"].ToString();
                lblSubject.Text = dr["bkSubject"].ToString();
                lblAuthor.Text = dr["bkAuthor"].ToString();
            }
            dr.Close();
            cn.Close();
        }
    }
}
