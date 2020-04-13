namespace LMS
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.lblLibrarianName = new System.Windows.Forms.Label();
            this.txtSummaryRprt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblBorrowID = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentNum = new System.Windows.Forms.Label();
            this.dtPaymentDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtDueDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnPrintReceipt = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrintInvoice = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.btnSubmit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printReport = new KimToo.EasyHTMLReports(this.components);
            this.popupNotifier = new Tulpep.NotificationWindow.PopupNotifier();
            this.gunaLinePanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.lblLibrarianName);
            this.gunaLinePanel1.Controls.Add(this.txtSummaryRprt);
            this.gunaLinePanel1.Controls.Add(this.label3);
            this.gunaLinePanel1.Controls.Add(this.lblAmount);
            this.gunaLinePanel1.Controls.Add(this.lblBorrowID);
            this.gunaLinePanel1.Controls.Add(this.lblStudentID);
            this.gunaLinePanel1.Controls.Add(this.lblStudentNum);
            this.gunaLinePanel1.Controls.Add(this.dtPaymentDate);
            this.gunaLinePanel1.Controls.Add(this.dtDueDate);
            this.gunaLinePanel1.Controls.Add(this.btnPrintReceipt);
            this.gunaLinePanel1.Controls.Add(this.label5);
            this.gunaLinePanel1.Controls.Add(this.label2);
            this.gunaLinePanel1.Controls.Add(this.btnPrintInvoice);
            this.gunaLinePanel1.Controls.Add(this.lblTotalAmount);
            this.gunaLinePanel1.Controls.Add(this.label6);
            this.gunaLinePanel1.Controls.Add(this.lblName);
            this.gunaLinePanel1.Controls.Add(this.label4);
            this.gunaLinePanel1.Controls.Add(this.gunaControlBox1);
            this.gunaLinePanel1.Controls.Add(this.btnSubmit);
            this.gunaLinePanel1.Controls.Add(this.lblTitle);
            this.gunaLinePanel1.Controls.Add(this.label1);
            this.gunaLinePanel1.Controls.Add(this.panel2);
            this.gunaLinePanel1.Controls.Add(this.panel1);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(856, 533);
            this.gunaLinePanel1.TabIndex = 1;
            // 
            // lblLibrarianName
            // 
            this.lblLibrarianName.AutoSize = true;
            this.lblLibrarianName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrarianName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblLibrarianName.Location = new System.Drawing.Point(405, 71);
            this.lblLibrarianName.Name = "lblLibrarianName";
            this.lblLibrarianName.Size = new System.Drawing.Size(0, 13);
            this.lblLibrarianName.TabIndex = 109;
            this.lblLibrarianName.Visible = false;
            // 
            // txtSummaryRprt
            // 
            this.txtSummaryRprt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSummaryRprt.DefaultText = "";
            this.txtSummaryRprt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSummaryRprt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSummaryRprt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSummaryRprt.DisabledState.Parent = this.txtSummaryRprt;
            this.txtSummaryRprt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSummaryRprt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtSummaryRprt.FocusedState.Parent = this.txtSummaryRprt;
            this.txtSummaryRprt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.txtSummaryRprt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.txtSummaryRprt.HoverState.Parent = this.txtSummaryRprt;
            this.txtSummaryRprt.Location = new System.Drawing.Point(457, 452);
            this.txtSummaryRprt.Name = "txtSummaryRprt";
            this.txtSummaryRprt.PasswordChar = '\0';
            this.txtSummaryRprt.PlaceholderText = "e.g. Fine for lost, damaged, overdue book......";
            this.txtSummaryRprt.SelectedText = "";
            this.txtSummaryRprt.ShadowDecoration.Parent = this.txtSummaryRprt;
            this.txtSummaryRprt.Size = new System.Drawing.Size(376, 26);
            this.txtSummaryRprt.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(454, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 107;
            this.label3.Text = "Summary Report";
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblAmount.Location = new System.Drawing.Point(12, 472);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(31, 37);
            this.lblAmount.TabIndex = 105;
            this.lblAmount.Text = "0";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAmount.Visible = false;
            // 
            // lblBorrowID
            // 
            this.lblBorrowID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBorrowID.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblBorrowID.Location = new System.Drawing.Point(248, 33);
            this.lblBorrowID.Name = "lblBorrowID";
            this.lblBorrowID.Size = new System.Drawing.Size(24, 20);
            this.lblBorrowID.TabIndex = 104;
            this.lblBorrowID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBorrowID.Visible = false;
            // 
            // lblStudentID
            // 
            this.lblStudentID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentID.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblStudentID.Location = new System.Drawing.Point(258, 33);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(24, 20);
            this.lblStudentID.TabIndex = 103;
            this.lblStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStudentID.Visible = false;
            // 
            // lblStudentNum
            // 
            this.lblStudentNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentNum.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblStudentNum.Location = new System.Drawing.Point(217, 33);
            this.lblStudentNum.Name = "lblStudentNum";
            this.lblStudentNum.Size = new System.Drawing.Size(24, 20);
            this.lblStudentNum.TabIndex = 102;
            this.lblStudentNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStudentNum.Visible = false;
            // 
            // dtPaymentDate
            // 
            this.dtPaymentDate.BaseColor = System.Drawing.Color.Gainsboro;
            this.dtPaymentDate.BorderColor = System.Drawing.Color.Silver;
            this.dtPaymentDate.BorderSize = 0;
            this.dtPaymentDate.CustomFormat = "dd MMMM yyyy";
            this.dtPaymentDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPaymentDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.dtPaymentDate.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.dtPaymentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.dtPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPaymentDate.Location = new System.Drawing.Point(18, 99);
            this.dtPaymentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPaymentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPaymentDate.Name = "dtPaymentDate";
            this.dtPaymentDate.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.dtPaymentDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.dtPaymentDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.dtPaymentDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtPaymentDate.Size = new System.Drawing.Size(223, 23);
            this.dtPaymentDate.TabIndex = 101;
            this.dtPaymentDate.Text = "02 April 2020";
            this.dtPaymentDate.Value = new System.DateTime(2020, 4, 2, 15, 25, 39, 76);
            // 
            // dtDueDate
            // 
            this.dtDueDate.BaseColor = System.Drawing.Color.Gainsboro;
            this.dtDueDate.BorderColor = System.Drawing.Color.Silver;
            this.dtDueDate.BorderSize = 0;
            this.dtDueDate.CustomFormat = "dd MMMM yyyy";
            this.dtDueDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtDueDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.dtDueDate.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.dtDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.dtDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDueDate.Location = new System.Drawing.Point(247, 99);
            this.dtDueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.dtDueDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.dtDueDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.dtDueDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtDueDate.Size = new System.Drawing.Size(223, 23);
            this.dtDueDate.TabIndex = 100;
            this.dtDueDate.Text = "02 April 2020";
            this.dtDueDate.Value = new System.DateTime(2020, 4, 2, 15, 25, 39, 76);
            this.dtDueDate.Visible = false;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReceipt.AnimationHoverSpeed = 0.07F;
            this.btnPrintReceipt.AnimationSpeed = 0.03F;
            this.btnPrintReceipt.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintReceipt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnPrintReceipt.BorderColor = System.Drawing.Color.Black;
            this.btnPrintReceipt.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPrintReceipt.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPrintReceipt.CheckedForeColor = System.Drawing.Color.White;
            this.btnPrintReceipt.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPrintReceipt.CheckedImage")));
            this.btnPrintReceipt.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPrintReceipt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrintReceipt.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrintReceipt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrintReceipt.ForeColor = System.Drawing.Color.White;
            this.btnPrintReceipt.Image = null;
            this.btnPrintReceipt.ImageSize = new System.Drawing.Size(22, 22);
            this.btnPrintReceipt.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPrintReceipt.Location = new System.Drawing.Point(567, 487);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.btnPrintReceipt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrintReceipt.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrintReceipt.OnHoverImage = null;
            this.btnPrintReceipt.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPrintReceipt.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrintReceipt.Radius = 7;
            this.btnPrintReceipt.Size = new System.Drawing.Size(123, 35);
            this.btnPrintReceipt.TabIndex = 98;
            this.btnPrintReceipt.Text = "Generate Receipt";
            this.btnPrintReceipt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrintReceipt.Click += new System.EventHandler(this.BtnPrintReceipt_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(15, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 42);
            this.label5.TabIndex = 97;
            this.label5.Text = "Must pay the exact amount on or before the given due date after the declared lost" +
    "/damaged book.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(16, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 96;
            this.label2.Text = "Term and Condition";
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintInvoice.AnimationHoverSpeed = 0.07F;
            this.btnPrintInvoice.AnimationSpeed = 0.03F;
            this.btnPrintInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintInvoice.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnPrintInvoice.BorderColor = System.Drawing.Color.Black;
            this.btnPrintInvoice.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPrintInvoice.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPrintInvoice.CheckedForeColor = System.Drawing.Color.White;
            this.btnPrintInvoice.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPrintInvoice.CheckedImage")));
            this.btnPrintInvoice.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPrintInvoice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrintInvoice.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrintInvoice.ForeColor = System.Drawing.Color.White;
            this.btnPrintInvoice.Image = null;
            this.btnPrintInvoice.ImageSize = new System.Drawing.Size(22, 22);
            this.btnPrintInvoice.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPrintInvoice.Location = new System.Drawing.Point(457, 487);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.btnPrintInvoice.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrintInvoice.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrintInvoice.OnHoverImage = null;
            this.btnPrintInvoice.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPrintInvoice.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrintInvoice.Radius = 7;
            this.btnPrintInvoice.Size = new System.Drawing.Size(104, 35);
            this.btnPrintInvoice.TabIndex = 94;
            this.btnPrintInvoice.Text = "Print Invoice";
            this.btnPrintInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrintInvoice.Click += new System.EventHandler(this.BtnPrintInvoice_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(616, 384);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(225, 37);
            this.lblTotalAmount.TabIndex = 93;
            this.lblTotalAmount.Text = "0";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(753, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 92;
            this.label6.Text = "Total Amount";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblName.Location = new System.Drawing.Point(616, 104);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(225, 20);
            this.lblName.TabIndex = 91;
            this.lblName.Text = "Sample Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(793, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 90;
            this.label4.Text = "Bill To";
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(818, 7);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(37, 29);
            this.gunaControlBox1.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.AnimationHoverSpeed = 0.07F;
            this.btnSubmit.AnimationSpeed = 0.03F;
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.btnSubmit.BorderColor = System.Drawing.Color.Black;
            this.btnSubmit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSubmit.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSubmit.CheckedForeColor = System.Drawing.Color.White;
            this.btnSubmit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.CheckedImage")));
            this.btnSubmit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSubmit.FocusedColor = System.Drawing.Color.Empty;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Image = null;
            this.btnSubmit.ImageSize = new System.Drawing.Size(22, 22);
            this.btnSubmit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSubmit.Location = new System.Drawing.Point(696, 487);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.btnSubmit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSubmit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSubmit.OnHoverImage = null;
            this.btnSubmit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSubmit.OnPressedColor = System.Drawing.Color.Black;
            this.btnSubmit.Radius = 7;
            this.btnSubmit.Size = new System.Drawing.Size(137, 35);
            this.btnSubmit.TabIndex = 89;
            this.btnSubmit.Text = "Process Payment";
            this.btnSubmit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(199, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Payment Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(15, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Payment Date:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gunaDataGridView1);
            this.panel2.Location = new System.Drawing.Point(1, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 224);
            this.panel2.TabIndex = 28;
            // 
            // gunaDataGridView1
            // 
            this.gunaDataGridView1.AllowUserToAddRows = false;
            this.gunaDataGridView1.AllowUserToDeleteRows = false;
            this.gunaDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 35;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 30;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(854, 224);
            this.gunaDataGridView1.TabIndex = 1;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 35;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 30;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 77;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "REF";
            this.Column2.Name = "Column2";
            this.Column2.Width = 91;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "BOOK NAME";
            this.Column7.Name = "Column7";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "DESCRIPTION";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "STATUS";
            this.Column4.Name = "Column4";
            this.Column4.Width = 113;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "CHARGE";
            this.Column5.Name = "Column5";
            this.Column5.Width = 115;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 7);
            this.panel1.TabIndex = 26;
            // 
            // printReport
            // 
            this.printReport.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.printReport.AlternativeRowGridColor = System.Drawing.SystemColors.ControlText;
            this.printReport.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.printReport.HeaderFontColor = System.Drawing.SystemColors.ControlText;
            this.printReport.HeaderGridColor = System.Drawing.SystemColors.ControlText;
            this.printReport.RowDefaultBackgroudColor = System.Drawing.Color.White;
            this.printReport.RowDefaultFontColor = System.Drawing.SystemColors.ControlText;
            this.printReport.RowDefaultGridColor = System.Drawing.SystemColors.ControlText;
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
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 533);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.FrmPayment_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaAdvenceButton btnSubmit;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaAdvenceButton btnPrintInvoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblName;
        private KimToo.EasyHTMLReports printReport;
        private Guna.UI.WinForms.GunaAdvenceButton btnPrintReceipt;
        private Guna.UI.WinForms.GunaDateTimePicker dtPaymentDate;
        private Guna.UI.WinForms.GunaDateTimePicker dtDueDate;
        public System.Windows.Forms.Label lblStudentNum;
        public System.Windows.Forms.Label lblStudentID;
        public System.Windows.Forms.Label lblBorrowID;
        private Tulpep.NotificationWindow.PopupNotifier popupNotifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSummaryRprt;
        public System.Windows.Forms.Label lblLibrarianName;
    }
}