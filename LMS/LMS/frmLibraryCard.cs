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
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace LMS
{
    public partial class frmLibraryCard : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        PrintPreviewDialog prntprvw = new PrintPreviewDialog();
        PrintDocument printdoc = new PrintDocument();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      // WS_EX_COMPOSITED
                return handleParam;
            }
        }

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

        private void TxtStudentName_TextChanged(object sender, EventArgs e)
        {
            lblStudentName.Text = txtStudentName.Text;
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
                save.FileName = "QR - " + lblStudentName.Text;
                save.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    QR.Image.Save(save.FileName);
                    save.InitialDirectory = Environment.GetFolderPath
                                (Environment.SpecialFolder.Desktop);
                }
            }
        }


        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Print(this.pnlID);
            Logs();
        }

        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            //pnlID = pnl;
            //GetPrintArea(pnl);
            prntprvw.Document = printdoc;
            printdoc.PrintPage += new PrintPageEventHandler(printdoc_printpage);
            prntprvw.ShowDialog();

        }

        public void printdoc_printpage(Object sender, PrintPageEventArgs e)
        {
            var bitmap = ScrollableControlToBitmap(this.pnlID, false);
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(bitmap, new Rectangle(0, 0, 625, 473));
        }


        public Bitmap ScrollableControlToBitmap(ScrollableControl canvas, bool includeHidden)
        {
            canvas.AutoScrollPosition = new Point(0, 0);
            if (includeHidden)
            {
                canvas.SuspendLayout();
                foreach (Control child in canvas.Controls)
                {
                    child.Visible = true;
                }
                canvas.ResumeLayout(true);
            }

            Size containerSize = canvas.PreferredSize;
            var bitmap = new Bitmap(containerSize.Width, containerSize.Height, PixelFormat.Format32bppArgb);
            bitmap.SetResolution(this.DeviceDpi, this.DeviceDpi);

            var graphics = Graphics.FromImage(bitmap);
            graphics.Clear(canvas.BackColor);
            var rtfPrinter = new RichEditPrinter(graphics);

            try
            {
                DrawNestedControls(canvas, canvas, new Rectangle(Point.Empty, containerSize), bitmap, rtfPrinter);
                return bitmap;
            }
            finally
            {
                rtfPrinter.Dispose();
                graphics.Dispose();
            }
        }

        private void DrawNestedControls(Control outerContainer, Control parent, Rectangle parentBounds, Bitmap bitmap, RichEditPrinter rtfPrinter)
        {
            for (int i = parent.Controls.Count - 1; i >= 0; i--)
            {
                var ctl = parent.Controls[i];
                if (ctl.Width < 1 || ctl.Height < 1) continue;
                var clipBounds = (parent == outerContainer)
                               ? ctl.Bounds
                               : Rectangle.Intersect(new Rectangle(Point.Empty, parentBounds.Size), ctl.Bounds);

                if (ctl.Visible)
                {
                    var bounds = outerContainer.RectangleToClient(parent.RectangleToScreen(clipBounds));

                    if (ctl is RichTextBox rtb)
                    {
                        rtfPrinter.DrawRtf(rtb.Rtf, parentBounds, clipBounds);
                    }
                    else
                    {
                        ctl.DrawToBitmap(bitmap, bounds);
                    }
                }
                if (ctl.HasChildren)
                {
                    DrawNestedControls(outerContainer, ctl, clipBounds, bitmap, rtfPrinter);
                }
            }
        }


        public class RichEditPrinter : IDisposable
        {
            Graphics dc = null;
            RTBPrinter rtb = null;

            public RichEditPrinter(Graphics graphics)
            {
                this.dc = graphics;
                this.rtb = new RTBPrinter() { ScrollBars = RichTextBoxScrollBars.None };
            }

            public void DrawRtf(string rtf, Rectangle canvas, Rectangle layoutArea)
            {
                rtb.Rtf = rtf;
                rtb.Draw(dc, canvas, layoutArea);
                rtb.Clear();
            }
            public void Dispose() => this.rtb.Dispose();

            private class RTBPrinter : RichTextBox
            {
                //Code converted from code found here: http://support.microsoft.com/kb/812425/en-us
                public void Draw(Graphics g, Rectangle hdcArea, Rectangle layoutArea)
                {
                    IntPtr hdc = g.GetHdc();
                    var canvasAreaTwips = new RECT().ToInches(hdcArea);
                    var layoutAreaTwips = new RECT().ToInches(layoutArea);

                    FORMATRANGE fmtRange = new FORMATRANGE()
                    {
                        chrg = new CHARRANGE() { cpMax = -1, cpMin = 0 },
                        hdc = hdc,
                        hdcTarget = hdc,
                        rc = layoutAreaTwips,
                        rcPage = canvasAreaTwips
                    };

                    IntPtr lParam = Marshal.AllocCoTaskMem(Marshal.SizeOf(fmtRange));
                    Marshal.StructureToPtr(fmtRange, lParam, false);

                    SendMessage(this.Handle, EM_FORMATRANGE, (IntPtr)1, lParam);
                    Marshal.FreeCoTaskMem(lParam);
                    g.ReleaseHdc(hdc);
                }

                [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
                internal static extern int SendMessage(IntPtr hWnd, int uMsg, IntPtr wParam, IntPtr lParam);

                internal const int WM_USER = 0x0400;
                // https://docs.microsoft.com/en-us/windows/win32/controls/em-formatrange
                internal const int EM_FORMATRANGE = WM_USER + 57;

                [StructLayout(LayoutKind.Sequential)]
                internal struct RECT
                {
                    public int Left;
                    public int Top;
                    public int Right;
                    public int Bottom;

                    public Rectangle ToRectangle() => Rectangle.FromLTRB(Left, Top, Right, Bottom);
                    public RECT ToInches(Rectangle rectangle)
                    {
                        float inch = 14.9f;
                        return new RECT()
                        {
                            Left = (int)(rectangle.Left * inch),
                            Top = (int)(rectangle.Top * inch),
                            Right = (int)(rectangle.Right * inch),
                            Bottom = (int)(rectangle.Bottom * inch)
                        };
                    }
                }

                // https://docs.microsoft.com/en-us/windows/win32/api/richedit/ns-richedit-formatrange?
                [StructLayout(LayoutKind.Sequential)]
                internal struct FORMATRANGE
                {
                    public IntPtr hdcTarget;    // A HDC for the target device to format for
                    public IntPtr hdc;          // A HDC for the device to render to, if EM_FORMATRANGE is being used to send the output to a device
                    public RECT rc;             // The area within the rcPage rectangle to render to. Units are measured in twips.
                    public RECT rcPage;         // The entire area of a page on the rendering device. Units are measured in twips.
                    public CHARRANGE chrg;      // The range of characters to format (see CHARRANGE)
                }

                [StructLayout(LayoutKind.Sequential)]
                internal struct CHARRANGE
                {
                    public int cpMin;           // First character of range (0 for start of doc)
                    public int cpMax;           // Last character of range (-1 for end of doc)
                }
            }
        }


        void Logs()
        {
            var details = lblLibrarian.Text + " generated library card for " + lblStudentName.Text + "";

            cn.Open();
            cm = new SqlCommand("INSERT INTO tblLogs VALUES (@details, GETDATE())", cn);
            cm.Parameters.AddWithValue("@details", details);
            cm.ExecuteNonQuery();
            cn.Close();
        }

    }
}
