namespace LMS
{
    partial class frmIssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueBook));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.popupNotifier = new Tulpep.NotificationWindow.PopupNotifier();
            this.designTimeTabTypeLoader = new Syncfusion.Reflection.TypeLoader(this.components);
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.dtDueDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtIssueDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnProccessIssue = new Guna.UI.WinForms.GunaButton();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboBooks = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSearchStud = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.gunaLinePanel3 = new Guna.UI.WinForms.GunaLinePanel();
            this.lblBookID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.lblStudID = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblStudNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studImage = new Guna.UI.WinForms.GunaPictureBox();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchStud)).BeginInit();
            this.gunaLinePanel3.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLinePanel1.Controls.Add(this.label1);
            this.gunaLinePanel1.LineBottom = 2;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(18, 11);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(772, 37);
            this.gunaLinePanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(10, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issue Book";
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
            // designTimeTabTypeLoader
            // 
            this.designTimeTabTypeLoader.InvokeMemberName = "TabStyleName";
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(807, 515);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabControlAdv1.BorderVisible = true;
            this.tabControlAdv1.BorderWidth = 10;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.InactiveTabColor = System.Drawing.Color.Gainsboro;
            this.tabControlAdv1.ItemSize = new System.Drawing.Size(90, 30);
            this.tabControlAdv1.Location = new System.Drawing.Point(12, 12);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(807, 515);
            this.tabControlAdv1.TabIndex = 65;
            this.tabControlAdv1.ThemeName = "TabRendererOffice2019";
            this.tabControlAdv1.ThemesEnabled = true;
            this.tabControlAdv1.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.dtDueDate);
            this.tabPageAdv1.Controls.Add(this.gunaLinePanel1);
            this.tabPageAdv1.Controls.Add(this.dtIssueDate);
            this.tabPageAdv1.Controls.Add(this.btnProccessIssue);
            this.tabPageAdv1.Controls.Add(this.label18);
            this.tabPageAdv1.Controls.Add(this.label17);
            this.tabPageAdv1.Controls.Add(this.label16);
            this.tabPageAdv1.Controls.Add(this.cboBooks);
            this.tabPageAdv1.Controls.Add(this.pictureBox1);
            this.tabPageAdv1.Controls.Add(this.label15);
            this.tabPageAdv1.Controls.Add(this.txtSearchStud);
            this.tabPageAdv1.Controls.Add(this.gunaLinePanel3);
            this.tabPageAdv1.Controls.Add(this.gunaLinePanel2);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(2, 34);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(803, 479);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Issue Book";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // dtDueDate
            // 
            this.dtDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDueDate.BackColor = System.Drawing.Color.Gainsboro;
            this.dtDueDate.BaseColor = System.Drawing.Color.Gainsboro;
            this.dtDueDate.BorderColor = System.Drawing.Color.Gainsboro;
            this.dtDueDate.BorderSize = 1;
            this.dtDueDate.CustomFormat = "MM/dd/yyyy";
            this.dtDueDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtDueDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.dtDueDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtDueDate.ForeColor = System.Drawing.Color.Black;
            this.dtDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDueDate.Location = new System.Drawing.Point(558, 394);
            this.dtDueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.dtDueDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.dtDueDate.OnHoverForeColor = System.Drawing.Color.Black;
            this.dtDueDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtDueDate.Size = new System.Drawing.Size(232, 30);
            this.dtDueDate.TabIndex = 76;
            this.dtDueDate.Text = "03/23/2020";
            this.dtDueDate.Value = new System.DateTime(2020, 3, 23, 17, 47, 21, 456);
            // 
            // dtIssueDate
            // 
            this.dtIssueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtIssueDate.BackColor = System.Drawing.Color.Gainsboro;
            this.dtIssueDate.BaseColor = System.Drawing.Color.Gainsboro;
            this.dtIssueDate.BorderColor = System.Drawing.Color.Gainsboro;
            this.dtIssueDate.BorderSize = 1;
            this.dtIssueDate.CustomFormat = "MM/dd/yyyy";
            this.dtIssueDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtIssueDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.dtIssueDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtIssueDate.ForeColor = System.Drawing.Color.Black;
            this.dtIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtIssueDate.Location = new System.Drawing.Point(558, 341);
            this.dtIssueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtIssueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtIssueDate.Name = "dtIssueDate";
            this.dtIssueDate.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.dtIssueDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.dtIssueDate.OnHoverForeColor = System.Drawing.Color.Black;
            this.dtIssueDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtIssueDate.Size = new System.Drawing.Size(232, 30);
            this.dtIssueDate.TabIndex = 75;
            this.dtIssueDate.Text = "03/23/2020";
            this.dtIssueDate.Value = new System.DateTime(2020, 3, 23, 0, 0, 0, 0);
            // 
            // btnProccessIssue
            // 
            this.btnProccessIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProccessIssue.AnimationHoverSpeed = 0.07F;
            this.btnProccessIssue.AnimationSpeed = 0.03F;
            this.btnProccessIssue.BackColor = System.Drawing.Color.Transparent;
            this.btnProccessIssue.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnProccessIssue.BorderColor = System.Drawing.Color.Black;
            this.btnProccessIssue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProccessIssue.FocusedColor = System.Drawing.Color.Empty;
            this.btnProccessIssue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProccessIssue.ForeColor = System.Drawing.Color.White;
            this.btnProccessIssue.Image = null;
            this.btnProccessIssue.ImageSize = new System.Drawing.Size(20, 20);
            this.btnProccessIssue.Location = new System.Drawing.Point(672, 438);
            this.btnProccessIssue.Name = "btnProccessIssue";
            this.btnProccessIssue.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnProccessIssue.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProccessIssue.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProccessIssue.OnHoverImage = null;
            this.btnProccessIssue.OnPressedColor = System.Drawing.Color.Black;
            this.btnProccessIssue.Radius = 15;
            this.btnProccessIssue.Size = new System.Drawing.Size(118, 32);
            this.btnProccessIssue.TabIndex = 74;
            this.btnProccessIssue.Text = "Process Issue";
            this.btnProccessIssue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(555, 378);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 73;
            this.label18.Text = "Due Date";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(555, 325);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 72;
            this.label17.Text = "Issue Date";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(472, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 71;
            this.label16.Text = "Enter Book Title";
            // 
            // cboBooks
            // 
            this.cboBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBooks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboBooks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboBooks.FormattingEnabled = true;
            this.cboBooks.Location = new System.Drawing.Point(471, 83);
            this.cboBooks.Name = "cboBooks";
            this.cboBooks.Size = new System.Drawing.Size(265, 21);
            this.cboBooks.TabIndex = 70;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 13);
            this.label15.TabIndex = 68;
            this.label15.Text = "Enter Student Number";
            // 
            // txtSearchStud
            // 
            this.txtSearchStud.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearchStud.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchStud.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSearchStud.BeforeTouchSize = new System.Drawing.Size(263, 20);
            this.txtSearchStud.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSearchStud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchStud.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSearchStud.Location = new System.Drawing.Point(18, 83);
            this.txtSearchStud.Metrocolor = System.Drawing.Color.Gainsboro;
            this.txtSearchStud.Name = "txtSearchStud";
            this.txtSearchStud.Size = new System.Drawing.Size(263, 20);
            this.txtSearchStud.TabIndex = 67;
            this.txtSearchStud.UseBorderColorOnFocus = true;
            // 
            // gunaLinePanel3
            // 
            this.gunaLinePanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLinePanel3.Controls.Add(this.lblBookID);
            this.gunaLinePanel3.Controls.Add(this.label14);
            this.gunaLinePanel3.Controls.Add(this.lblAuthor);
            this.gunaLinePanel3.Controls.Add(this.lblSubject);
            this.gunaLinePanel3.Controls.Add(this.lblISBN);
            this.gunaLinePanel3.Controls.Add(this.lblTitle);
            this.gunaLinePanel3.Controls.Add(this.label10);
            this.gunaLinePanel3.Controls.Add(this.label11);
            this.gunaLinePanel3.Controls.Add(this.label12);
            this.gunaLinePanel3.Controls.Add(this.label13);
            this.gunaLinePanel3.LineBottom = 1;
            this.gunaLinePanel3.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel3.LineLeft = 1;
            this.gunaLinePanel3.LineRight = 1;
            this.gunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel3.LineTop = 1;
            this.gunaLinePanel3.Location = new System.Drawing.Point(471, 115);
            this.gunaLinePanel3.Name = "gunaLinePanel3";
            this.gunaLinePanel3.Size = new System.Drawing.Size(319, 201);
            this.gunaLinePanel3.TabIndex = 66;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(37, 161);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(47, 13);
            this.lblBookID.TabIndex = 32;
            this.lblBookID.Text = "Book ID";
            this.lblBookID.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(26, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 25);
            this.label14.TabIndex = 30;
            this.label14.Text = "Book Details";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(99, 136);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(27, 13);
            this.lblAuthor.TabIndex = 29;
            this.lblAuthor.Text = "Year";
            this.lblAuthor.Visible = false;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(99, 111);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 28;
            this.lblSubject.Text = "Course";
            this.lblSubject.Visible = false;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(99, 86);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(92, 13);
            this.lblISBN.TabIndex = 27;
            this.lblISBN.Text = "Student Number";
            this.lblISBN.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(99, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(79, 13);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Student name";
            this.lblTitle.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(36, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Author:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(36, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Subject:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(36, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "ISBN:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(36, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Title:";
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.lblStudID);
            this.gunaLinePanel2.Controls.Add(this.lblYear);
            this.gunaLinePanel2.Controls.Add(this.lblCourse);
            this.gunaLinePanel2.Controls.Add(this.lblStudNo);
            this.gunaLinePanel2.Controls.Add(this.lblName);
            this.gunaLinePanel2.Controls.Add(this.label4);
            this.gunaLinePanel2.Controls.Add(this.label5);
            this.gunaLinePanel2.Controls.Add(this.label3);
            this.gunaLinePanel2.Controls.Add(this.label2);
            this.gunaLinePanel2.Controls.Add(this.studImage);
            this.gunaLinePanel2.LineBottom = 1;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel2.LineLeft = 1;
            this.gunaLinePanel2.LineRight = 1;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.LineTop = 1;
            this.gunaLinePanel2.Location = new System.Drawing.Point(18, 115);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(425, 201);
            this.gunaLinePanel2.TabIndex = 65;
            // 
            // lblStudID
            // 
            this.lblStudID.AutoSize = true;
            this.lblStudID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudID.Location = new System.Drawing.Point(162, 161);
            this.lblStudID.Name = "lblStudID";
            this.lblStudID.Size = new System.Drawing.Size(62, 13);
            this.lblStudID.TabIndex = 23;
            this.lblStudID.Text = "Student ID";
            this.lblStudID.Visible = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(237, 132);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(27, 13);
            this.lblYear.TabIndex = 21;
            this.lblYear.Text = "Year";
            this.lblYear.Visible = false;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(237, 107);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(43, 13);
            this.lblCourse.TabIndex = 20;
            this.lblCourse.Text = "Course";
            this.lblCourse.Visible = false;
            // 
            // lblStudNo
            // 
            this.lblStudNo.AutoSize = true;
            this.lblStudNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudNo.Location = new System.Drawing.Point(237, 82);
            this.lblStudNo.Name = "lblStudNo";
            this.lblStudNo.Size = new System.Drawing.Size(92, 13);
            this.lblStudNo.TabIndex = 19;
            this.lblStudNo.Text = "Student Number";
            this.lblStudNo.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(237, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 13);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Student name";
            this.lblName.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(162, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(162, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Course:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(162, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Student No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(162, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name:";
            // 
            // studImage
            // 
            this.studImage.BackColor = System.Drawing.Color.White;
            this.studImage.BaseColor = System.Drawing.Color.Gainsboro;
            this.studImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studImage.Image = global::LMS.Properties.Resources.user;
            this.studImage.Location = new System.Drawing.Point(21, 31);
            this.studImage.Name = "studImage";
            this.studImage.Size = new System.Drawing.Size(130, 130);
            this.studImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studImage.TabIndex = 11;
            this.studImage.TabStop = false;
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(2, 34);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(803, 479);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "tabPageAdv2";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // frmIssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 533);
            this.Controls.Add(this.tabControlAdv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIssueBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmIssueBook_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchStud)).EndInit();
            this.gunaLinePanel3.ResumeLayout(false);
            this.gunaLinePanel3.PerformLayout();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.Label label1;
        private Tulpep.NotificationWindow.PopupNotifier popupNotifier;
        private Syncfusion.Reflection.TypeLoader designTimeTabTypeLoader;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Guna.UI.WinForms.GunaDateTimePicker dtDueDate;
        private Guna.UI.WinForms.GunaDateTimePicker dtIssueDate;
        private Guna.UI.WinForms.GunaButton btnProccessIssue;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSearchStud;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel3;
        public System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lblAuthor;
        public System.Windows.Forms.Label lblSubject;
        public System.Windows.Forms.Label lblISBN;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        public System.Windows.Forms.Label lblStudID;
        public System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.Label lblCourse;
        public System.Windows.Forms.Label lblStudNo;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaPictureBox studImage;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        public Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
    }
}