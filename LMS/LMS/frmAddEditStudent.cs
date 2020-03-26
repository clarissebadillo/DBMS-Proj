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
                MessageBox.Show("Please don't leave blank spaces", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        cm = new SqlCommand("INSERT INTO tblStudent VALUES (@studentNum, @lastName, @firstName, @course, @year, @gender, @contact, @email, @address, @image)", cn);
                        //set parameters value
                        cm.Parameters.AddWithValue("@studentNum", txtStudNo.Text);
                        cm.Parameters.AddWithValue("@lastName", txtLname.Text);
                        cm.Parameters.AddWithValue("@firstName", txtFname.Text);
                        cm.Parameters.AddWithValue("@course", cboCourse.Text);
                        cm.Parameters.AddWithValue("@year", cboYear.Text);
                        cm.Parameters.AddWithValue("@gender", gender);
                        cm.Parameters.AddWithValue("@contact", txtContact.Text);
                        cm.Parameters.AddWithValue("@email", txtEmail.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.Parameters.AddWithValue("@image", img);
                        //ask db to execute query
                        cm.ExecuteNonQuery();
                        //close connection
                        cn.Close();

                        popupNotifier.ContentText = txtFname.Text + " " + txtLname.Text + " has been successfully added!";
                        popupNotifier.Popup();
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
                    cm = new SqlCommand("UPDATE tblStudent SET studentNum = @studentNum, lastName = @lastName, firstName = @firstName, course = @course, year = @year, gender = @gender, contact = @contact, email = @email, address = @address, image = @image", cn);
                    //set parameters value
                    cm.Parameters.AddWithValue("@studentNum", txtStudNo.Text);
                    cm.Parameters.AddWithValue("@lastName", txtLname.Text);
                    cm.Parameters.AddWithValue("@firstName", txtFname.Text);
                    cm.Parameters.AddWithValue("@course", cboCourse.Text);
                    cm.Parameters.AddWithValue("@year", cboYear.Text);
                    cm.Parameters.AddWithValue("@gender", gender);
                    cm.Parameters.AddWithValue("@contact", txtContact.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@image", img);
                    //ask db to execute query
                    cm.ExecuteNonQuery();
                    //close connection
                    cn.Close();

                    popupNotifier.ContentText = txtFname.Text + " " + txtLname.Text + " has been successfully updated!";
                    popupNotifier.Popup();
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
