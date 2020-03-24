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
    public partial class frmAddEditStudent : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmStudentList frmlist;

        string gender = "";

        public frmAddEditStudent(frmStudentList flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmlist = flist;
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

        public void Clear()
        {
            txtAddress.Text = "";
            txtStudNo.Text = "";
            txtLname.Text = "";
            txtFname.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            cboCourse.SelectedIndex = -1;
            cboYear.SelectedIndex = -1;
            studImage.Image = Properties.Resources.user;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Save image to database
            MemoryStream ms = new MemoryStream();
            studImage.Image.Save(ms, studImage.Image.RawFormat);
            byte[] img = ms.GetBuffer();
            ms.Close();
            
            //Save radio button selected value
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            if (rbFemale.Checked)
            {
                gender = "Female";
            }

            if (txtStudNo.Text == "" || txtFname.Text == "" || txtLname.Text == "")
            {
                if (txtStudNo.Text == "")
                {
                    txtStudNo.Focus();
                    MessageBox.Show("Please enter the student number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtFname.Text == "")
                {
                    txtFname.Focus();
                    MessageBox.Show("Please enter the student's first name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtLname.Text == "")
                {
                    txtLname.Focus();
                    MessageBox.Show("Please enter the student's last name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to save this record?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //open connection to the database
                        cn.Open();
                        //command to be executed on the database
                        cm = new SqlCommand("INSERT INTO tblStudent VALUES (@stNumber, @stLname, @stFname, @stCourse, @stYear, @stGender, @stContact, @stEmail, @stAddress, @stImage, @stCopies, @stLost)", cn);
                        //set parameters value
                        cm.Parameters.AddWithValue("@stNumber", txtStudNo.Text);
                        cm.Parameters.AddWithValue("@stLname", txtLname.Text);
                        cm.Parameters.AddWithValue("@stFname", txtFname.Text);
                        cm.Parameters.AddWithValue("@stCourse", cboCourse.Text);
                        cm.Parameters.AddWithValue("@stYear", cboYear.Text);
                        cm.Parameters.AddWithValue("@stGender", gender);
                        cm.Parameters.AddWithValue("@stContact", txtContact.Text);
                        cm.Parameters.AddWithValue("@stEmail", txtEmail.Text);
                        cm.Parameters.AddWithValue("@stAddress", txtAddress.Text);
                        cm.Parameters.AddWithValue("@stImage", img);
                        cm.Parameters.AddWithValue("@stCopies", lblValues.Text);
                        cm.Parameters.AddWithValue("@stLost", lblValues.Text);
                        //ask db to execute query
                        cm.ExecuteNonQuery();
                        //close connection
                        cn.Close();
                        MessageBox.Show("Record has been sucessfully saved!");
                        Clear();
                        frmlist.LoadRecords();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "C:/Download/";
            dlg.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
            dlg.FilterIndex = 1;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                studImage.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //Save image to database
            MemoryStream ms = new MemoryStream();
            studImage.Image.Save(ms, studImage.Image.RawFormat);
            byte[] img = ms.GetBuffer();
            ms.Close();

            //Save radio button selected value
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            if (rbFemale.Checked)
            {
                gender = "Female";
            }

            try
            {
                if (MessageBox.Show("Are you sure you want to update this record?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //open connection to the database
                    cn.Open();
                    //command to be executed on the database
                    cm = new SqlCommand("UPDATE tblStudent SET stNumber = @stNumber, stLname = @stLname, stFname = @stFname, stCourse = @stCourse, stYear = @stYear, stGender = @stGender, stContact = @stContact, stEmail = @stEmail, stAddress = @stAddress, stImage = @stImage", cn);
                    //set parameters value
                    cm.Parameters.AddWithValue("@stNumber", txtStudNo.Text);
                    cm.Parameters.AddWithValue("@stLname", txtLname.Text);
                    cm.Parameters.AddWithValue("@stFname", txtFname.Text);
                    cm.Parameters.AddWithValue("@stCourse", cboCourse.Text);
                    cm.Parameters.AddWithValue("@stYear", cboYear.Text);
                    cm.Parameters.AddWithValue("@stGender", gender);
                    cm.Parameters.AddWithValue("@stContact", txtContact.Text);
                    cm.Parameters.AddWithValue("@stEmail", txtEmail.Text);
                    cm.Parameters.AddWithValue("@stAddress", txtAddress.Text);
                    cm.Parameters.AddWithValue("@stImage", img);
                    //ask db to execute query
                    cm.ExecuteNonQuery();
                    //close connection
                    cn.Close();
                    MessageBox.Show("Record has been sucessfully updated!");
                    Clear();
                    frmlist.LoadRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
