namespace LMS
{
    partial class ucBooksOnHand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBooksOnHand));
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.dtDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblBorrowID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblDateBorrowed = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.declareLostBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popupNotifier = new Tulpep.NotificationWindow.PopupNotifier();
            this.markSelectedBookAsDamagedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaLinePanel2.SuspendLayout();
            this.gunaContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.dtDueDate);
            this.gunaLinePanel2.Controls.Add(this.lblStudentID);
            this.gunaLinePanel2.Controls.Add(this.lblBorrowID);
            this.gunaLinePanel2.Controls.Add(this.pictureBox1);
            this.gunaLinePanel2.LineBottom = 2;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(610, 38);
            this.gunaLinePanel2.TabIndex = 5;
            this.gunaLinePanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GunaLinePanel2_MouseDown);
            this.gunaLinePanel2.MouseEnter += new System.EventHandler(this.GunaLinePanel2_MouseEnter);
            this.gunaLinePanel2.MouseLeave += new System.EventHandler(this.GunaLinePanel2_MouseLeave);
            this.gunaLinePanel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GunaLinePanel2_MouseUp);
            // 
            // dtDueDate
            // 
            this.dtDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDueDate.Location = new System.Drawing.Point(146, 8);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(108, 20);
            this.dtDueDate.TabIndex = 68;
            this.dtDueDate.Visible = false;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblStudentID.Location = new System.Drawing.Point(46, 11);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(0, 13);
            this.lblStudentID.TabIndex = 9;
            this.lblStudentID.Visible = false;
            // 
            // lblBorrowID
            // 
            this.lblBorrowID.AutoSize = true;
            this.lblBorrowID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblBorrowID.Location = new System.Drawing.Point(46, 11);
            this.lblBorrowID.Name = "lblBorrowID";
            this.lblBorrowID.Size = new System.Drawing.Size(0, 13);
            this.lblBorrowID.TabIndex = 8;
            this.lblBorrowID.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblStatus.Location = new System.Drawing.Point(506, 11);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            this.lblStatus.MouseEnter += new System.EventHandler(this.GunaLinePanel2_MouseEnter);
            this.lblStatus.MouseLeave += new System.EventHandler(this.GunaLinePanel2_MouseLeave);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblDueDate.Location = new System.Drawing.Point(394, 11);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(55, 13);
            this.lblDueDate.TabIndex = 6;
            this.lblDueDate.Text = "Due Date";
            this.lblDueDate.MouseEnter += new System.EventHandler(this.GunaLinePanel2_MouseEnter);
            this.lblDueDate.MouseLeave += new System.EventHandler(this.GunaLinePanel2_MouseLeave);
            // 
            // lblDateBorrowed
            // 
            this.lblDateBorrowed.AutoSize = true;
            this.lblDateBorrowed.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBorrowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblDateBorrowed.Location = new System.Drawing.Point(260, 11);
            this.lblDateBorrowed.Name = "lblDateBorrowed";
            this.lblDateBorrowed.Size = new System.Drawing.Size(84, 13);
            this.lblDateBorrowed.TabIndex = 5;
            this.lblDateBorrowed.Text = "Date Borrowed";
            this.lblDateBorrowed.MouseEnter += new System.EventHandler(this.GunaLinePanel2_MouseEnter);
            this.lblDateBorrowed.MouseLeave += new System.EventHandler(this.GunaLinePanel2_MouseLeave);
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblBookName.Location = new System.Drawing.Point(52, 11);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(65, 13);
            this.lblBookName.TabIndex = 4;
            this.lblBookName.Text = "Book Name";
            this.lblBookName.MouseEnter += new System.EventHandler(this.GunaLinePanel2_MouseEnter);
            this.lblBookName.MouseLeave += new System.EventHandler(this.GunaLinePanel2_MouseLeave);
            // 
            // gunaContextMenuStrip1
            // 
            this.gunaContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnBookToolStripMenuItem,
            this.declareLostBookToolStripMenuItem,
            this.markSelectedBookAsDamagedToolStripMenuItem});
            this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(247, 70);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.GunaLinePanel2_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.GunaLinePanel2_MouseLeave);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnBookToolStripMenuItem.Image")));
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.returnBookToolStripMenuItem.Text = "Return Selected Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.ReturnBookToolStripMenuItem_Click);
            // 
            // declareLostBookToolStripMenuItem
            // 
            this.declareLostBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("declareLostBookToolStripMenuItem.Image")));
            this.declareLostBookToolStripMenuItem.Name = "declareLostBookToolStripMenuItem";
            this.declareLostBookToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.declareLostBookToolStripMenuItem.Text = "Mark Selected Book as Lost";
            this.declareLostBookToolStripMenuItem.Click += new System.EventHandler(this.DeclareLostBookToolStripMenuItem_Click);
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
            // markSelectedBookAsDamagedToolStripMenuItem
            // 
            this.markSelectedBookAsDamagedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("markSelectedBookAsDamagedToolStripMenuItem.Image")));
            this.markSelectedBookAsDamagedToolStripMenuItem.Name = "markSelectedBookAsDamagedToolStripMenuItem";
            this.markSelectedBookAsDamagedToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.markSelectedBookAsDamagedToolStripMenuItem.Text = "Mark Selected Book as Damaged";
            this.markSelectedBookAsDamagedToolStripMenuItem.Click += new System.EventHandler(this.MarkSelectedBookAsDamagedToolStripMenuItem_Click);
            // 
            // ucBooksOnHand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblDateBorrowed);
            this.Controls.Add(this.gunaLinePanel2);
            this.Name = "ucBooksOnHand";
            this.Size = new System.Drawing.Size(610, 38);
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            this.gunaContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Label lblDueDate;
        public System.Windows.Forms.Label lblDateBorrowed;
        public System.Windows.Forms.Label lblBookName;
        public System.Windows.Forms.Label lblBorrowID;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem declareLostBookToolStripMenuItem;
        public System.Windows.Forms.Label lblStudentID;
        private Tulpep.NotificationWindow.PopupNotifier popupNotifier;
        public System.Windows.Forms.DateTimePicker dtDueDate;
        private System.Windows.Forms.ToolStripMenuItem markSelectedBookAsDamagedToolStripMenuItem;
    }
}
