using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using MyMessage;

namespace LMS
{
    public partial class frmSettings : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        Form1 frm1;

        string allowPending;
        string allowOverdue;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      // WS_EX_COMPOSITED
                return handleParam;
            }
        }

        public frmSettings(Form1 f1)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frm1 = f1;
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            LoadSettings();
            Toggle();

            LoadPrograms();
            btnProgUpdate.Enabled = false;

            LoadSubjects();
            btnSubjUpdate.Enabled = false;
        }

        void Toggle()
        {
            if (tglWithPending.Checked == true)
            {
                allowPending = "True";
            }
            else if (tglWithPending.Checked == false)
            {
                allowPending = "False";
            }

            if (tglWithOverdue.Checked == true)
            {
                allowOverdue = "True";
            }
            else if (tglWithOverdue.Checked == false)
            {
                allowOverdue = "False";
            }
        }

        void Clear()
        {
            txtBorrowBooks.Clear();
            txtBorrowDays.Clear();
            txtFine.Clear();
        }

        void UpdateSettings()
        {
            Toggle();

            try
            {
                if (MyMessageBox.ShowMessage("Are you sure you want to save the following settings?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblSettings SET maxBorrowBooks = @maxBorrowBooks, maxBorrowDays = @maxBorrowDays, fine = @fine, damagedBook = @damagedBook, lostBook = @lostBook, withPending = @withPending, withOverdue = @withOverdue", cn);
                    cm.Parameters.AddWithValue("@maxBorrowBooks", txtBorrowBooks.Text);
                    cm.Parameters.AddWithValue("@maxBorrowDays", txtBorrowDays.Text);
                    cm.Parameters.AddWithValue("@fine", txtFine.Text);
                    cm.Parameters.AddWithValue("@damagedBook", txtDamage.Text);
                    cm.Parameters.AddWithValue("@lostBook", txtLostBook.Text);
                    cm.Parameters.AddWithValue("@withPending", allowPending);
                    cm.Parameters.AddWithValue("@withOverdue", allowOverdue);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MyMessageBox.ShowMessage("Settings has been successfully saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadSettings()
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblSettings", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtBorrowBooks.Text = dr["maxBorrowBooks"].ToString();
                txtBorrowDays.Text = dr["maxBorrowDays"].ToString();
                txtDamage.Text = dr["damagedBook"].ToString();
                txtLostBook.Text = dr["lostBook"].ToString();
                txtFine.Text = dr["fine"].ToString();
                allowPending = dr["withPending"].ToString();
                allowOverdue = dr["withOverdue"].ToString();
                

                if (allowPending == "True")
                {
                    tglWithPending.Checked = true;
                }
                else if (allowPending == "False")
                {
                    tglWithPending.Checked = false;
                }

                if (allowOverdue == "True")
                {
                    tglWithOverdue.Checked = true;
                }
                else if (allowOverdue == "False")
                {
                    tglWithOverdue.Checked = false;
                }
            }
            dr.Close();
            cn.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSettings();
            UpdateLogs();
            Clear();
            LoadSettings();
        }


        //PROGRAM TAB
        void ClearProgram()
        {
            txtCode.Clear();
            txtDesc.Clear();
        }

        void LoadPrograms()
        {
            int i = 0;
            programList.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblPrograms", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                programList.Rows.Add(i, dr["programID"].ToString(), dr["code"].ToString(), dr["description"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void BtnProgSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MyMessageBox.ShowMessage("Are you sure you want to save " + txtCode.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblPrograms VALUES (@code, @description)", cn);
                    cm.Parameters.AddWithValue("@code", txtCode.Text);
                    cm.Parameters.AddWithValue("@description", txtDesc.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    LoadPrograms();
                    ClearProgram();

                    MyMessageBox.ShowMessage("Program has been successfully saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProgramList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = programList.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                txtCode.Focus();
                btnProgSave.Enabled = false;
                btnProgUpdate.Enabled = true;
                lblProgID.Text = programList[1, e.RowIndex].Value.ToString();
                txtCode.Text = programList[2, e.RowIndex].Value.ToString();
                txtDesc.Text = programList[3, e.RowIndex].Value.ToString();
            }
            else if (colName == "Delete")
            {
                if (MyMessageBox.ShowMessage("Are you sure you want to remove this program?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblPrograms WHERE programID LIKE '" + programList[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MyMessageBox.ShowMessage("Program has been successfully removed!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPrograms();
                }
            }
        }

        private void BtnProgUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MyMessageBox.ShowMessage("Are you sure you want to update " + txtCode.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblPrograms SET code = @code, description = @description WHERE programID = @programID", cn);
                    cm.Parameters.AddWithValue("@code", txtCode.Text);
                    cm.Parameters.AddWithValue("@description", txtDesc.Text);
                    cm.Parameters.AddWithValue("programID", lblProgID.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    LoadPrograms();
                    
                    MyMessageBox.ShowMessage("Program has been successfully updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnProgUpdate.Enabled = false;
                    btnProgSave.Enabled = true;
                    ClearProgram();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnProgClear_Click(object sender, EventArgs e)
        {
            ClearProgram();
        }


        //SUBJECT TAB
        void ClearSubject()
        {
            txtSubject.Clear();
        }

        void LoadSubjects()
        {
            int i = 0;
            subjectList.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblSubjects", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                subjectList.Rows.Add(i, dr["subjectID"].ToString(), dr["subject"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void BtnSubjSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MyMessageBox.ShowMessage("Are you sure you want to save " + txtSubject.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblSubjects VALUES (@subject)", cn);
                    cm.Parameters.AddWithValue("@subject", txtSubject.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    LoadSubjects();
                    ClearSubject();

                    MyMessageBox.ShowMessage("Subject has been successfully saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SubjectList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = subjectList.Columns[e.ColumnIndex].Name;
            if (colName == "EditSub")
            {
                txtSubject.Focus();
                btnSubjSave.Enabled = false;
                btnSubjUpdate.Enabled = true;
                lblSubjectID.Text = subjectList[1, e.RowIndex].Value.ToString();
                txtSubject.Text = subjectList[2, e.RowIndex].Value.ToString();
            }
            else if (colName == "DeleteSub")
            {
                if (MyMessageBox.ShowMessage("Are you sure you want to remove this subject?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblSubjects WHERE subjectID LIKE '" + subjectList[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MyMessageBox.ShowMessage("Subject has been successfully removed!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSubjects();
                }
            }
        }

        private void BtnSubjUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MyMessageBox.ShowMessage("Are you sure you want to update " + txtSubject.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblSubjects SET subject = @subject WHERE subjectID = @subjectID", cn);
                    cm.Parameters.AddWithValue("@subjectID", lblSubjectID.Text);
                    cm.Parameters.AddWithValue("@subject", txtSubject.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    LoadSubjects();

                    MyMessageBox.ShowMessage("Subject has been successfully updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnSubjUpdate.Enabled = false;
                    btnSubjSave.Enabled = true;
                    ClearSubject();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSubjClear_Click(object sender, EventArgs e)
        {
            ClearSubject();
        }

        void UpdateLogs()
        {
            var details = frm1.lblLibrarian.Text + " updated the library setup settings";

            cn.Open();
            cm = new SqlCommand("INSERT INTO tblLogs VALUES (@details, GETDATE())", cn);
            cm.Parameters.AddWithValue("@details", details);
            cm.ExecuteNonQuery();
            cn.Close();
        }


        //BACKUP DATA
        private DataTable GetStudents()
        {
            cn.Open();
            cm = new SqlCommand("SELECT studentNum, (lastName + ' ' + firstName) AS name, course, year, gender, contact, email, address FROM tblStudent", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            
            return dt;
        }

        private DataTable GetBooks()
        {
            cn.Open();
            cm = new SqlCommand("SELECT bookTitle, bookISBN, subject, genre, mediaType, language, author, publisher, price, pubYear, allCopies, availableCopies FROM tblBook", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();

            return dt;
        }

        private DataTable GetIssuedBooks()
        {
            cn.Open();
            cm = new SqlCommand("SELECT b.studentNum, (s.lastName + ' ' + firstName) AS name, b.bookTitle, b.dateBorrowed, b.dueDate, b.returnedDate, b.status, b.totalFine, b.paymentStatus, b.librarian FROM tblBorrowedBook b INNER JOIN tblStudent s ON b.studentID = s.studentID", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();

            return dt;
        }

        private DataTable GetPayments()
        {
            cn.Open();
            cm = new SqlCommand("SELECT (s.lastName + ' ' + s.firstName) AS name, p.totalPayment, p.paymentDate, p.summaryDesc, p.librarian FROM tblPayment p INNER JOIN tblStudent s ON p.studentID = s.studentID", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();

            return dt;
        }

        public DataSet ExportToExcel()
        {
            DataSet ds = new DataSet();

            DataTable dtStudents = new DataTable("Students");
            dtStudents = GetStudents();

            DataTable dtBooks = new DataTable("Books");
            dtBooks = GetBooks();

            DataTable dtIssuedBooks = new DataTable("Issued Books");
            dtIssuedBooks = GetIssuedBooks();

            DataTable dtPayments = new DataTable("Payments");
            dtPayments = GetPayments();

            ds.Tables.Add(dtStudents);
            ds.Tables.Add(dtBooks);
            ds.Tables.Add(dtIssuedBooks);
            ds.Tables.Add(dtPayments);

            return ds;
        }

        void ClearCB()
        {
            cbBooks.Checked = false;
            cbPayments.Checked = false;
            cbBorrowedBooks.Checked = false;
            cbStudents.Checked = false;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (cbPayments.Checked == false && cbStudents.Checked == false && cbBooks.Checked == false && cbBorrowedBooks.Checked == false)
            {
                MyMessageBox.ShowMessage("Please select the data to backup!", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel files|*.xlsx";
                sfd.Title = "Save an Excel File";
                sfd.FileName = "Database backup";

                DataSet ds = ExportToExcel();

                using (XLWorkbook wb = new XLWorkbook())
                {
                    if (cbStudents.Checked == true)
                    {
                        var ws = wb.Worksheets.Add(ds.Tables[0], "Students");
                        ws.Columns().AdjustToContents();
                    }
                    if (cbBooks.Checked == true)
                    {
                        var ws = wb.Worksheets.Add(ds.Tables[1], "Books");
                        ws.Columns().AdjustToContents();
                    }
                    if (cbBorrowedBooks.Checked == true)
                    {
                        var ws = wb.Worksheets.Add(ds.Tables[2], "Issued Books");
                        ws.Columns().AdjustToContents();
                    }
                    if (cbPayments.Checked == true)
                    {
                        var ws = wb.Worksheets.Add(ds.Tables[3], "Payments");
                        ws.Columns().AdjustToContents();
                    }

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        sfd.InitialDirectory = Environment.GetFolderPath
                                    (Environment.SpecialFolder.Desktop);

                        wb.SaveAs(sfd.FileName);
                        MyMessageBox.ShowMessage("Data successfully backed up!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearCB();
                        wb.Dispose();
                    }
                }
            }

        }

    }
}
