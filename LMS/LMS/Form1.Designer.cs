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
            Guna.UI.Animation.Animation animation2 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlMenuAnimation = new Guna.UI.WinForms.GunaTransition(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.gunaAdvenceButton7 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton3 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton4 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnBook = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.pnlMenuAnimation.SetDecoration(this.panel3, Guna.UI.Animation.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(190, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 497);
            this.panel3.TabIndex = 5;
            // 
            // pnlMenuAnimation
            // 
            this.pnlMenuAnimation.AnimationType = Guna.UI.Animation.AnimationType.HorizBlind;
            this.pnlMenuAnimation.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.pnlMenuAnimation.DefaultAnimation = animation2;
            this.pnlMenuAnimation.TimeStep = 0.01F;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.pnlMenu.Controls.Add(this.gunaAdvenceButton7);
            this.pnlMenu.Controls.Add(this.gunaAdvenceButton3);
            this.pnlMenu.Controls.Add(this.gunaAdvenceButton4);
            this.pnlMenu.Controls.Add(this.btnBook);
            this.pnlMenu.Controls.Add(this.gunaAdvenceButton1);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenuAnimation.SetDecoration(this.pnlMenu, Guna.UI.Animation.DecorationType.None);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(190, 567);
            this.pnlMenu.TabIndex = 0;
            // 
            // gunaAdvenceButton7
            // 
            this.gunaAdvenceButton7.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton7.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton7.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton7.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton7.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton7.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton7.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaAdvenceButton7.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton7.CheckedImage")));
            this.gunaAdvenceButton7.CheckedLineColor = System.Drawing.Color.DimGray;
            this.pnlMenuAnimation.SetDecoration(this.gunaAdvenceButton7, Guna.UI.Animation.DecorationType.None);
            this.gunaAdvenceButton7.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton7.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton7.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton7.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton7.Image")));
            this.gunaAdvenceButton7.ImageOffsetX = 5;
            this.gunaAdvenceButton7.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton7.Location = new System.Drawing.Point(0, 372);
            this.gunaAdvenceButton7.Name = "gunaAdvenceButton7";
            this.gunaAdvenceButton7.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.gunaAdvenceButton7.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton7.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton7.OnHoverImage = null;
            this.gunaAdvenceButton7.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton7.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton7.Size = new System.Drawing.Size(190, 42);
            this.gunaAdvenceButton7.TabIndex = 5;
            this.gunaAdvenceButton7.Text = "Settings";
            this.gunaAdvenceButton7.TextOffsetX = 10;
            // 
            // gunaAdvenceButton3
            // 
            this.gunaAdvenceButton3.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton3.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton3.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaAdvenceButton3.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.CheckedImage")));
            this.gunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray;
            this.pnlMenuAnimation.SetDecoration(this.gunaAdvenceButton3, Guna.UI.Animation.DecorationType.None);
            this.gunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton3.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.Image")));
            this.gunaAdvenceButton3.ImageOffsetX = 5;
            this.gunaAdvenceButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton3.Location = new System.Drawing.Point(0, 326);
            this.gunaAdvenceButton3.Name = "gunaAdvenceButton3";
            this.gunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.gunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.OnHoverImage = null;
            this.gunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.Size = new System.Drawing.Size(190, 42);
            this.gunaAdvenceButton3.TabIndex = 4;
            this.gunaAdvenceButton3.Text = "Reports";
            this.gunaAdvenceButton3.TextOffsetX = 10;
            // 
            // gunaAdvenceButton4
            // 
            this.gunaAdvenceButton4.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton4.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton4.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaAdvenceButton4.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton4.CheckedImage")));
            this.gunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.DimGray;
            this.pnlMenuAnimation.SetDecoration(this.gunaAdvenceButton4, Guna.UI.Animation.DecorationType.None);
            this.gunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton4.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton4.Image")));
            this.gunaAdvenceButton4.ImageOffsetX = 5;
            this.gunaAdvenceButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton4.Location = new System.Drawing.Point(0, 280);
            this.gunaAdvenceButton4.Name = "gunaAdvenceButton4";
            this.gunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.gunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.OnHoverImage = null;
            this.gunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.Size = new System.Drawing.Size(190, 42);
            this.gunaAdvenceButton4.TabIndex = 3;
            this.gunaAdvenceButton4.Text = "Users";
            this.gunaAdvenceButton4.TextOffsetX = 10;
            // 
            // btnBook
            // 
            this.btnBook.AnimationHoverSpeed = 0.07F;
            this.btnBook.AnimationSpeed = 0.03F;
            this.btnBook.BaseColor = System.Drawing.Color.Transparent;
            this.btnBook.BorderColor = System.Drawing.Color.Black;
            this.btnBook.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBook.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBook.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBook.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBook.CheckedImage")));
            this.btnBook.CheckedLineColor = System.Drawing.Color.DimGray;
            this.pnlMenuAnimation.SetDecoration(this.btnBook, Guna.UI.Animation.DecorationType.None);
            this.btnBook.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBook.FocusedColor = System.Drawing.Color.Empty;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Image = ((System.Drawing.Image)(resources.GetObject("btnBook.Image")));
            this.btnBook.ImageOffsetX = 5;
            this.btnBook.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBook.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBook.Location = new System.Drawing.Point(0, 234);
            this.btnBook.Name = "btnBook";
            this.btnBook.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnBook.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBook.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBook.OnHoverImage = null;
            this.btnBook.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBook.OnPressedColor = System.Drawing.Color.Black;
            this.btnBook.Size = new System.Drawing.Size(190, 42);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "Books";
            this.btnBook.TextOffsetX = 10;
            this.btnBook.Click += new System.EventHandler(this.BtnBook_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.pnlMenuAnimation.SetDecoration(this.gunaAdvenceButton1, Guna.UI.Animation.DecorationType.None);
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageOffsetX = 5;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(0, 188);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(190, 42);
            this.gunaAdvenceButton1.TabIndex = 1;
            this.gunaAdvenceButton1.Text = "Dashboard";
            this.gunaAdvenceButton1.TextOffsetX = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenuAnimation.SetDecoration(this.pictureBox1, Guna.UI.Animation.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
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
            this.panel2.Location = new System.Drawing.Point(190, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 70);
            this.panel2.TabIndex = 4;
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
            this.btnMin.Location = new System.Drawing.Point(646, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(4)))));
            this.btnMin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMin.OnHoverImage = null;
            this.btnMin.OnPressedColor = System.Drawing.Color.Black;
            this.btnMin.Size = new System.Drawing.Size(14, 14);
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
            this.btnMax.Location = new System.Drawing.Point(666, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(179)))), ((int)(((byte)(57)))));
            this.btnMax.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMax.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMax.OnHoverImage = null;
            this.btnMax.OnPressedColor = System.Drawing.Color.Black;
            this.btnMax.Size = new System.Drawing.Size(14, 14);
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
            this.btnClose.Location = new System.Drawing.Point(686, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(62)))), ((int)(((byte)(52)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(14, 14);
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
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label3.Location = new System.Drawing.Point(578, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "|";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.pnlMenuAnimation.SetDecoration(this.lblTime, Guna.UI.Animation.DecorationType.None);
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblTime.Location = new System.Drawing.Point(598, 42);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 17);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.pnlMenuAnimation.SetDecoration(this.lblDate, Guna.UI.Animation.DecorationType.None);
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblDate.Location = new System.Drawing.Point(426, 43);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 17);
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
            this.ClientSize = new System.Drawing.Size(902, 567);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMenu);
            this.pnlMenuAnimation.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaTransition pnlMenuAnimation;
        private System.Windows.Forms.Panel pnlMenu;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton7;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton3;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton4;
        private Guna.UI.WinForms.GunaAdvenceButton btnBook;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
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
    }
}

