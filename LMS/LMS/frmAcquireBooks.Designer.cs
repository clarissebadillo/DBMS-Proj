namespace LMS
{
    partial class frmAcquireBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcquireBooks));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnAddCopies = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.lblAvailCopies = new Guna.UI.WinForms.GunaLabel();
            this.lblAlLCopies = new Guna.UI.WinForms.GunaLabel();
            this.lblBookTitle = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtCopies = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.popupNotifier = new Tulpep.NotificationWindow.PopupNotifier();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.btnAddCopies);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel4);
            this.gunaLinePanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaLinePanel1.Controls.Add(this.txtCopies);
            this.gunaLinePanel1.Controls.Add(this.gunaControlBox1);
            this.gunaLinePanel1.Controls.Add(this.lblTitle);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 8;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(489, 334);
            this.gunaLinePanel1.TabIndex = 2;
            // 
            // btnAddCopies
            // 
            this.btnAddCopies.AnimationHoverSpeed = 0.07F;
            this.btnAddCopies.AnimationSpeed = 0.03F;
            this.btnAddCopies.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCopies.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnAddCopies.BorderColor = System.Drawing.Color.Black;
            this.btnAddCopies.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddCopies.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddCopies.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddCopies.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddCopies.CheckedImage")));
            this.btnAddCopies.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddCopies.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddCopies.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddCopies.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddCopies.ForeColor = System.Drawing.Color.White;
            this.btnAddCopies.Image = null;
            this.btnAddCopies.ImageOffsetX = 7;
            this.btnAddCopies.ImageSize = new System.Drawing.Size(22, 22);
            this.btnAddCopies.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddCopies.Location = new System.Drawing.Point(316, 255);
            this.btnAddCopies.Name = "btnAddCopies";
            this.btnAddCopies.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.btnAddCopies.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddCopies.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddCopies.OnHoverImage = null;
            this.btnAddCopies.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddCopies.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddCopies.Radius = 7;
            this.btnAddCopies.Size = new System.Drawing.Size(141, 35);
            this.btnAddCopies.TabIndex = 62;
            this.btnAddCopies.Text = "Add Copies";
            this.btnAddCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddCopies.Click += new System.EventHandler(this.BtnAddCopies_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(28, 241);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(237, 15);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "Number of Copies";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.lblAvailCopies);
            this.gunaGroupBox1.Controls.Add(this.lblAlLCopies);
            this.gunaGroupBox1.Controls.Add(this.lblBookTitle);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.gunaGroupBox1.LineBottom = 1;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.LineLeft = 1;
            this.gunaGroupBox1.LineRight = 1;
            this.gunaGroupBox1.Location = new System.Drawing.Point(31, 89);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(426, 136);
            this.gunaGroupBox1.TabIndex = 16;
            this.gunaGroupBox1.Text = "Book Details";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // lblAvailCopies
            // 
            this.lblAvailCopies.AutoSize = true;
            this.lblAvailCopies.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAvailCopies.Location = new System.Drawing.Point(112, 106);
            this.lblAvailCopies.Name = "lblAvailCopies";
            this.lblAvailCopies.Size = new System.Drawing.Size(0, 15);
            this.lblAvailCopies.TabIndex = 5;
            // 
            // lblAlLCopies
            // 
            this.lblAlLCopies.AutoSize = true;
            this.lblAlLCopies.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAlLCopies.Location = new System.Drawing.Point(112, 77);
            this.lblAlLCopies.Name = "lblAlLCopies";
            this.lblAlLCopies.Size = new System.Drawing.Size(0, 15);
            this.lblAlLCopies.TabIndex = 4;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBookTitle.Location = new System.Drawing.Point(112, 48);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(0, 15);
            this.lblBookTitle.TabIndex = 3;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel3.Location = new System.Drawing.Point(13, 106);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(91, 13);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Available Copies";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel2.Location = new System.Drawing.Point(13, 77);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(58, 13);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "All Copies";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel1.Location = new System.Drawing.Point(13, 48);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(58, 13);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Book Title";
            // 
            // txtCopies
            // 
            this.txtCopies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCopies.DefaultText = "";
            this.txtCopies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCopies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCopies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCopies.DisabledState.Parent = this.txtCopies;
            this.txtCopies.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCopies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtCopies.FocusedState.Parent = this.txtCopies;
            this.txtCopies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.txtCopies.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtCopies.HoverState.Parent = this.txtCopies;
            this.txtCopies.Location = new System.Drawing.Point(31, 259);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.PasswordChar = '\0';
            this.txtCopies.PlaceholderText = "";
            this.txtCopies.SelectedText = "";
            this.txtCopies.ShadowDecoration.Parent = this.txtCopies;
            this.txtCopies.Size = new System.Drawing.Size(234, 27);
            this.txtCopies.TabIndex = 15;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(451, 8);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(37, 29);
            this.gunaControlBox1.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblTitle.Location = new System.Drawing.Point(32, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Acquire New Copies";
            // 
            // popupNotifier
            // 
            this.popupNotifier.BodyColor = System.Drawing.Color.White;
            this.popupNotifier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.popupNotifier.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.popupNotifier.ButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.popupNotifier.ContentFont = new System.Drawing.Font("Tahoma", 10F);
            this.popupNotifier.ContentPadding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.popupNotifier.ContentText = null;
            this.popupNotifier.GradientPower = 0;
            this.popupNotifier.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.popupNotifier.HeaderHeight = 10;
            this.popupNotifier.Image = global::LMS.Properties.Resources.jungkook;
            this.popupNotifier.ImagePadding = new System.Windows.Forms.Padding(10, 12, 0, 0);
            this.popupNotifier.ImageSize = new System.Drawing.Size(70, 70);
            this.popupNotifier.IsRightToLeft = false;
            this.popupNotifier.OptionsMenu = null;
            this.popupNotifier.ShowGrip = false;
            this.popupNotifier.Size = new System.Drawing.Size(400, 100);
            this.popupNotifier.TitleColor = System.Drawing.Color.Transparent;
            this.popupNotifier.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.popupNotifier.TitleText = null;
            // 
            // frmAcquireBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 334);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAcquireBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAcquireBooks";
            this.Load += new System.EventHandler(this.FrmAcquireBooks_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        public System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtCopies;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddCopies;
        public Guna.UI.WinForms.GunaLabel lblAvailCopies;
        public Guna.UI.WinForms.GunaLabel lblBookTitle;
        public Guna.UI.WinForms.GunaLabel lblAlLCopies;
        private Tulpep.NotificationWindow.PopupNotifier popupNotifier;
    }
}