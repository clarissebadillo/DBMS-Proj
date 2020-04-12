namespace LMS
{
    partial class frmChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePass));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnShowPass3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnHidePass3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOldPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnShowPass2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnShowPass = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnHidePass2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnHidePass = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangePass = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtRetypePass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.btnShowPass3);
            this.gunaLinePanel1.Controls.Add(this.btnHidePass3);
            this.gunaLinePanel1.Controls.Add(this.lblID);
            this.gunaLinePanel1.Controls.Add(this.lblPassword);
            this.gunaLinePanel1.Controls.Add(this.label3);
            this.gunaLinePanel1.Controls.Add(this.label2);
            this.gunaLinePanel1.Controls.Add(this.txtOldPass);
            this.gunaLinePanel1.Controls.Add(this.btnShowPass2);
            this.gunaLinePanel1.Controls.Add(this.btnShowPass);
            this.gunaLinePanel1.Controls.Add(this.btnHidePass2);
            this.gunaLinePanel1.Controls.Add(this.btnHidePass);
            this.gunaLinePanel1.Controls.Add(this.lblPass);
            this.gunaLinePanel1.Controls.Add(this.label1);
            this.gunaLinePanel1.Controls.Add(this.btnChangePass);
            this.gunaLinePanel1.Controls.Add(this.gunaControlBox1);
            this.gunaLinePanel1.Controls.Add(this.lblTitle);
            this.gunaLinePanel1.Controls.Add(this.txtRetypePass);
            this.gunaLinePanel1.Controls.Add(this.txtNewPass);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 8;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(402, 392);
            this.gunaLinePanel1.TabIndex = 1;
            // 
            // btnShowPass3
            // 
            this.btnShowPass3.CheckedState.Parent = this.btnShowPass3;
            this.btnShowPass3.HoverState.Parent = this.btnShowPass3;
            this.btnShowPass3.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPass3.Image")));
            this.btnShowPass3.Location = new System.Drawing.Point(315, 130);
            this.btnShowPass3.Name = "btnShowPass3";
            this.btnShowPass3.PressedState.Parent = this.btnShowPass3;
            this.btnShowPass3.Size = new System.Drawing.Size(23, 23);
            this.btnShowPass3.TabIndex = 86;
            this.btnShowPass3.Click += new System.EventHandler(this.BtnShowPass3_Click);
            // 
            // btnHidePass3
            // 
            this.btnHidePass3.CheckedState.Parent = this.btnHidePass3;
            this.btnHidePass3.HoverState.Parent = this.btnHidePass3;
            this.btnHidePass3.Image = ((System.Drawing.Image)(resources.GetObject("btnHidePass3.Image")));
            this.btnHidePass3.Location = new System.Drawing.Point(315, 130);
            this.btnHidePass3.Name = "btnHidePass3";
            this.btnHidePass3.PressedState.Parent = this.btnHidePass3;
            this.btnHidePass3.Size = new System.Drawing.Size(23, 23);
            this.btnHidePass3.TabIndex = 85;
            this.btnHidePass3.Visible = false;
            this.btnHidePass3.Click += new System.EventHandler(this.BtnHidePass3_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.lblID.Location = new System.Drawing.Point(71, 366);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 17);
            this.lblID.TabIndex = 84;
            this.lblID.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.lblPassword.Location = new System.Drawing.Point(10, 366);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(0, 17);
            this.lblPassword.TabIndex = 83;
            this.lblPassword.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.label3.Location = new System.Drawing.Point(51, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 81;
            this.label3.Text = "Re-type New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(51, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 79;
            this.label2.Text = "New Password";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldPass.DefaultText = "";
            this.txtOldPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOldPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOldPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldPass.DisabledState.Parent = this.txtOldPass;
            this.txtOldPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtOldPass.FocusedState.Parent = this.txtOldPass;
            this.txtOldPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.txtOldPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtOldPass.HoverState.Parent = this.txtOldPass;
            this.txtOldPass.Location = new System.Drawing.Point(50, 124);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '\0';
            this.txtOldPass.PlaceholderText = "";
            this.txtOldPass.SelectedText = "";
            this.txtOldPass.ShadowDecoration.Parent = this.txtOldPass;
            this.txtOldPass.Size = new System.Drawing.Size(295, 36);
            this.txtOldPass.TabIndex = 78;
            // 
            // btnShowPass2
            // 
            this.btnShowPass2.CheckedState.Parent = this.btnShowPass2;
            this.btnShowPass2.HoverState.Parent = this.btnShowPass2;
            this.btnShowPass2.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPass2.Image")));
            this.btnShowPass2.Location = new System.Drawing.Point(315, 258);
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
            this.btnShowPass.Location = new System.Drawing.Point(315, 194);
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
            this.btnHidePass2.Location = new System.Drawing.Point(315, 258);
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
            this.btnHidePass.Location = new System.Drawing.Point(315, 194);
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
            this.lblPass.Location = new System.Drawing.Point(51, 294);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(138, 15);
            this.lblPass.TabIndex = 73;
            this.lblPass.Text = "Password did not match!";
            this.lblPass.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(51, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "Enter Old Password";
            // 
            // btnChangePass
            // 
            this.btnChangePass.AnimationHoverSpeed = 0.07F;
            this.btnChangePass.AnimationSpeed = 0.03F;
            this.btnChangePass.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePass.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnChangePass.BorderColor = System.Drawing.Color.Black;
            this.btnChangePass.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnChangePass.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnChangePass.CheckedForeColor = System.Drawing.Color.White;
            this.btnChangePass.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnChangePass.CheckedImage")));
            this.btnChangePass.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnChangePass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChangePass.FocusedColor = System.Drawing.Color.Empty;
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Image = null;
            this.btnChangePass.ImageSize = new System.Drawing.Size(22, 22);
            this.btnChangePass.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnChangePass.Location = new System.Drawing.Point(193, 304);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.btnChangePass.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChangePass.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChangePass.OnHoverImage = null;
            this.btnChangePass.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnChangePass.OnPressedColor = System.Drawing.Color.Black;
            this.btnChangePass.Radius = 7;
            this.btnChangePass.Size = new System.Drawing.Size(152, 35);
            this.btnChangePass.TabIndex = 6;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChangePass.Click += new System.EventHandler(this.BtnChangePass_Click);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(363, 8);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(38, 29);
            this.gunaControlBox1.TabIndex = 37;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.lblTitle.Location = new System.Drawing.Point(80, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Change Password";
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
            this.txtRetypePass.Location = new System.Drawing.Point(50, 252);
            this.txtRetypePass.Name = "txtRetypePass";
            this.txtRetypePass.PasswordChar = '\0';
            this.txtRetypePass.PlaceholderText = "";
            this.txtRetypePass.SelectedText = "";
            this.txtRetypePass.ShadowDecoration.Parent = this.txtRetypePass;
            this.txtRetypePass.Size = new System.Drawing.Size(295, 36);
            this.txtRetypePass.TabIndex = 82;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.DefaultText = "";
            this.txtNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.DisabledState.Parent = this.txtNewPass;
            this.txtNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtNewPass.FocusedState.Parent = this.txtNewPass;
            this.txtNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.txtNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtNewPass.HoverState.Parent = this.txtNewPass;
            this.txtNewPass.Location = new System.Drawing.Point(50, 188);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '\0';
            this.txtNewPass.PlaceholderText = "";
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.ShadowDecoration.Parent = this.txtNewPass;
            this.txtNewPass.Size = new System.Drawing.Size(295, 36);
            this.txtNewPass.TabIndex = 80;
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 392);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePass";
            this.Load += new System.EventHandler(this.FrmChangePass_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtOldPass;
        private Guna.UI2.WinForms.Guna2ImageButton btnShowPass2;
        private Guna.UI2.WinForms.Guna2ImageButton btnShowPass;
        private Guna.UI2.WinForms.Guna2ImageButton btnHidePass2;
        private Guna.UI2.WinForms.Guna2ImageButton btnHidePass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton btnChangePass;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        public System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtRetypePass;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2ImageButton btnShowPass3;
        private Guna.UI2.WinForms.Guna2ImageButton btnHidePass3;
    }
}