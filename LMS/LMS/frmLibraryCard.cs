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
    public partial class frmLibraryCard : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        public frmLibraryCard()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void FrmLibraryCard_Load(object sender, EventArgs e)
        {
            txtName.Select();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            lblName.Text = txtName.Text;
        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {
            lblAddress.Text = txtAddress.Text;
        }

        private void TxtRelationship_TextChanged(object sender, EventArgs e)
        {
            lblRelationship.Text = txtRelationship.Text;
        }

        private void TxtContact_TextChanged(object sender, EventArgs e)
        {
            lblContact.Text = txtContact.Text;
        }

        private void TxtValidity_TextChanged(object sender, EventArgs e)
        {
            lblValidity.Text = txtValidity.Text;
        }

        private void BtnSaveQR_Click(object sender, EventArgs e)
        {
            if (QR.Image == null)
            {
                MessageBox.Show("Image not found", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.CreatePrompt = true;
                save.OverwritePrompt = true;
                save.FileName = "QR";
                save.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    QR.Image.Save(save.FileName);
                    save.InitialDirectory = Environment.GetFolderPath
                                (Environment.SpecialFolder.Desktop);
                }
            }
        }
    }
}
