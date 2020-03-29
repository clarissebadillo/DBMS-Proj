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

namespace LMS
{
    public partial class frmBooksOnHand : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmIssueBook frmissue;

        int rowIndex = 0;
        int fine = 5;

        public frmBooksOnHand(frmIssueBook fissue)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmissue = fissue;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GunaDataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.gunaDataGridView1.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.gunaContextMenuStrip1.Show(this.gunaDataGridView1, e.Location);
                this.gunaContextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void UpdateStatus()
        {
            cn.Open();
            cm = new SqlCommand("UPDATE tblBorrowedBook SET status = 'Returned' WHERE borrowID = @borrowID", cn);
            cm.Parameters.AddWithValue("@borrowID", lblID.Text);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        public void RetreiveBook()
        {
            cn.Open();
            cm = new SqlCommand("UPDATE tblBook SET availableCopies = availableCopies + 1 WHERE bookTitle = @bookTitle", cn);
            cm.Parameters.AddWithValue("@bookTitle", lblBookTitle.Text);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        public void RefreshBooksOnHand()
        {
            frmissue.gunaDataGridView1.Rows.Clear();
            int i = 0;
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblBorrowedBook WHERE status = 'Not Returned' AND studentNum = @studentNum", cn);
            cm.Parameters.AddWithValue("@studentNum", frmissue.lblStudNo.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                gunaDataGridView1.Rows.Add(i, dr["borrowID"].ToString(), dr["studentID"].ToString(), dr["bookID"].ToString(), dr["studentNum"].ToString(), dr["bookTitle"].ToString(), Convert.ToDateTime(dr["dateBorrowed"]).ToString("MM/dd/yyyy"), Convert.ToDateTime(dr["dueDate"]).ToString("MM/dd/yyyy"), dr["returnedDate"].ToString(), dr["status"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void CalculateFine()
        {
            DateTime dueDate = new DateTime();
            DateTime returnDate = new DateTime();
            dueDate = frmissue.dtDueDate.Value;
            returnDate = DateTime.Now;
            TimeSpan diff = returnDate.Subtract(dueDate);
            int days = diff.Days;
            fine = days * 5;

            cn.Open();
            cm = new SqlCommand("INSERT INTO tblFine VALUES (@borrowID, @studentID, @totalFine)", cn);
            cm.Parameters.AddWithValue("@borrowID", lblID.Text);
            cm.Parameters.AddWithValue("@studentID", lblStudentID.Text);
            cm.Parameters.AddWithValue("@totalFine", fine);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        private void ReturnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Receive selected book?", "Receiving Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblBorrowedBook SET returnedDate = GETDATE() WHERE borrowID ='" + lblID.Text + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    UpdateStatus();
                    RetreiveBook();

                    gunaDataGridView1.Rows.Clear();
                    RefreshBooksOnHand();
                    CalculateFine();

                    frmissue.Clear();
                    frmissue.LoadDetails();
                    frmissue.BooksOnHand();
                    frmissue.LoadRecords();
                    frmissue.CountFine();

                    popupNotifier.ContentText = lblBookTitle.Text + " has been successfuly returned!";
                    popupNotifier.Popup();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = gunaDataGridView1[1, e.RowIndex].Value.ToString();
            lblStudentID.Text = gunaDataGridView1[2, e.RowIndex].Value.ToString();
            lblBookID.Text = gunaDataGridView1[3, e.RowIndex].Value.ToString();
            lblBookTitle.Text = gunaDataGridView1[5, e.RowIndex].Value.ToString();
            lblDateBorrowed.Text = gunaDataGridView1[6, e.RowIndex].Value.ToString();
            lblDueDate.Text = gunaDataGridView1[7, e.RowIndex].Value.ToString();
        }
    }
}
