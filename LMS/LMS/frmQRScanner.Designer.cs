namespace LMS
{
    partial class frmQRScanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnStopScan = new Guna.UI.WinForms.GunaButton();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.QRScanner = new System.Windows.Forms.PictureBox();
            this.btnStartScan = new Guna.UI.WinForms.GunaButton();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRScanner)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
            this.gunaLinePanel1.Controls.Add(this.comboBox1);
            this.gunaLinePanel1.Controls.Add(this.btnStopScan);
            this.gunaLinePanel1.Controls.Add(this.lblName);
            this.gunaLinePanel1.Controls.Add(this.lblTitle);
            this.gunaLinePanel1.Controls.Add(this.QRScanner);
            this.gunaLinePanel1.Controls.Add(this.btnStartScan);
            this.gunaLinePanel1.Controls.Add(this.gunaControlBox1);
            this.gunaLinePanel1.Controls.Add(this.panel1);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(358, 485);
            this.gunaLinePanel1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(57, 21);
            this.comboBox1.TabIndex = 61;
            this.comboBox1.Visible = false;
            // 
            // btnStopScan
            // 
            this.btnStopScan.AnimationHoverSpeed = 0.07F;
            this.btnStopScan.AnimationSpeed = 0.03F;
            this.btnStopScan.BackColor = System.Drawing.Color.Transparent;
            this.btnStopScan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnStopScan.BorderColor = System.Drawing.Color.Black;
            this.btnStopScan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStopScan.FocusedColor = System.Drawing.Color.Empty;
            this.btnStopScan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStopScan.ForeColor = System.Drawing.Color.White;
            this.btnStopScan.Image = null;
            this.btnStopScan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStopScan.Location = new System.Drawing.Point(86, 376);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnStopScan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStopScan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStopScan.OnHoverImage = null;
            this.btnStopScan.OnPressedColor = System.Drawing.Color.Black;
            this.btnStopScan.Radius = 7;
            this.btnStopScan.Size = new System.Drawing.Size(187, 42);
            this.btnStopScan.TabIndex = 60;
            this.btnStopScan.Text = "Stop Scanning";
            this.btnStopScan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStopScan.Click += new System.EventHandler(this.BtnStopScan_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 59;
            this.lblName.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblTitle.Location = new System.Drawing.Point(92, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 28);
            this.lblTitle.TabIndex = 58;
            this.lblTitle.Text = "QR Code Scanner";
            // 
            // QRScanner
            // 
            this.QRScanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QRScanner.Image = global::LMS.Properties.Resources.QRScanner;
            this.QRScanner.Location = new System.Drawing.Point(44, 92);
            this.QRScanner.Name = "QRScanner";
            this.QRScanner.Size = new System.Drawing.Size(270, 270);
            this.QRScanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.QRScanner.TabIndex = 57;
            this.QRScanner.TabStop = false;
            // 
            // btnStartScan
            // 
            this.btnStartScan.AnimationHoverSpeed = 0.07F;
            this.btnStartScan.AnimationSpeed = 0.03F;
            this.btnStartScan.BackColor = System.Drawing.Color.Transparent;
            this.btnStartScan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnStartScan.BorderColor = System.Drawing.Color.Black;
            this.btnStartScan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStartScan.FocusedColor = System.Drawing.Color.Empty;
            this.btnStartScan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStartScan.ForeColor = System.Drawing.Color.White;
            this.btnStartScan.Image = null;
            this.btnStartScan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStartScan.Location = new System.Drawing.Point(86, 376);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnStartScan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStartScan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStartScan.OnHoverImage = null;
            this.btnStartScan.OnPressedColor = System.Drawing.Color.Black;
            this.btnStartScan.Radius = 7;
            this.btnStartScan.Size = new System.Drawing.Size(187, 42);
            this.btnStartScan.TabIndex = 56;
            this.btnStartScan.Text = "Start Scanning";
            this.btnStartScan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStartScan.Click += new System.EventHandler(this.BtnStartScan_Click);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(312, 7);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 7);
            this.panel1.TabIndex = 26;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frmQRScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(358, 485);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQRScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQRScanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQRScanner_FormClosing);
            this.Load += new System.EventHandler(this.FrmQRScanner_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRScanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        public Guna.UI.WinForms.GunaButton btnStopScan;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.PictureBox QRScanner;
        public Guna.UI.WinForms.GunaButton btnStartScan;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
    }
}