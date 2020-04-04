using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace LMS
{
    public partial class frmQRScanner : Form
    {
        frmIssueBook frm;
        public frmQRScanner(frmIssueBook f)
        {
            InitializeComponent();
            frm = f;
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void FrmQRScanner_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            captureDevice = new VideoCaptureDevice();
            btnStopScan.Visible = false;
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            QRScanner.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void BtnStartScan_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            captureDevice.NewFrame += FinalFrame_NewFrame;
            captureDevice.Start();
            timer1.Start();
            btnStartScan.Visible = false;
            btnStopScan.Visible = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (QRScanner.Image != null)
            { 
                BarcodeReader Reader = new BarcodeReader();
                Result result = Reader.Decode((Bitmap)QRScanner.Image);
                if (result != null)
                {
                    string decoded = result.ToString().Trim();
                    if (decoded != "")
                    {
                        frm.txtSearchStud.Text = decoded;
                        Console.Beep();
                        timer1.Stop();
                        this.Close();
                    }
                }
            }
        }

        private void BtnStopScan_Click(object sender, EventArgs e)
        {
            captureDevice.Stop();
            QRScanner.Image = Properties.Resources.QRScanner;
            btnStartScan.Visible = true;
            btnStopScan.Visible = false;
        }

        private void FrmQRScanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning == true)
                captureDevice.Stop();
        }
    }
}
