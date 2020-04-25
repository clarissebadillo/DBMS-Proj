using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Tulpep.NotificationWindow;
using MyMessage;

namespace LMS
{
    public partial class frmIssueBook : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        Form1 frm1;

        string admin;
        string borrowDays;
        string borrowBooks;
        string withPending;
        string withOverdue;

        public frmIssueBook(Form1 f1)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frm1 = f1;

            admin = frm1.lblLibrarian.Text;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      // WS_EX_COMPOSITED
                return handleParam;
            }
        }

        private void FrmIssueBook_Load(object sender, EventArgs e)
        {
            txtSearchStud.Select();

            AutoCompleteStudentNo();
            LoadRecords();
            Overdue();
            GetSettings();

            dtIssueDate.Value = DateTime.Now;
            dtDueDate.Value = dtIssueDate.Value.AddDays(Double.Parse(borrowDays));
        }

        public void LoadRecords()
        {
            int i = 0;
            gunaDataGridView3.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT bookID, bookTitle, bookISBN, subject, author, allCopies, availableCopies FROM tblBook WHERE bookTitle LIKE '" + txtSearchBook.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                gunaDataGridView3.Rows.Add(i, dr["bookID"].ToString(), dr["bookTitle"].ToString(), dr["bookISBN"].ToString(), dr["subject"].ToString(), dr["author"].ToString(), dr["allCopies"].ToString(), dr["availableCopies"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void BooksOnHand()
        {
            cn.Open();
            cm = new SqlCommand("SELECT COUNT(*) FROM tblBorrowedBook WHERE status IN ('Not Returned', 'Overdue') AND studentNum = @studentNum", cn);
            cm.Parameters.AddWithValue("@studentNum", txtSearchStud.Text);
            lblBooksOnHand.Text = cm.ExecuteScalar().ToString();
            cn.Close();
        }

        public void BooksOverdue()
        {
            cn.Open();
            cm = new SqlCommand("SELECT COUNT(*) FROM tblBorrowedBook WHERE status = 'Overdue' AND studentNum = @studentNum", cn);
            cm.Parameters.AddWithValue("@studentNum", txtSearchStud.Text);
            lblBooksOverdue.Text = cm.ExecuteScalar().ToString();
            cn.Close();
        }

        public void BorrowHistory()
        {
            cn.Open();
            cm = new SqlCommand("SELECT COUNT(*) FROM tblBorrowedBook WHERE studentNum = @studentNum", cn);
            cm.Parameters.AddWithValue("@studentNum", lblStudNo.Text);
            lblHistory.Text = cm.ExecuteScalar().ToString();
            cn.Close();
        }

        public void CountFine()
        {
            cn.Open();
            cm = new SqlCommand("SELECT SUM(CAST([totalFine] AS INT)) FROM tblBorrowedBook WHERE studentID =  @studentID", cn);
            cm.Parameters.AddWithValue("@studentID", lblStudID.Text);
            lblFine.Text = "₱" + cm.ExecuteScalar() + ".00";
            cn.Close();
        }

        public void CountClearedPayments()
        {
            cn.Open();
            cm = new SqlCommand("SELECT SUM(totalPayment) FROM tblPayment WHERE studentID =  @studentID", cn);
            cm.Parameters.AddWithValue("@studentID", lblStudID.Text);
            lblClearedPayments.Text = "₱" + cm.ExecuteScalar() + ".00";
            cn.Close();
        }

        public void LostBook()
        {
            cn.Open();
            cm = new SqlCommand("SELECT COUNT(*) FROM tblBorrowedBook WHERE status = 'Lost' AND studentNum = @studentNum", cn);
            cm.Parameters.AddWithValue("@studentNum", txtSearchStud.Text);
            lblBookLost.Text = cm.ExecuteScalar().ToString();
            cn.Close();
        }

        public void DamagedBook()
        {
            cn.Open();
            cm = new SqlCommand("SELECT COUNT(*) FROM tblBorrowedBook WHERE status = 'Damaged' AND studentNum = @studentNum", cn);
            cm.Parameters.AddWithValue("@studentNum", txtSearchStud.Text);
            lblDamagedBook.Text = cm.ExecuteScalar().ToString();
            cn.Close();
        }

        public void Notif()
        {
            popupNotifier.ContentText = lblBookTitle.Text + " has been issued to " + lblName.Text + " successfully!";
            popupNotifier.Popup();
        }


        public void BorrowBook()
        {
            try
            {
                if (MyMessageBox.ShowMessage("Are you sure you want to issue " + lblBookTitle.Text + " to " + lblName.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int fine = 0;
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblBorrowedBook VALUES (@studentID, @bookID, @studentNum, @bookTitle, @dateBorrowed, @dueDate, '', 'Not Returned', @totalFine, @paymentStatus, @librarian)", cn);
                    cm.Parameters.AddWithValue("@studentID", lblStudID.Text);
                    cm.Parameters.AddWithValue("@studentNum", lblStudNo.Text);
                    cm.Parameters.AddWithValue("@bookID", lblBookID.Text);
                    cm.Parameters.AddWithValue("@bookTitle", lblBookTitle.Text);
                    cm.Parameters.AddWithValue("@dateBorrowed", dtIssueDate.Value);
                    cm.Parameters.AddWithValue("@dueDate", dtDueDate.Value);
                    cm.Parameters.AddWithValue("@totalFine", fine);
                    cm.Parameters.AddWithValue("@paymentStatus", "");
                    cm.Parameters.AddWithValue("@librarian", frm1.lblLibrarian.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    Deduction();
                    gunaDataGridView3.Rows.Clear();
                    LoadRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void Deduction()
        {
            cn.Open();
            cm = new SqlCommand("UPDATE tblBook SET availableCopies = availableCopies - 1 WHERE bookTitle = @bookTitle", cn);
            cm.Parameters.AddWithValue("@bookTitle", lblBookTitle.Text);
            cm.ExecuteNonQuery();
            cn.Close();
            Notif();
        }


        public void AutoCompleteStudentNo()
        {
            cn.Open();
            cm = new SqlCommand("SELECT studentNum FROM tblStudent WHERE accountStat = 'Active'", cn);
            dr = cm.ExecuteReader();
            AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                Collection.Add(dr.GetString(0));
            }
            txtSearchStud.AutoCompleteCustomSource = Collection;
            dr.Close();
            cn.Close();
        }

        public void Overdue()
        {
            cn.Open();
            cm = new SqlCommand("UPDATE tblBorrowedBook SET status = 'Overdue' WHERE status = 'Not Returned' AND dueDate < GETDATE()", cn);
            cm.ExecuteNonQuery();
            cn.Close();
        }


        public void Clear()
        {
            lblCourse.Text = "";
            lblName.Text = "";
            lblStudNo.Text = "";
            lblYear.Text = "";
            lblBookAllCopies.Text = "00";
            lblAvailable.Text = "00";
            lblBooksOnHand.Text = "0";
            studImage.Image = Properties.Resources.user;
        }

        public void LoadDetails()
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblStudent WHERE studentNUm = @studentNum", cn);
            cm.Parameters.AddWithValue("@studentNum", txtSearchStud.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                lblName.Text = dr["firstName"].ToString() + " " + dr["lastName"].ToString();
                lblStudNo.Text = dr["studentNum"].ToString();
                lblCourse.Text = dr["course"].ToString();
                lblYear.Text = dr["year"].ToString();
                lblStudID.Text = dr["studentID"].ToString();
                byte[] imgbytes = (byte[])dr["image"];
                MemoryStream mstream = new MemoryStream(imgbytes);
                studImage.Image = Image.FromStream(mstream);
            }
            dr.Close();
            cn.Close();
        }


        private void TxtSearchStud_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblStudent WHERE studentNUm = @studentNum", cn);
            cm.Parameters.AddWithValue("@studentNum", txtSearchStud.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                lblName.Text = dr["firstName"].ToString() + " " + dr["lastName"].ToString();
                lblStudNo.Text = dr["studentNum"].ToString();
                lblCourse.Text = dr["course"].ToString();
                lblYear.Text = dr["year"].ToString();
                lblStudID.Text = dr["studentID"].ToString();
                byte[] imgbytes = (byte[])dr["image"];
                MemoryStream mstream = new MemoryStream(imgbytes);
                studImage.Image = Image.FromStream(mstream);
            }
            dr.Close();
            cn.Close();
            BooksOnHand();
            BooksOverdue();
            BorrowHistory();
            CountFine();
            LostBook();
            DamagedBook();
            CountClearedPayments();
        }

        private void TxtSearchBook_TextChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void GunaDataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblBorrowID.Text = gunaDataGridView3[1, e.RowIndex].Value.ToString();
            lblBookAllCopies.Text = gunaDataGridView3[6, e.RowIndex].Value.ToString();
            lblAvailable.Text = gunaDataGridView3[7, e.RowIndex].Value.ToString();
            lblBookID.Text = gunaDataGridView3[1, e.RowIndex].Value.ToString();
            lblBookTitle.Text = gunaDataGridView3[2, e.RowIndex].Value.ToString();
        }

        void GetSettings()
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblSettings", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                borrowBooks = dr["maxBorrowBooks"].ToString();
                borrowDays = dr["maxBorrowDays"].ToString();
                withPending = dr["withPending"].ToString();
                withOverdue = dr["withOverdue"].ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void BtnProcessIssue_Click(object sender, EventArgs e)
        {
            frmOnHand frm = new frmOnHand(this);



            if (txtSearchStud.Text == "")
            {
                txtSearchStud.Focus();
                MyMessageBox.ShowMessage("Please enter the student number", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (lblBookTitle.Text == "Book Title")
            {
                MyMessageBox.ShowMessage("Please choose the book to issue!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (lblBooksOnHand.Text == borrowBooks)
            {
                MyMessageBox.ShowMessage("Student already reached the maximum number of borrowed book!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (lblAvailable.Text == "0" || lblAvailable.Text == "-1")
            {
                MyMessageBox.ShowMessage("No available copies left!", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (withPending == "False")
            {
                if (lblFine.Text == "₱.00" || lblFine.Text == "₱0.00")
                {
                    BorrowBook();
                    Clear();
                    LoadDetails();
                    BooksOnHand();
                    BorrowHistory();
                }
                else
                {
                    MyMessageBox.ShowMessage("Student needs to settle all pending payments to allow checking out another books.", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else if (withOverdue == "False")
            {
                if (lblBooksOverdue.Text == "0")
                {
                    BorrowBook();
                    Clear();
                    LoadDetails();
                    BooksOnHand();
                    BorrowHistory();
                }
                else
                {
                    MyMessageBox.ShowMessage("Student needs to return all overdue books to allow checking out another books.", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                BorrowBook();
                Clear();
                LoadDetails();
                BooksOnHand();
                BorrowHistory();
            }
        }

        private void LblBooksOnHand_Click(object sender, EventArgs e)
        {
            frmOnHand frm = new frmOnHand(this);
            frm.lblLibrarian.Text = admin;
            frm.lblStudentName.Text = lblName.Text;
            frm.Show();
        }

        private void BtnScan_Click(object sender, EventArgs e)
        {
            frmQRScanner frm = new frmQRScanner(this);
            frm.Show();
        }

        private void LblFine_Click(object sender, EventArgs e)
        {
            frmPayment frm = new frmPayment(this);
            frm.lblLibrarianName.Text = admin;
            frm.Show();
        }


    }
}
