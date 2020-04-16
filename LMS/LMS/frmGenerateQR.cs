using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class frmGenerateQR : Form
    {
        frmStudentList frm;

        public frmGenerateQR(frmStudentList flist)
        {
            InitializeComponent();
            frm = flist;
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
                save.FileName = lblName.Text; //"QR";
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
