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
using MyMessage;

namespace LMS
{
    public partial class frmAddEditStudent : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmStudentList frmlist;

        string gender = "";

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      // WS_EX_COMPOSITED
                return handleParam;
            }
        }

        public frmAddEditStudent(frmStudentList flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmlist = flist;
        }

        private void FrmAddEditStudent_Load(object sender, EventArgs e)
        {
            LoadPrograms();
        }


        public void Clear()
        {
            txtAddress.Text = "";
            txtStudNo.Text = "";
            txtLname.Text = "";
            txtFname.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            rbFemale.Checked = false;
            rbMale.Checked = false;
            cboCourse.SelectedIndex = -1;
            cboYear.SelectedIndex = -1;
            studImage.Image = Properties.Resources.user;
        }

        void LoadPrograms()
        {
            cboCourse.Items.Clear();
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

            if (txtStudNo.Text == "" || txtFname.Text == "" || txtLname.Text == "" || txtAddress.Text == "" || txtContact.Text == "" || txtEmail.Text == "" || cboCourse.Text == "" || cboYear.Text == "")
            {
                MyMessageBox.ShowMessage("Please don't leave blank spaces! Add 'NA' for blank spaces instead.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (MyMessageBox.ShowMessage("Are you sure you want to add " + txtFname.Text + " " + txtLname.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("SELECT COUNT(*) FROM tblStudent WHERE studentNum = @studentNum", cn);
                        cm.Parameters.AddWithValue("@studentNum", txtStudNo.Text);

                        //open connection to the database
                        cn.Open();

                        int records = (int)cm.ExecuteScalar();

                        if (records == 0)
                        {
                            cm.Parameters.Clear();
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

                            popupNotifier.ContentText = txtFname.Text + " " + txtLname.Text + " has been successfully added!";
                            popupNotifier.Popup();
                            Clear();
                            frmlist.LoadRecords();
                        }
                        else
                        {
                            MyMessageBox.ShowMessage("Student number already exist!", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        }
                        //Close connection
                        cn.Close();
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
                if (MyMessageBox.ShowMessage("Are you sure you want to update this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //open connection to the database
                    cn.Open();
                    //command to be executed on the database
                    cm = new SqlCommand("UPDATE tblStudent SET studentNum = @studentNum, lastName = @lastName, firstName = @firstName, course = @course, year = @year, gender = @gender, contact = @contact, email = @email, address = @address, image = @image WHERE studentID LIKE '" + lblID.Text + "'", cn);
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
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

    }
}
