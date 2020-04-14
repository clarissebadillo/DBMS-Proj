namespace LMS
{
    partial class frmSettings
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
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtFine = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtBorrowBooks = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtBorrowDays = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.tglWithOverdue = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.tglWithPending = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLinePanel1.Controls.Add(this.gunaControlBox1);
            this.gunaLinePanel1.Controls.Add(this.label1);
            this.gunaLinePanel1.LineBottom = 2;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(26, 1);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1086, 46);
            this.gunaLinePanel1.TabIndex = 1;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 10F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1053, 7);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(30, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(4, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "General Settings";
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(1083, 542);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv4);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdv1.InactiveTabColor = System.Drawing.Color.White;
            this.tabControlAdv1.ItemSize = new System.Drawing.Size(90, 30);
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Padding = new System.Drawing.Point(10, 3);
            this.tabControlAdv1.Size = new System.Drawing.Size(1083, 542);
            this.tabControlAdv1.TabGap = 3;
            this.tabControlAdv1.TabIndex = 2;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.White;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.tabControlAdv1.ThemeName = "TabRendererMetro";
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.gunaLabel6);
            this.tabPageAdv1.Controls.Add(this.txtFine);
            this.tabPageAdv1.Controls.Add(this.gunaLabel5);
            this.tabPageAdv1.Controls.Add(this.txtBorrowBooks);
            this.tabPageAdv1.Controls.Add(this.gunaLabel4);
            this.tabPageAdv1.Controls.Add(this.txtBorrowDays);
            this.tabPageAdv1.Controls.Add(this.btnUpdate);
            this.tabPageAdv1.Controls.Add(this.gunaLabel3);
            this.tabPageAdv1.Controls.Add(this.tglWithOverdue);
            this.tabPageAdv1.Controls.Add(this.gunaLabel2);
            this.tabPageAdv1.Controls.Add(this.tglWithPending);
            this.tabPageAdv1.Controls.Add(this.gunaLabel1);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(0, 29);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(1083, 513);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Library Setup";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(40, 224);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(120, 15);
            this.gunaLabel6.TabIndex = 18;
            this.gunaLabel6.Text = "Overdue Fine Per Day";
            // 
            // txtFine
            // 
            this.txtFine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFine.DefaultText = "";
            this.txtFine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFine.DisabledState.Parent = this.txtFine;
            this.txtFine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtFine.FocusedState.Parent = this.txtFine;
            this.txtFine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.txtFine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtFine.HoverState.Parent = this.txtFine;
            this.txtFine.Location = new System.Drawing.Point(43, 249);
            this.txtFine.Name = "txtFine";
            this.txtFine.PasswordChar = '\0';
            this.txtFine.PlaceholderText = "";
            this.txtFine.SelectedText = "";
            this.txtFine.ShadowDecoration.Parent = this.txtFine;
            this.txtFine.Size = new System.Drawing.Size(423, 36);
            this.txtFine.TabIndex = 17;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(40, 150);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(216, 15);
            this.gunaLabel5.TabIndex = 16;
            this.gunaLabel5.Text = "Maximum Allowed Books In Possession";
            // 
            // txtBorrowBooks
            // 
            this.txtBorrowBooks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBorrowBooks.DefaultText = "";
            this.txtBorrowBooks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBorrowBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBorrowBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBorrowBooks.DisabledState.Parent = this.txtBorrowBooks;
            this.txtBorrowBooks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBorrowBooks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtBorrowBooks.FocusedState.Parent = this.txtBorrowBooks;
            this.txtBorrowBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.txtBorrowBooks.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtBorrowBooks.HoverState.Parent = this.txtBorrowBooks;
            this.txtBorrowBooks.Location = new System.Drawing.Point(43, 175);
            this.txtBorrowBooks.Name = "txtBorrowBooks";
            this.txtBorrowBooks.PasswordChar = '\0';
            this.txtBorrowBooks.PlaceholderText = "";
            this.txtBorrowBooks.SelectedText = "";
            this.txtBorrowBooks.ShadowDecoration.Parent = this.txtBorrowBooks;
            this.txtBorrowBooks.Size = new System.Drawing.Size(423, 36);
            this.txtBorrowBooks.TabIndex = 15;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(40, 76);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(177, 15);
            this.gunaLabel4.TabIndex = 14;
            this.gunaLabel4.Text = "Maximum Allowed Borrow Days";
            // 
            // txtBorrowDays
            // 
            this.txtBorrowDays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBorrowDays.DefaultText = "";
            this.txtBorrowDays.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBorrowDays.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBorrowDays.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBorrowDays.DisabledState.Parent = this.txtBorrowDays;
            this.txtBorrowDays.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBorrowDays.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtBorrowDays.FocusedState.Parent = this.txtBorrowDays;
            this.txtBorrowDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.txtBorrowDays.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtBorrowDays.HoverState.Parent = this.txtBorrowDays;
            this.txtBorrowDays.Location = new System.Drawing.Point(43, 101);
            this.txtBorrowDays.Name = "txtBorrowDays";
            this.txtBorrowDays.PasswordChar = '\0';
            this.txtBorrowDays.PlaceholderText = "";
            this.txtBorrowDays.SelectedText = "";
            this.txtBorrowDays.ShadowDecoration.Parent = this.txtBorrowDays;
            this.txtBorrowDays.Size = new System.Drawing.Size(423, 36);
            this.txtBorrowDays.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BorderRadius = 17;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.55F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(43, 392);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(140, 37);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9.55F);
            this.gunaLabel3.Location = new System.Drawing.Point(87, 352);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(284, 17);
            this.gunaLabel3.TabIndex = 11;
            this.gunaLabel3.Text = "Allow book issue with overdue book in position";
            // 
            // tglWithOverdue
            // 
            this.tglWithOverdue.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.tglWithOverdue.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.tglWithOverdue.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tglWithOverdue.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tglWithOverdue.CheckedState.Parent = this.tglWithOverdue;
            this.tglWithOverdue.Location = new System.Drawing.Point(44, 350);
            this.tglWithOverdue.Name = "tglWithOverdue";
            this.tglWithOverdue.ShadowDecoration.Parent = this.tglWithOverdue;
            this.tglWithOverdue.Size = new System.Drawing.Size(38, 20);
            this.tglWithOverdue.TabIndex = 10;
            this.tglWithOverdue.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglWithOverdue.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglWithOverdue.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tglWithOverdue.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tglWithOverdue.UncheckedState.Parent = this.tglWithOverdue;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.55F);
            this.gunaLabel2.Location = new System.Drawing.Point(87, 309);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(245, 17);
            this.gunaLabel2.TabIndex = 9;
            this.gunaLabel2.Text = "Allow book issue with pending payments";
            // 
            // tglWithPending
            // 
            this.tglWithPending.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.tglWithPending.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.tglWithPending.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tglWithPending.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tglWithPending.CheckedState.Parent = this.tglWithPending;
            this.tglWithPending.Location = new System.Drawing.Point(43, 308);
            this.tglWithPending.Name = "tglWithPending";
            this.tglWithPending.ShadowDecoration.Parent = this.tglWithPending;
            this.tglWithPending.Size = new System.Drawing.Size(38, 20);
            this.tglWithPending.TabIndex = 8;
            this.tglWithPending.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglWithPending.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglWithPending.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tglWithPending.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tglWithPending.UncheckedState.Parent = this.tglWithPending;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11.75F);
            this.gunaLabel1.Location = new System.Drawing.Point(39, 37);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(152, 21);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "Library Maintenance";
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(0, 29);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(1083, 513);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "Programs";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv3.Location = new System.Drawing.Point(0, 29);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(1083, 513);
            this.tabPageAdv3.TabIndex = 3;
            this.tabPageAdv3.Text = "Programs";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.Image = null;
            this.tabPageAdv4.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv4.Location = new System.Drawing.Point(0, 29);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.ShowCloseButton = true;
            this.tabPageAdv4.Size = new System.Drawing.Size(1083, 513);
            this.tabPageAdv4.TabIndex = 4;
            this.tabPageAdv4.Text = "SMTP Setup";
            this.tabPageAdv4.ThemesEnabled = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlAdv1);
            this.panel1.Location = new System.Drawing.Point(26, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 542);
            this.panel1.TabIndex = 3;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1137, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tglWithPending;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tglWithOverdue;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox txtBorrowDays;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2TextBox txtFine;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtBorrowBooks;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
    }
}