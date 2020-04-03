namespace LMS
{
    partial class frmGenerateQR
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
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.QR = new System.Windows.Forms.PictureBox();
            this.btnSaveQR = new Guna.UI.WinForms.GunaButton();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QR)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
            this.gunaLinePanel1.Controls.Add(this.lblName);
            this.gunaLinePanel1.Controls.Add(this.lblTitle);
            this.gunaLinePanel1.Controls.Add(this.QR);
            this.gunaLinePanel1.Controls.Add(this.btnSaveQR);
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
            this.gunaLinePanel1.Size = new System.Drawing.Size(334, 418);
            this.gunaLinePanel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblTitle.Location = new System.Drawing.Point(70, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 28);
            this.lblTitle.TabIndex = 58;
            this.lblTitle.Text = "QR Code Generator";
            // 
            // QR
            // 
            this.QR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QR.Location = new System.Drawing.Point(57, 102);
            this.QR.Name = "QR";
            this.QR.Size = new System.Drawing.Size(220, 220);
            this.QR.TabIndex = 57;
            this.QR.TabStop = false;
            // 
            // btnSaveQR
            // 
            this.btnSaveQR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveQR.AnimationHoverSpeed = 0.07F;
            this.btnSaveQR.AnimationSpeed = 0.03F;
            this.btnSaveQR.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveQR.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnSaveQR.BorderColor = System.Drawing.Color.Black;
            this.btnSaveQR.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveQR.FocusedColor = System.Drawing.Color.Empty;
            this.btnSaveQR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveQR.ForeColor = System.Drawing.Color.White;
            this.btnSaveQR.Image = null;
            this.btnSaveQR.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSaveQR.Location = new System.Drawing.Point(99, 342);
            this.btnSaveQR.Name = "btnSaveQR";
            this.btnSaveQR.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnSaveQR.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaveQR.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSaveQR.OnHoverImage = null;
            this.btnSaveQR.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaveQR.Radius = 7;
            this.btnSaveQR.Size = new System.Drawing.Size(136, 36);
            this.btnSaveQR.TabIndex = 56;
            this.btnSaveQR.Text = "Save QR Code";
            this.btnSaveQR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveQR.Click += new System.EventHandler(this.BtnSaveQR_Click);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(288, 7);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
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
            this.panel1.Size = new System.Drawing.Size(334, 7);
            this.panel1.TabIndex = 26;
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
            // frmGenerateQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 418);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGenerateQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGenerateQR";
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        public Guna.UI.WinForms.GunaButton btnSaveQR;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox QR;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblName;
    }
}