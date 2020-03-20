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
        string imgPath = "";

        public frmAddEditStudent(frmStudentList flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmlist = flist;
        }

        private void Clear()
        {
            txtAddress.Text = "";
            txtStudNo.Text = "";
            txtLname.Text = "";
            txtFname.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Save image to database
            byte[] imageBt = null;
            FileStream fstream = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);


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
                if (MessageBox.Show("Are you sure you want to save this book?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //open connection to the database
                    cn.Open();
                    //command to be executed on the database
                    cm = new SqlCommand("INSERT INTO tblStudent VALUES (@stNumber, @stLname, @stFname, @stCourse, @stYear, @stGender, @stContact, @stEmail, @stAddress, @imageBt)", cn);
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
                    cm.Parameters.AddWithValue("@imageBt", imageBt);
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

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpeg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgPath = dlg.FileName.ToString();
                studImage.ImageLocation = imgPath;
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
