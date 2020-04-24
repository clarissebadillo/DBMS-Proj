namespace LMS
{
    partial class frmNewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewAccount));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.lblLibrarian = new System.Windows.Forms.Label();
            this.btnShowPass2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnShowPass = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnHidePass2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnHidePass = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCreateAccount = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRetypePass = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.lblLibrarian);
            this.gunaLinePanel1.Controls.Add(this.btnShowPass2);
            this.gunaLinePanel1.Controls.Add(this.btnShowPass);
            this.gunaLinePanel1.Controls.Add(this.btnHidePass2);
            this.gunaLinePanel1.Controls.Add(this.btnHidePass);
            this.gunaLinePanel1.Controls.Add(this.lblPass);
            this.gunaLinePanel1.Controls.Add(this.txtEmail);
            this.gunaLinePanel1.Controls.Add(this.btnCreateAccount);
            this.gunaLinePanel1.Controls.Add(this.txtUsername);
            this.gunaLinePanel1.Controls.Add(this.gunaControlBox1);
            this.gunaLinePanel1.Controls.Add(this.txtFullName);
            this.gunaLinePanel1.Controls.Add(this.lblTitle);
            this.gunaLinePanel1.Controls.Add(this.txtPassword);
            this.gunaLinePanel1.Controls.Add(this.txtRetypePass);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 8;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(477, 400);
            this.gunaLinePanel1.TabIndex = 0;
            // 
            // lblLibrarian
            // 
            this.lblLibrarian.AutoSize = true;
            this.lblLibrarian.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrarian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblLibrarian.Location = new System.Drawing.Point(46, 352);
            this.lblLibrarian.Name = "lblLibrarian";
            this.lblLibrarian.Size = new System.Drawing.Size(0, 15);
            this.lblLibrarian.TabIndex = 80;
            this.lblLibrarian.Visible = false;
            // 
            // btnShowPass2
            // 
            this.btnShowPass2.CheckedState.Parent = this.btnShowPass2;
            this.btnShowPass2.HoverState.Parent = this.btnShowPass2;
            this.btnShowPass2.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPass2.Image")));
            this.btnShowPass2.Location = new System.Drawing.Point(404, 289);
            this.btnShowPass2.Name = "btnShowPass2";
            this.btnShowPass2.PressedState.Parent = this.btnShowPass2;
            this.btnShowPass2.Size = new System.Drawing.Size(23, 23);
            this.btnShowPass2.TabIndex = 77;
            this.btnShowPass2.Click += new System.EventHandler(this.BtnShowPass2_Click);
            // 
            // btnShowPass
            // 
            this.btnShowPass.CheckedState.Parent = this.btnShowPass;
            this.btnShowPass.HoverState.Parent = this.btnShowPass;
            this.btnShowPass.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPass.Image")));
            this.btnShowPass.Location = new System.Drawing.Point(404, 242);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.PressedState.Parent = this.btnShowPass;
            this.btnShowPass.Size = new System.Drawing.Size(23, 23);
            this.btnShowPass.TabIndex = 74;
            this.btnShowPass.Click += new System.EventHandler(this.BtnShowPass_Click);
            // 
            // btnHidePass2
            // 
            this.btnHidePass2.CheckedState.Parent = this.btnHidePass2;
            this.btnHidePass2.HoverState.Parent = this.btnHidePass2;
            this.btnHidePass2.Image = ((System.Drawing.Image)(resources.GetObject("btnHidePass2.Image")));
            this.btnHidePass2.Location = new System.Drawing.Point(404, 289);
            this.btnHidePass2.Name = "btnHidePass2";
            this.btnHidePass2.PressedState.Parent = this.btnHidePass2;
            this.btnHidePass2.Size = new System.Drawing.Size(23, 23);
            this.btnHidePass2.TabIndex = 76;
            this.btnHidePass2.Visible = false;
            this.btnHidePass2.Click += new System.EventHandler(this.BtnHidePass2_Click);
            // 
            // btnHidePass
            // 
            this.btnHidePass.CheckedState.Parent = this.btnHidePass;
            this.btnHidePass.HoverState.Parent = this.btnHidePass;
            this.btnHidePass.Image = ((System.Drawing.Image)(resources.GetObject("btnHidePass.Image")));
            this.btnHidePass.Location = new System.Drawing.Point(404, 242);
            this.btnHidePass.Name = "btnHidePass";
            this.btnHidePass.PressedState.Parent = this.btnHidePass;
            this.btnHidePass.Size = new System.Drawing.Size(23, 23);
            this.btnHidePass.TabIndex = 75;
            this.btnHidePass.Visible = false;
            this.btnHidePass.Click += new System.EventHandler(this.BtnHidePass_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblPass.Location = new System.Drawing.Point(42, 325);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(143, 15);
            this.lblPass.TabIndex = 73;
            this.lblPass.Text = "*Password did not match!";
            this.lblPass.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(40, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(396, 36);
            this.txtEmail.TabIndex = 2;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.AnimationHoverSpeed = 0.07F;
            this.btnCreateAccount.AnimationSpeed = 0.03F;
            this.btnCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateAccount.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnCreateAccount.BorderColor = System.Drawing.Color.Black;
            this.btnCreateAccount.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCreateAccount.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCreateAccount.CheckedForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnCreateAccount.CheckedImage")));
            this.btnCreateAccount.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCreateAccount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCreateAccount.FocusedColor = System.Drawing.Color.Empty;
            this.btnCreateAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Image = null;
            this.btnCreateAccount.ImageSize = new System.Drawing.Size(22, 22);
            this.btnCreateAccount.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCreateAccount.Location = new System.Drawing.Point(284, 332);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.btnCreateAccount.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCreateAccount.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.OnHoverImage = null;
            this.btnCreateAccount.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCreateAccount.OnPressedColor = System.Drawing.Color.Black;
            this.btnCreateAccount.Radius = 7;
            this.btnCreateAccount.Size = new System.Drawing.Size(152, 35);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(40, 192);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(396, 36);
            this.txtUsername.TabIndex = 3;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(438, 8);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(38, 29);
            this.gunaControlBox1.TabIndex = 37;
            // 
            // txtFullName
            // 
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.DisabledState.Parent = this.txtFullName;
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtFullName.FocusedState.Parent = this.txtFullName;
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtFullName.HoverState.Parent = this.txtFullName;
            this.txtFullName.Location = new System.Drawing.Point(40, 104);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderText = "Full Name";
            this.txtFullName.SelectedText = "";
            this.txtFullName.ShadowDecoration.Parent = this.txtFullName;
            this.txtFullName.Size = new System.Drawing.Size(396, 36);
            this.txtFullName.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.lblTitle.Location = new System.Drawing.Point(42, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(278, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Create New Account";
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(40, 237);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(396, 36);
            this.txtPassword.TabIndex = 4;
            // 
            // txtRetypePass
            // 
            this.txtRetypePass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRetypePass.DefaultText = "";
            this.txtRetypePass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRetypePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRetypePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRetypePass.DisabledState.Parent = this.txtRetypePass;
            this.txtRetypePass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRetypePass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtRetypePass.FocusedState.Parent = this.txtRetypePass;
            this.txtRetypePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.txtRetypePass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtRetypePass.HoverState.Parent = this.txtRetypePass;
            this.txtRetypePass.Location = new System.Drawing.Point(40, 283);
            this.txtRetypePass.Name = "txtRetypePass";
            this.txtRetypePass.PasswordChar = '\0';
            this.txtRetypePass.PlaceholderText = "Re-type Password";
            this.txtRetypePass.SelectedText = "";
            this.txtRetypePass.ShadowDecoration.Parent = this.txtRetypePass;
            this.txtRetypePass.Size = new System.Drawing.Size(396, 36);
            this.txtRetypePass.TabIndex = 5;
            // 
            // frmNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(477, 400);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewAccount";
            this.Load += new System.EventHandler(this.FrmNewAccount_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        public System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI.WinForms.GunaAdvenceButton btnCreateAccount;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lblPass;
        private Guna.UI2.WinForms.Guna2ImageButton btnShowPass2;
        private Guna.UI2.WinForms.Guna2ImageButton btnShowPass;
        private Guna.UI2.WinForms.Guna2ImageButton btnHidePass2;
        private Guna.UI2.WinForms.Guna2ImageButton btnHidePass;
        private Guna.UI2.WinForms.Guna2TextBox txtRetypePass;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        public System.Windows.Forms.Label lblLibrarian;
    }
}