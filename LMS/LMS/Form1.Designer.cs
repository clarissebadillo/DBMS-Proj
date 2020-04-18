namespace LMS
{
    partial class Form1
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
            Guna.UI.Animation.Animation animation5 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlMenuAnimation = new Guna.UI.WinForms.GunaTransition(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSettings = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnIssueBook = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnStudent = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnHistory = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUserAccount = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnReports = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnBook = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDashboard = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblLibrarian = new Guna.UI.WinForms.GunaLabel();
            this.btnMin = new Guna.UI.WinForms.GunaCircleButton();
            this.btnMax = new Guna.UI.WinForms.GunaCircleButton();
            this.btnClose = new Guna.UI.WinForms.GunaCircleButton();
            this.btnPin = new Guna.UI.WinForms.GunaImageButton();
            this.btnUnpin = new Guna.UI.WinForms.GunaImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.pnlMenuAnimation.SetDecoration(this.panel3, Guna.UI.Animation.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(230, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1050, 596);
            this.panel3.TabIndex = 5;
            // 
            // pnlMenuAnimation
            // 
            this.pnlMenuAnimation.AnimationType = Guna.UI.Animation.AnimationType.HorizBlind;
            this.pnlMenuAnimation.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.pnlMenuAnimation.DefaultAnimation = animation5;
            this.pnlMenuAnimation.TimeStep = 0.01F;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Controls.Add(this.btnIssueBook);
            this.pnlMenu.Controls.Add(this.btnStudent);
            this.pnlMenu.Controls.Add(this.btnHistory);
            this.pnlMenu.Controls.Add(this.btnUserAccount);
            this.pnlMenu.Controls.Add(this.btnReports);
            this.pnlMenu.Controls.Add(this.btnBook);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenuAnimation.SetDecoration(this.pnlMenu, Guna.UI.Animation.DecorationType.None);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(230, 683);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnLogout.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.CheckedImage")));
            this.btnLogout.CheckedLineColor = System.Drawing.Color.DimGray;
            this.pnlMenuAnimation.SetDecoration(this.btnLogout, Guna.UI.Animation.DecorationType.None);
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageOffsetX = 15;
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLogout.Location = new System.Drawing.Point(-1, 632);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(231, 48);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextOffsetX = 18;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.AnimationHoverSpeed = 0.07F;
            this.btnSettings.AnimationSpeed = 0.03F;
            this.btnSettings.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnSettings.BorderColor = System.Drawing.Color.Black;
            this.btnSettings.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnSettings.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSettings.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.CheckedImage")));
            this.btnSettings.CheckedLineColor = System.Drawing.Color.DimGray;
            this.pnlMenuAnimation.SetDecoration(this.btnSettings, Guna.UI.Animation.DecorationType.None);
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.FocusedColor = System.Drawing.Color.Empty;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageOffsetX = 15;
            this.btnSettings.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSettings.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSettings.Location = new System.Drawing.Point(0, 580);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnSettings.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSettings.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSettings.OnHoverImage = null;
            this.btnSettings.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSettings.OnPressedColor = System.Drawing.Color.Black;
            this.btnSettings.Size = new System.Drawing.Size(231, 48);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextOffsetX = 18;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.AnimationHoverSpeed = 0.07F;
            this.btnIssueBook.AnimationSpeed = 0.03F;
            this.btnIssueBook.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnIssueBook.BorderColor = System.Drawing.Color.Black;
            this.btnIssueBook.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnIssueBook.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnIssueBook.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIssueBook.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnIssueBook.CheckedImage")));
            this.btnIssueBook.CheckedLineColor = System.Drawing.Color.DimGray;
            this.pnlMenuAnimation.SetDecoration(this.btnIssueBook, Guna.UI.Animation.DecorationType.None);
            this.btnIssueBook.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIssueBook.FocusedColor = System.Drawing.Color.Empty;
            this.btnIssueBook.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBook.ForeColor = System.Drawing.Color.White;
            this.btnIssueBook.Image = ((System.Drawing.Image)(resources.GetObject("btnIssueBook.Image")));
            this.btnIssueBook.ImageOffsetX = 15;
            this.btnIssueBook.ImageSize = new System.Drawing.Size(22, 22);
            this.btnIssueBook.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnIssueBook.Location = new System.Drawing.Point(0, 372);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnIssueBook.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIssueBook.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIssueBook.OnHoverImage = null;
            this.btnIssueBook.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnIssueBook.OnPressedColor = System.Drawing.Color.Black;
            this.btnIssueBook.Size = new System.Drawing.Size(231, 48);
            this.btnIssueBook.TabIndex = 6;
            this.btnIssueBook.Text = "Issue Book";
            this.btnIssueBook.TextOffsetX = 18;
            this.btnIssueBook.Click += new System.EventHandler(this.BtnIssueBook_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.AnimationHoverSpeed = 0.07F;
            this.btnStudent.AnimationSpeed = 0.03F;
            this.btnStudent.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnStudent.BorderColor = System.Drawing.Color.Black;
            this.btnStudent.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnStudent.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnStudent.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStudent.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnStudent.CheckedImage")));
            this.btnStudent.CheckedLineColor = System.Drawing.Color.DimGray;
            this.pnlMenuAnimation.SetDecoration(this.btnStudent, Guna.UI.Animation.DecorationType.None);
            this.btnStudent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStudent.FocusedColor = System.Drawing.Color.Empty;
            this.btnStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.Image")));
            this.btnStudent.ImageOffsetX = 15;
            this.btnStudent.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStudent.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnStudent.Location = new System.Drawing.Point(0, 320);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnStudent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStudent.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStudent.OnHoverImage = null;
            this.btnStudent.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnStudent.OnPressedColor = System.Drawing.Color.Black;
            this.btnStudent.Size = new System.Drawing.Size(231, 48);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "Students";
            this.btnStudent.TextOffsetX = 18;
            this.btnStudent.Click += new System.EventHandler(this.BtnStudent_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.AnimationHoverSpeed = 0.07F;
            this.btnHistory.AnimationSpeed = 0.03F;
            this.btnHistory.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnHistory.BorderColor = System.Drawing.Color.Black;
            this.btnHistory.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnHistory.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnHistory.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHistory.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnHistory.CheckedImage")));
            this.btnHistory.CheckedLineColor = System.Drawing.Color.DimGray;
            this.pnlMenuAnimation.SetDecoration(this.btnHistory, Guna.UI.Animation.DecorationType.None);
            this.btnHistory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHistory.FocusedColor = System.Drawing.Color.Empty;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageOffsetX = 15;
            this.btnHistory.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHistory.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHistory.Location = new System.Drawing.Point(-1, 424);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnHistory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHistory.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHistory.OnHoverImage = null;
            this.btnHistory.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHistory.OnPressedColor = System.Drawing.Color.Black;
            this.btnHistory.Size = new System.Drawing.Size(231, 48);
            this.btnHistory.TabIndex = 7;
            this.btnHistory.Text = "Activity History";
            this.btnHistory.TextOffsetX = 18;
            this.btnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // btnUserAccount
            // 
            this.btnUserAccount.AnimationHoverSpeed = 0.07F;
            this.btnUserAccount.AnimationSpeed = 0.03F;
            this.btnUserAccount.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnUserAccount.BorderColor = System.Drawing.Color.Black;
            this.btnUserAccount.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnUserAccount.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUserAccount.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUserAccount.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnUserAccount.CheckedImage")));
            this.btnUserAccount.CheckedLineColor = System.Drawing.Color.DimGray;
            this.pnlMenuAnimation.SetDecoration(this.btnUserAccount, Guna.UI.Animation.DecorationType.None);
            this.btnUserAccount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUserAccount.FocusedColor = System.Drawing.Color.Empty;
            this.btnUserAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAccount.ForeColor = System.Drawing.Color.White;
            this.btnUserAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnUserAccount.Image")));
            this.btnUserAccount.ImageOffsetX = 15;
            this.btnUserAccount.ImageSize = new System.Drawing.Size(22, 22);
            this.btnUserAccount.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUserAccount.Location = new System.Drawing.Point(0, 528);
            this.btnUserAccount.Name = "btnUserAccount";
            this.btnUserAccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnUserAccount.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUserAccount.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUserAccount.OnHoverImage = null;
            this.btnUserAccount.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUserAccount.OnPressedColor = System.Drawing.Color.Black;
            this.btnUserAccount.Size = new System.Drawing.Size(231, 48);
            this.btnUserAccount.TabIndex = 5;
            this.btnUserAccount.Text = "User Account";
            this.btnUserAccount.TextOffsetX = 18;
            this.btnUserAccount.Click += new System.EventHandler(this.BtnUserAccount_Click);
            // 
            // btnReports
            // 
            this.btnReports.AnimationHoverSpeed = 0.07F;
            this.btnReports.AnimationSpeed = 0.03F;
            this.btnReports.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnReports.BorderColor = System.Drawing.Color.Black;
            this.btnReports.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnReports.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnReports.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReports.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnReports.CheckedImage")));
            this.btnReports.CheckedLineColor = System.Drawing.Color.DimGray;
            this.pnlMenuAnimation.SetDecoration(this.btnReports, Guna.UI.Animation.DecorationType.None);
            this.btnReports.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReports.FocusedColor = System.Drawing.Color.Empty;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageOffsetX = 15;
            this.btnReports.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReports.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReports.Location = new System.Drawing.Point(-1, 476);
            this.btnReports.Name = "btnReports";
            this.btnReports.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnReports.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReports.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReports.OnHoverImage = null;
            this.btnReports.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReports.OnPressedColor = System.Drawing.Color.Black;
            this.btnReports.Size = new System.Drawing.Size(231, 48);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Reports";
            this.btnReports.TextOffsetX = 18;
            this.btnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // btnBook
            // 
            this.btnBook.AnimationHoverSpeed = 0.07F;
            this.btnBook.AnimationSpeed = 0.03F;
            this.btnBook.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnBook.BorderColor = System.Drawing.Color.Black;
            this.btnBook.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnBook.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBook.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBook.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBook.CheckedImage")));
            this.btnBook.CheckedLineColor = System.Drawing.Color.DimGray;
            this.pnlMenuAnimation.SetDecoration(this.btnBook, Guna.UI.Animation.DecorationType.None);
            this.btnBook.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBook.FocusedColor = System.Drawing.Color.Empty;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Image = ((System.Drawing.Image)(resources.GetObject("btnBook.Image")));
            this.btnBook.ImageOffsetX = 15;
            this.btnBook.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBook.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBook.Location = new System.Drawing.Point(0, 268);
            this.btnBook.Name = "btnBook";
            this.btnBook.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnBook.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBook.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBook.OnHoverImage = null;
            this.btnBook.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBook.OnPressedColor = System.Drawing.Color.Black;
            this.btnBook.Size = new System.Drawing.Size(231, 48);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "Books";
            this.btnBook.TextOffsetX = 18;
            this.btnBook.Click += new System.EventHandler(this.BtnBook_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AnimationHoverSpeed = 0.07F;
            this.btnDashboard.AnimationSpeed = 0.03F;
            this.btnDashboard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnDashboard.BorderColor = System.Drawing.Color.Black;
            this.btnDashboard.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnDashboard.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboard.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.CheckedImage")));
            this.btnDashboard.CheckedLineColor = System.Drawing.Color.DimGray;
            this.pnlMenuAnimation.SetDecoration(this.btnDashboard, Guna.UI.Animation.DecorationType.None);
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageOffsetX = 15;
            this.btnDashboard.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDashboard.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 216);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnDashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnHoverImage = null;
            this.btnDashboard.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDashboard.OnPressedColor = System.Drawing.Color.Black;
            this.btnDashboard.Size = new System.Drawing.Size(231, 48);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextOffsetX = 18;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenuAnimation.SetDecoration(this.pictureBox1, Guna.UI.Animation.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblLibrarian);
            this.panel2.Controls.Add(this.btnMin);
            this.panel2.Controls.Add(this.btnMax);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnPin);
            this.panel2.Controls.Add(this.btnUnpin);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.lblDate);
            this.pnlMenuAnimation.SetDecoration(this.panel2, Guna.UI.Animation.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(230, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 87);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pnlMenuAnimation.SetDecoration(this.pictureBox2, Guna.UI.Animation.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // lblLibrarian
            // 
            this.lblLibrarian.AutoSize = true;
            this.pnlMenuAnimation.SetDecoration(this.lblLibrarian, Guna.UI.Animation.DecorationType.None);
            this.lblLibrarian.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLibrarian.Location = new System.Drawing.Point(70, 15);
            this.lblLibrarian.Name = "lblLibrarian";
            this.lblLibrarian.Size = new System.Drawing.Size(93, 19);
            this.lblLibrarian.TabIndex = 13;
            this.lblLibrarian.Text = "Administrator";
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.AnimationHoverSpeed = 0.07F;
            this.btnMin.AnimationSpeed = 0.03F;
            this.btnMin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(47)))));
            this.btnMin.BorderColor = System.Drawing.Color.Black;
            this.pnlMenuAnimation.SetDecoration(this.btnMin, Guna.UI.Animation.DecorationType.None);
            this.btnMin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMin.FocusedColor = System.Drawing.Color.Empty;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Image = null;
            this.btnMin.ImageSize = new System.Drawing.Size(52, 52);
            this.btnMin.Location = new System.Drawing.Point(976, 13);
            this.btnMin.Name = "btnMin";
            this.btnMin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(4)))));
            this.btnMin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMin.OnHoverImage = null;
            this.btnMin.OnPressedColor = System.Drawing.Color.Black;
            this.btnMin.Size = new System.Drawing.Size(15, 15);
            this.btnMin.TabIndex = 12;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.AnimationHoverSpeed = 0.07F;
            this.btnMax.AnimationSpeed = 0.03F;
            this.btnMax.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(206)))), ((int)(((byte)(66)))));
            this.btnMax.BorderColor = System.Drawing.Color.Black;
            this.pnlMenuAnimation.SetDecoration(this.btnMax, Guna.UI.Animation.DecorationType.None);
            this.btnMax.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMax.FocusedColor = System.Drawing.Color.Empty;
            this.btnMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Image = null;
            this.btnMax.ImageSize = new System.Drawing.Size(52, 52);
            this.btnMax.Location = new System.Drawing.Point(997, 13);
            this.btnMax.Name = "btnMax";
            this.btnMax.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(179)))), ((int)(((byte)(57)))));
            this.btnMax.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMax.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMax.OnHoverImage = null;
            this.btnMax.OnPressedColor = System.Drawing.Color.Black;
            this.btnMax.Size = new System.Drawing.Size(15, 15);
            this.btnMax.TabIndex = 11;
            this.btnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(84)))));
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.pnlMenuAnimation.SetDecoration(this.btnClose, Guna.UI.Animation.DecorationType.None);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = null;
            this.btnClose.ImageSize = new System.Drawing.Size(52, 52);
            this.btnClose.Location = new System.Drawing.Point(1018, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(62)))), ((int)(((byte)(52)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.TabIndex = 10;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnPin
            // 
            this.pnlMenuAnimation.SetDecoration(this.btnPin, Guna.UI.Animation.DecorationType.None);
            this.btnPin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPin.Image = ((System.Drawing.Image)(resources.GetObject("btnPin.Image")));
            this.btnPin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPin.Location = new System.Drawing.Point(7, 6);
            this.btnPin.Name = "btnPin";
            this.btnPin.OnHoverImage = null;
            this.btnPin.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnPin.Size = new System.Drawing.Size(20, 20);
            this.btnPin.TabIndex = 8;
            this.btnPin.Click += new System.EventHandler(this.BtnPin_Click);
            // 
            // btnUnpin
            // 
            this.pnlMenuAnimation.SetDecoration(this.btnUnpin, Guna.UI.Animation.DecorationType.None);
            this.btnUnpin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUnpin.Image = ((System.Drawing.Image)(resources.GetObject("btnUnpin.Image")));
            this.btnUnpin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUnpin.Location = new System.Drawing.Point(7, 6);
            this.btnUnpin.Name = "btnUnpin";
            this.btnUnpin.OnHoverImage = null;
            this.btnUnpin.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnUnpin.Size = new System.Drawing.Size(20, 20);
            this.btnUnpin.TabIndex = 7;
            this.btnUnpin.Click += new System.EventHandler(this.BtnUnpin_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.pnlMenuAnimation.SetDecoration(this.label3, Guna.UI.Animation.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label3.Location = new System.Drawing.Point(894, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "|";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.pnlMenuAnimation.SetDecoration(this.lblTime, Guna.UI.Animation.DecorationType.None);
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblTime.Location = new System.Drawing.Point(917, 51);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(42, 20);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.pnlMenuAnimation.SetDecoration(this.lblDate, Guna.UI.Animation.DecorationType.None);
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblDate.Location = new System.Drawing.Point(714, 52);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 20);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 683);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMenu);
            this.pnlMenuAnimation.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaTransition pnlMenuAnimation;
        private System.Windows.Forms.Panel pnlMenu;
        private Guna.UI.WinForms.GunaAdvenceButton btnUserAccount;
        private Guna.UI.WinForms.GunaAdvenceButton btnReports;
        private Guna.UI.WinForms.GunaAdvenceButton btnStudent;
        private Guna.UI.WinForms.GunaAdvenceButton btnBook;
        private Guna.UI.WinForms.GunaAdvenceButton btnDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaImageButton btnPin;
        private Guna.UI.WinForms.GunaImageButton btnUnpin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaCircleButton btnMin;
        private Guna.UI.WinForms.GunaCircleButton btnMax;
        private Guna.UI.WinForms.GunaCircleButton btnClose;
        public System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaAdvenceButton btnIssueBook;
        private Guna.UI.WinForms.GunaAdvenceButton btnHistory;
        private Guna.UI.WinForms.GunaAdvenceButton btnSettings;
        private System.Windows.Forms.PictureBox pictureBox2;
        public Guna.UI.WinForms.GunaLabel lblLibrarian;
        private Guna.UI.WinForms.GunaAdvenceButton btnLogout;
    }
}

