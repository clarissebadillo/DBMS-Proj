namespace LMS
{
    partial class frmAddEditBook
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
            this.lblID = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.gunaLinePanel3 = new Guna.UI.WinForms.GunaLinePanel();
            this.cboMediaType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cboGenre = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cboSubject = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI.WinForms.GunaTextBox();
            this.txtYear = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPublisher = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAuthor = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLanguage = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.lblLibrarian = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCopies = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtISBN = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLinePanel4 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.popupNotifier = new Tulpep.NotificationWindow.PopupNotifier();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaLinePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboMediaType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubject)).BeginInit();
            this.gunaLinePanel2.SuspendLayout();
            this.gunaLinePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.lblID);
            this.gunaLinePanel1.Controls.Add(this.btnUpdate);
            this.gunaLinePanel1.Controls.Add(this.btnSave);
            this.gunaLinePanel1.Controls.Add(this.gunaLinePanel3);
            this.gunaLinePanel1.Controls.Add(this.panel1);
            this.gunaLinePanel1.Controls.Add(this.gunaLinePanel2);
            this.gunaLinePanel1.Controls.Add(this.gunaLinePanel4);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(562, 552);
            this.gunaLinePanel1.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(334, 539);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 33;
            this.lblID.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = null;
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.Location = new System.Drawing.Point(353, 482);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 7;
            this.btnUpdate.Size = new System.Drawing.Size(97, 29);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = null;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(453, 482);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 7;
            this.btnSave.Size = new System.Drawing.Size(97, 29);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // gunaLinePanel3
            // 
            this.gunaLinePanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLinePanel3.Controls.Add(this.cboMediaType);
            this.gunaLinePanel3.Controls.Add(this.cboGenre);
            this.gunaLinePanel3.Controls.Add(this.cboSubject);
            this.gunaLinePanel3.Controls.Add(this.label1);
            this.gunaLinePanel3.Controls.Add(this.label11);
            this.gunaLinePanel3.Controls.Add(this.txtPrice);
            this.gunaLinePanel3.Controls.Add(this.txtYear);
            this.gunaLinePanel3.Controls.Add(this.label8);
            this.gunaLinePanel3.Controls.Add(this.txtPublisher);
            this.gunaLinePanel3.Controls.Add(this.label9);
            this.gunaLinePanel3.Controls.Add(this.txtAuthor);
            this.gunaLinePanel3.Controls.Add(this.label6);
            this.gunaLinePanel3.Controls.Add(this.txtLanguage);
            this.gunaLinePanel3.Controls.Add(this.label7);
            this.gunaLinePanel3.Controls.Add(this.label5);
            this.gunaLinePanel3.Controls.Add(this.label4);
            this.gunaLinePanel3.LineBottom = 2;
            this.gunaLinePanel3.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel3.Location = new System.Drawing.Point(12, 226);
            this.gunaLinePanel3.Name = "gunaLinePanel3";
            this.gunaLinePanel3.Size = new System.Drawing.Size(538, 237);
            this.gunaLinePanel3.TabIndex = 30;
            // 
            // cboMediaType
            // 
            this.cboMediaType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMediaType.BackColor = System.Drawing.Color.Gainsboro;
            this.cboMediaType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cboMediaType.Location = new System.Drawing.Point(22, 87);
            this.cboMediaType.Name = "cboMediaType";
            this.cboMediaType.Size = new System.Drawing.Size(234, 26);
            this.cboMediaType.Style.DropDownButtonStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.cboMediaType.Style.DropDownButtonStyle.FocusedBackColor = System.Drawing.Color.Gainsboro;
            this.cboMediaType.Style.DropDownButtonStyle.HoverBackColor = System.Drawing.Color.Gainsboro;
            this.cboMediaType.Style.EditorStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.cboMediaType.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.cboMediaType.Style.EditorStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.cboMediaType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMediaType.TabIndex = 6;
            // 
            // cboGenre
            // 
            this.cboGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboGenre.BackColor = System.Drawing.Color.Gainsboro;
            this.cboGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cboGenre.Location = new System.Drawing.Point(284, 36);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(234, 26);
            this.cboGenre.Style.DropDownButtonStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.cboGenre.Style.DropDownButtonStyle.FocusedBackColor = System.Drawing.Color.Gainsboro;
            this.cboGenre.Style.DropDownButtonStyle.HoverBackColor = System.Drawing.Color.Gainsboro;
            this.cboGenre.Style.EditorStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.cboGenre.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.cboGenre.Style.EditorStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.cboGenre.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboGenre.TabIndex = 5;
            // 
            // cboSubject
            // 
            this.cboSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSubject.BackColor = System.Drawing.Color.Gainsboro;
            this.cboSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cboSubject.Location = new System.Drawing.Point(22, 36);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(234, 26);
            this.cboSubject.Style.DropDownButtonStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.cboSubject.Style.DropDownButtonStyle.FocusedBackColor = System.Drawing.Color.Gainsboro;
            this.cboSubject.Style.DropDownButtonStyle.HoverBackColor = System.Drawing.Color.Gainsboro;
            this.cboSubject.Style.EditorStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.cboSubject.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.cboSubject.Style.EditorStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.cboSubject.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSubject.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(284, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Published year";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label11.Location = new System.Drawing.Point(22, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Market Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrice.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtPrice.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtPrice.BorderSize = 1;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.txtPrice.Location = new System.Drawing.Point(22, 190);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.Size = new System.Drawing.Size(234, 25);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrice_KeyPress);
            // 
            // txtYear
            // 
            this.txtYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtYear.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtYear.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtYear.BorderSize = 1;
            this.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYear.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtYear.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtYear.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.txtYear.Location = new System.Drawing.Point(284, 190);
            this.txtYear.Name = "txtYear";
            this.txtYear.PasswordChar = '\0';
            this.txtYear.Size = new System.Drawing.Size(234, 25);
            this.txtYear.TabIndex = 11;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtYear_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label8.Location = new System.Drawing.Point(284, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Publisher";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPublisher.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtPublisher.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtPublisher.BorderSize = 1;
            this.txtPublisher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPublisher.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtPublisher.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtPublisher.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPublisher.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.txtPublisher.Location = new System.Drawing.Point(284, 138);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.PasswordChar = '\0';
            this.txtPublisher.Size = new System.Drawing.Size(234, 25);
            this.txtPublisher.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label9.Location = new System.Drawing.Point(21, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAuthor.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtAuthor.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtAuthor.BorderSize = 1;
            this.txtAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthor.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtAuthor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtAuthor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.txtAuthor.Location = new System.Drawing.Point(21, 138);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PasswordChar = '\0';
            this.txtAuthor.Size = new System.Drawing.Size(234, 25);
            this.txtAuthor.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label6.Location = new System.Drawing.Point(284, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Language";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLanguage.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtLanguage.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtLanguage.BorderSize = 1;
            this.txtLanguage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLanguage.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtLanguage.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtLanguage.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLanguage.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.txtLanguage.Location = new System.Drawing.Point(284, 87);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.PasswordChar = '\0';
            this.txtLanguage.Size = new System.Drawing.Size(234, 25);
            this.txtLanguage.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label7.Location = new System.Drawing.Point(21, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Media Type";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label5.Location = new System.Drawing.Point(284, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Genre";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label4.Location = new System.Drawing.Point(22, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Subject";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 7);
            this.panel1.TabIndex = 26;
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLinePanel2.Controls.Add(this.lblLibrarian);
            this.gunaLinePanel2.Controls.Add(this.label10);
            this.gunaLinePanel2.Controls.Add(this.txtCopies);
            this.gunaLinePanel2.Controls.Add(this.label3);
            this.gunaLinePanel2.Controls.Add(this.txtTitle);
            this.gunaLinePanel2.Controls.Add(this.label2);
            this.gunaLinePanel2.Controls.Add(this.txtISBN);
            this.gunaLinePanel2.LineBottom = 2;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(12, 68);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(538, 153);
            this.gunaLinePanel2.TabIndex = 28;
            // 
            // lblLibrarian
            // 
            this.lblLibrarian.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLibrarian.AutoSize = true;
            this.lblLibrarian.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrarian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblLibrarian.Location = new System.Drawing.Point(254, 36);
            this.lblLibrarian.Name = "lblLibrarian";
            this.lblLibrarian.Size = new System.Drawing.Size(0, 13);
            this.lblLibrarian.TabIndex = 4;
            this.lblLibrarian.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label10.Location = new System.Drawing.Point(444, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "No of Copies";
            // 
            // txtCopies
            // 
            this.txtCopies.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCopies.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtCopies.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtCopies.BorderSize = 1;
            this.txtCopies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCopies.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtCopies.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtCopies.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCopies.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtCopies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.txtCopies.Location = new System.Drawing.Point(444, 103);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.PasswordChar = '\0';
            this.txtCopies.Size = new System.Drawing.Size(74, 26);
            this.txtCopies.TabIndex = 3;
            this.txtCopies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCopies_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Book Name / Title *";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTitle.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtTitle.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtTitle.BorderSize = 1;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtTitle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtTitle.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.txtTitle.Location = new System.Drawing.Point(17, 103);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.Size = new System.Drawing.Size(411, 26);
            this.txtTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Serial Number / ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtISBN.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtISBN.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtISBN.BorderSize = 1;
            this.txtISBN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtISBN.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtISBN.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtISBN.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.txtISBN.Location = new System.Drawing.Point(17, 52);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.PasswordChar = '\0';
            this.txtISBN.Size = new System.Drawing.Size(501, 26);
            this.txtISBN.TabIndex = 1;
            // 
            // gunaLinePanel4
            // 
            this.gunaLinePanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLinePanel4.Controls.Add(this.btnBack);
            this.gunaLinePanel4.Controls.Add(this.lblTitle);
            this.gunaLinePanel4.LineBottom = 2;
            this.gunaLinePanel4.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel4.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel4.Location = new System.Drawing.Point(12, 16);
            this.gunaLinePanel4.Name = "gunaLinePanel4";
            this.gunaLinePanel4.Size = new System.Drawing.Size(538, 46);
            this.gunaLinePanel4.TabIndex = 27;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::LMS.Properties.Resources.left_30px;
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new System.Drawing.Point(17, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 2;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 10;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblTitle.Location = new System.Drawing.Point(48, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add Book Details";
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
            // frmAddEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 552);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditBook";
            this.Load += new System.EventHandler(this.FrmAddEditBook_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaLinePanel3.ResumeLayout(false);
            this.gunaLinePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboMediaType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubject)).EndInit();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            this.gunaLinePanel4.ResumeLayout(false);
            this.gunaLinePanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        public Guna.UI.WinForms.GunaButton btnSave;
        public Guna.UI.WinForms.GunaLinePanel gunaLinePanel3;
        public System.Windows.Forms.Label label11;
        public Guna.UI.WinForms.GunaTextBox txtPrice;
        public System.Windows.Forms.Label label8;
        public Guna.UI.WinForms.GunaTextBox txtPublisher;
        public System.Windows.Forms.Label label9;
        public Guna.UI.WinForms.GunaTextBox txtAuthor;
        public System.Windows.Forms.Label label6;
        public Guna.UI.WinForms.GunaTextBox txtLanguage;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel panel1;
        public Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        public System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaTextBox txtTitle;
        public System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaTextBox txtISBN;
        public Guna.UI.WinForms.GunaLinePanel gunaLinePanel4;
        public Bunifu.Framework.UI.BunifuImageButton btnBack;
        public System.Windows.Forms.Label lblTitle;
        public Guna.UI.WinForms.GunaButton btnUpdate;
        public System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaTextBox txtYear;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label label10;
        public Guna.UI.WinForms.GunaTextBox txtCopies;
        private Tulpep.NotificationWindow.PopupNotifier popupNotifier;
        public System.Windows.Forms.Label lblLibrarian;
        public Syncfusion.WinForms.ListView.SfComboBox cboSubject;
        public Syncfusion.WinForms.ListView.SfComboBox cboGenre;
        public Syncfusion.WinForms.ListView.SfComboBox cboMediaType;
    }
}