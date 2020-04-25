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
using System.IO;
using ZXing.Common;
using ZXing;
using ZXing.QrCode;

namespace LMS
{
    public partial class frmStudentList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        Form1 frm1;

        string admin;

        QrCodeEncodingOptions options = new QrCodeEncodingOptions();

        public frmStudentList(Form1 f1)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frm1 = f1;
            admin = frm1.lblLibrarian.Text;

            LoadRecords();
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

        private void FrmStudentList_Load(object sender, EventArgs e)
        {
            LoadPrograms();
            cboCourse.SelectedItem = "All Course";

            options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 100,
                Height = 100,
            };
            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;
        }

        void LoadPrograms()
        {
            cboCourse.Items.Clear();
            cboCourse.Items.Add("All Course");
            cn.Open();
            cm = new SqlCommand("SELECT description FROM tblPrograms", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cboCourse.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadRecords()
        {
            int i = 0;
            gunaDataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT s.*, (SELECT COUNT(*) FROM tblBorrowedBook b  WHERE b.status = 'Not Returned' AND b.studentID = s.StudentId) as BookCount FROM tblStudent s WHERE accountStat = 'Active' AND lastName LIKE '" + txtSearch.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                gunaDataGridView1.Rows.Add(i, dr["studentID"].ToString(), dr["studentNum"].ToString(), dr["lastName"].ToString(), dr["firstName"].ToString(), dr["course"].ToString(), dr["year"].ToString(), dr["gender"].ToString(), dr["contact"].ToString(), dr["email"].ToString(), dr["address"].ToString(), dr["image"], dr["BookCount"].ToString());//, dr["stCopies"].ToString(), dr["stLost"].ToString());//, dr["stCopies"].ToString());//, dr["stBookLost"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        //Filter using combobox
        public void LoadCourse()
        {
            int i = 0;
            if (cboCourse.Text == "All Course")
            {
                gunaDataGridView1.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT s.*, (SELECT COUNT(*) FROM tblBorrowedBook b  WHERE b.status = 'Not Returned' AND b.studentID = s.StudentId) as BookCount FROM tblStudent s", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    gunaDataGridView1.Rows.Add(i, dr["studentID"].ToString(), dr["studentNum"].ToString(), dr["lastName"].ToString(), dr["firstName"].ToString(), dr["course"].ToString(), dr["year"].ToString(), dr["gender"].ToString(), dr["contact"].ToString(), dr["email"].ToString(), dr["address"].ToString(), dr["image"], dr["BookCount"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            else
            {
                gunaDataGridView1.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT s.*, (SELECT COUNT(*) FROM tblBorrowedBook b  WHERE b.status = 'Not Returned' AND b.studentID = s.StudentId) as BookCount FROM tblStudent s WHERE course LIKE @cboCourse", cn);
                cm.Parameters.AddWithValue("@cboCourse", cboCourse.Text);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    gunaDataGridView1.Rows.Add(i, dr["studentID"].ToString(), dr["studentNum"].ToString(), dr["lastName"].ToString(), dr["firstName"].ToString(), dr["course"].ToString(), dr["year"].ToString(), dr["gender"].ToString(), dr["contact"].ToString(), dr["email"].ToString(), dr["address"].ToString(), dr["image"], dr["BookCount"].ToString());
                }
                dr.Close();
                cn.Close();
            }
        }


        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void GunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Load to labels
            lblName.Text = gunaDataGridView1[4, e.RowIndex].Value.ToString() + " " + gunaDataGridView1[3, e.RowIndex].Value.ToString();
            lblStudNo.Text = gunaDataGridView1[2, e.RowIndex].Value.ToString();
            lblCourse.Text = gunaDataGridView1[5, e.RowIndex].Value.ToString();
            lblYear.Text = gunaDataGridView1[6, e.RowIndex].Value.ToString();
            lblGender.Text = gunaDataGridView1[7, e.RowIndex].Value.ToString();
            lblContact.Text = gunaDataGridView1[8, e.RowIndex].Value.ToString();
            lblEmail.Text = gunaDataGridView1[9, e.RowIndex].Value.ToString();
            lblAddress.Text = gunaDataGridView1[10, e.RowIndex].Value.ToString();
            byte[] imgbytes = (byte[])gunaDataGridView1[11, e.RowIndex].Value;
            MemoryStream mstream = new MemoryStream(imgbytes);
            stImage.Image = Image.FromStream(mstream);

            string colName = gunaDataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmAddEditStudent frm = new frmAddEditStudent(this);
                frm.lblLibrarian.Text = admin;
                frm.btnSave.Enabled = false;
                frm.lblTitle.Text = "Edit Student Details";
                frm.lblID.Text = gunaDataGridView1[1, e.RowIndex].Value.ToString();
                frm.txtStudNo.Text = gunaDataGridView1[2, e.RowIndex].Value.ToString();
                frm.txtLname.Text = gunaDataGridView1[3, e.RowIndex].Value.ToString();
                frm.txtFname.Text = gunaDataGridView1[4, e.RowIndex].Value.ToString();
                frm.cboCourse.Text = gunaDataGridView1[5, e.RowIndex].Value.ToString();
                frm.cboYear.Text = gunaDataGridView1[6, e.RowIndex].Value.ToString();
                frm.txtContact.Text = gunaDataGridView1[8, e.RowIndex].Value.ToString();
                frm.txtEmail.Text = gunaDataGridView1[9, e.RowIndex].Value.ToString();
                frm.txtAddress.Text = gunaDataGridView1[10, e.RowIndex].Value.ToString();
                //Load Image
                byte[] bytes = (byte[])gunaDataGridView1[11, e.RowIndex].Value;
                MemoryStream ms = new MemoryStream(bytes);
                frm.studImage.Image = Image.FromStream(ms);
                //Retrieve gender value to radio button
                if (gunaDataGridView1[7, e.RowIndex].Value.ToString() == "Male")
                {
                    frm.rbMale.Checked = true;
                }
                else
                {
                    frm.rbFemale.Checked = true;
                }
                //Show
                frm.Show();
            }
            else if (colName == "Delete")
            {
                if (MyMessageBox.ShowMessage("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblStudent SET accountStat = 'Deactivated' WHERE studentID like '" + gunaDataGridView1[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    RemoveStudentLogs();
                    popupNotifier.ContentText = "Record has been successfully removed!";
                    popupNotifier.Popup();
                    LoadRecords();
                }
            }
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddEditStudent frm = new frmAddEditStudent(this);
            frm.lblLibrarian.Text = admin;
            frm.btnUpdate.Enabled = false;
            frm.Show();
        }

        private void BtnGenerateID_Click(object sender, EventArgs e)
        {
            //frmGenerateQR frm = new frmGenerateQR();
            if (lblStudNo.Text == "Student Number")
            {
                MyMessageBox.ShowMessage("No student selected!", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                frmLibraryCard frm = new frmLibraryCard();
                frm.lblLibrarian.Text = admin;
                cn.Open();
                cm = new SqlCommand("SELECT (firstName + ' ' + LastName) AS Name, studentNum, contact, course, image FROM tblStudent WHERE studentNum = @studentNum", cn);
                //cm = new SqlCommand("SELECT (firstName + ' ' + LastName) AS Name, studentNum FROM tblStudent WHERE studentNum = @studentNum", cn);
                cm.Parameters.AddWithValue("@studentNum", lblStudNo.Text);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    frm.lblStudentName.Text = dr["Name"].ToString();
                    frm.lblCourse.Text = dr["course"].ToString();
                    frm.lblStudentNum.Text = dr["studentNum"].ToString();
                    frm.lblContactNo.Text = dr["contact"].ToString();
                    //Load Image
                    byte[] imgbytes = (byte[])dr["image"];
                    MemoryStream mstream = new MemoryStream(imgbytes);
                    frm.studentImage.Image = Image.FromStream(mstream);

                    //
                    if (String.IsNullOrWhiteSpace(lblStudNo.Text) || String.IsNullOrEmpty(lblStudNo.Text))
                    {
                        frm.QR.Image = null;
                        MessageBox.Show("Text not found", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var qr = new ZXing.BarcodeWriter();
                        qr.Options = options;
                        qr.Format = ZXing.BarcodeFormat.QR_CODE;
                        var result = new Bitmap(qr.Write(lblStudNo.Text.Trim()));
                        frm.QR.Image = result;
                        //lblStudNo.Text = "";
                    }
                    }
                    dr.Close();
                    cn.Close();
                    frm.Show();
            }
        }

        private void CboCourse_TextChanged(object sender, EventArgs e)
        {
            LoadCourse();
        }

        private void TxtSearch_TextChanged_1(object sender, EventArgs e)
        {
            LoadRecords();
        }

        void RemoveStudentLogs()
        {
            var details = frm1.lblLibrarian.Text + " removed " + lblName.Text + " from the student list";

            cn.Open();
            cm = new SqlCommand("INSERT INTO tblLogs VALUES (@details, GETDATE())", cn);
            cm.Parameters.AddWithValue("@details", details);
            cm.ExecuteNonQuery();
            cn.Close();
        }
    }
}
