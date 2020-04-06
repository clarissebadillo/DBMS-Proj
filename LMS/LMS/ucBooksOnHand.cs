using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyMessage;

namespace LMS
{
    public partial class ucBooksOnHand : UserControl
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmOnHand frmonhand;

        int fine = 5;

        public ucBooksOnHand(frmOnHand fonhand)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmonhand = fonhand;
        }



        private void GunaLinePanel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.BackColor = Color.FromArgb(234, 162, 44);
                this.gunaContextMenuStrip1.Show(this.gunaLinePanel2, e.Location);
                this.gunaContextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void GunaLinePanel2_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(234, 162, 44);
        }

        private void GunaLinePanel2_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void GunaLinePanel2_MouseDown(object sender, MouseEventArgs e)
        {
            //this.BackColor = Color.White;
        }

        private void UpdateStatus()
        {
            cn.Open();
            cm = new SqlCommand("UPDATE tblBorrowedBook SET status = 'Returned' WHERE borrowID = @borrowID", cn);
            cm.Parameters.AddWithValue("@borrowID", lblBorrowID.Text);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        public void RetrieveBookCopy()
        {
            cn.Open();
            cm = new SqlCommand("UPDATE tblBook SET availableCopies = availableCopies + 1 WHERE bookTitle = @bookTitle", cn);
            cm.Parameters.AddWithValue("@bookTitle", lblBookName.Text);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        private void ReturnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MyMessageBox.ShowMessage("Return selected book?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblBorrowedBook SET returnedDate = GETDATE() WHERE borrowID = @borrowID", cn);
                    cm.Parameters.AddWithValue("@borrowID", lblBorrowID.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    UpdateStatus();
                    RetrieveBookCopy();
                    CalculateFine();

                    frmonhand.flowLayoutPanel1.Controls.Clear();
                    frmonhand.BooksOnHand();
                    frmonhand.BooksOverdue();
                    frmonhand.RefreshAll();

                    popupNotifier.ContentText = lblBookName.Text + " has been successfuly returned!";
                    popupNotifier.Popup();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CalculateFine()
        {
            DateTime dueDate = new DateTime();
            DateTime returnDate = new DateTime();
            dueDate = dtDueDate.Value;
            returnDate = DateTime.Now;
            TimeSpan diff = returnDate.Subtract(dueDate);
            int days = diff.Days;
            fine = days * 5;
            string paymentStat = "";
            if (fine < 0)
            {
                fine = 0;
            }
            else
            {
                paymentStat = "Pending";
            }

            cn.Open();
            cm = new SqlCommand("UPDATE tblBorrowedBook SET totalFine = @totalFine, paymentStatus = @paymentStatus WHERE borrowID = @borrowID", cn);
            cm.Parameters.AddWithValue("@totalFine", fine);
            cm.Parameters.AddWithValue("@paymentStatus", paymentStat);
            cm.Parameters.AddWithValue("@borrowID", lblBorrowID.Text);
            cm.ExecuteNonQuery();
            cn.Close();

        }


        //PENALTY
        public void StatusLost()
        {
            cn.Open();
            cm = new SqlCommand("UPDATE tblBorrowedBook SET status = 'Lost', paymentStatus = 'Pending' WHERE borrowID = @borrowID", cn);
            cm.Parameters.AddWithValue("@borrowID", lblBorrowID.Text);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        public void StatusDamage()
        {
            cn.Open();
            cm = new SqlCommand("UPDATE tblBorrowedBook SET status = 'Damaged', paymentStatus = 'Pending' WHERE borrowID = @borrowID", cn);
            cm.Parameters.AddWithValue("@borrowID", lblBorrowID.Text);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        public void UpdateBookCopies()
        {
            cn.Open();
            cm = new SqlCommand("UPDATE tblBook SET allCopies = allCopies - 1 WHERE bookTitle = @bookTitle", cn);
            cm.Parameters.AddWithValue("@bookTitle", lblBookName.Text);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        public void UpdateAvailableCopies()
        {
            cn.Open();
            cm = new SqlCommand("UPDATE tblBook SET availableCopies = availableCopies - 1 WHERE bookTitle = @bookTitle", cn);
            cm.Parameters.AddWithValue("@bookTitle", lblBookName.Text);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        private void DeclareLostBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MyMessageBox.ShowMessage("Declare selected book as lost? \n The penalty is ₱500.00", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblBorrowedBook SET totalFine = totalFine + 500 WHERE borrowID = @borrowID", cn);
                    cm.Parameters.AddWithValue("@borrowID", lblBorrowID.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    StatusLost();
                    UpdateBookCopies();
                    UpdateAvailableCopies();

                    frmonhand.flowLayoutPanel1.Controls.Clear();
                    frmonhand.BooksOnHand();
                    frmonhand.BooksOverdue();
                    frmonhand.RefreshAll();


                    popupNotifier.ContentText = lblBookName.Text + " has been successfuly pulled out!";
                    popupNotifier.Popup();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MarkSelectedBookAsDamagedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MyMessageBox.ShowMessage("Declare selected book as damaged? \n Book penalty is ₱300.00", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblBorrowedBook SET totalFine = totalFine + 300 WHERE borrowID = @borrowID", cn);
                    cm.Parameters.AddWithValue("@borrowID", lblBorrowID.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    StatusDamage();
                    UpdateBookCopies();
                    UpdateAvailableCopies();

                    frmonhand.flowLayoutPanel1.Controls.Clear();
                    frmonhand.BooksOnHand();
                    frmonhand.BooksOverdue();
                    frmonhand.RefreshAll();


                    popupNotifier.ContentText = lblBookName.Text + " has been successfuly pulled out!";
                    popupNotifier.Popup();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
