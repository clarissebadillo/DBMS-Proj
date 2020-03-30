namespace LMS
{
    partial class viewBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewBook));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.btnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblBookISBN = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.popupNotifier = new Tulpep.NotificationWindow.PopupNotifier();
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.panel1);
            this.gunaLinePanel1.Controls.Add(this.lblID);
            this.gunaLinePanel1.Controls.Add(this.btnDelete);
            this.gunaLinePanel1.Controls.Add(this.btnEdit);
            this.gunaLinePanel1.Controls.Add(this.lblAuthor);
            this.gunaLinePanel1.Controls.Add(this.pictureBox1);
            this.gunaLinePanel1.Controls.Add(this.lblSubject);
            this.gunaLinePanel1.Controls.Add(this.lblBookISBN);
            this.gunaLinePanel1.Controls.Add(this.lblBookName);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 2;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(675, 39);
            this.gunaLinePanel1.TabIndex = 0;
            this.gunaLinePanel1.Click += new System.EventHandler(this.GunaLinePanel1_Click);
            this.gunaLinePanel1.MouseEnter += new System.EventHandler(this.GunaLinePanel1_MouseEnter);
            this.gunaLinePanel1.MouseLeave += new System.EventHandler(this.GunaLinePanel1_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 38);
            this.panel1.TabIndex = 71;
            this.panel1.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.lblID.Location = new System.Drawing.Point(45, 11);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 70;
            this.lblID.Visible = false;
            this.lblID.MouseEnter += new System.EventHandler(this.GunaLinePanel1_MouseEnter);
            this.lblID.MouseLeave += new System.EventHandler(this.GunaLinePanel1_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Image = global::LMS.Properties.Resources.trash_16px;
            this.btnDelete.ImageActive = null;
            this.btnDelete.Location = new System.Drawing.Point(645, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(16, 16);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 69;
            this.btnDelete.TabStop = false;
            this.btnDelete.Zoom = 10;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.GunaLinePanel1_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.GunaLinePanel1_MouseLeave);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Image = global::LMS.Properties.Resources.pencil_16px;
            this.btnEdit.ImageActive = null;
            this.btnEdit.Location = new System.Drawing.Point(624, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(16, 16);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 68;
            this.btnEdit.TabStop = false;
            this.btnEdit.Zoom = 10;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.GunaLinePanel1_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.GunaLinePanel1_MouseLeave);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.lblAuthor.Location = new System.Drawing.Point(478, 11);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(43, 13);
            this.lblAuthor.TabIndex = 67;
            this.lblAuthor.Text = "Author";
            this.lblAuthor.Click += new System.EventHandler(this.GunaLinePanel1_Click);
            this.lblAuthor.MouseEnter += new System.EventHandler(this.GunaLinePanel1_MouseEnter);
            this.lblAuthor.MouseLeave += new System.EventHandler(this.GunaLinePanel1_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.GunaLinePanel1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.GunaLinePanel1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.GunaLinePanel1_MouseLeave);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.lblSubject.Location = new System.Drawing.Point(361, 11);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(45, 13);
            this.lblSubject.TabIndex = 65;
            this.lblSubject.Text = "Subject";
            this.lblSubject.Click += new System.EventHandler(this.GunaLinePanel1_Click);
            this.lblSubject.MouseEnter += new System.EventHandler(this.GunaLinePanel1_MouseEnter);
            this.lblSubject.MouseLeave += new System.EventHandler(this.GunaLinePanel1_MouseLeave);
            // 
            // lblBookISBN
            // 
            this.lblBookISBN.AutoSize = true;
            this.lblBookISBN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.lblBookISBN.Location = new System.Drawing.Point(232, 11);
            this.lblBookISBN.Name = "lblBookISBN";
            this.lblBookISBN.Size = new System.Drawing.Size(59, 13);
            this.lblBookISBN.TabIndex = 64;
            this.lblBookISBN.Text = "Book ISBN";
            this.lblBookISBN.Click += new System.EventHandler(this.GunaLinePanel1_Click);
            this.lblBookISBN.MouseEnter += new System.EventHandler(this.GunaLinePanel1_MouseEnter);
            this.lblBookISBN.MouseLeave += new System.EventHandler(this.GunaLinePanel1_MouseLeave);
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.lblBookName.Location = new System.Drawing.Point(61, 11);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(62, 13);
            this.lblBookName.TabIndex = 63;
            this.lblBookName.Text = "BookName";
            this.lblBookName.Click += new System.EventHandler(this.GunaLinePanel1_Click);
            this.lblBookName.MouseEnter += new System.EventHandler(this.GunaLinePanel1_MouseEnter);
            this.lblBookName.MouseLeave += new System.EventHandler(this.GunaLinePanel1_MouseLeave);
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
            // viewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "viewBook";
            this.Size = new System.Drawing.Size(675, 39);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Bunifu.Framework.UI.BunifuImageButton btnDelete;
        private Bunifu.Framework.UI.BunifuImageButton btnEdit;
        public System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblSubject;
        public System.Windows.Forms.Label lblBookISBN;
        public System.Windows.Forms.Label lblBookName;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel1;
        private Tulpep.NotificationWindow.PopupNotifier popupNotifier;
    }
}
