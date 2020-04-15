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
using MyMessage;

namespace LMS
{
    public partial class frmSettings : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        string allowPending;
        string allowOverdue;

        public frmSettings()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
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
                    cm = new SqlCommand("UPDATE tblSettings SET maxBorrowBooks = @maxBorrowBooks, maxBorrowDays = @maxBorrowDays, fine = @fine, withPending = @withPending, withOverdue = @withOverdue", cn);
                    cm.Parameters.AddWithValue("@maxBorrowBooks", txtBorrowBooks.Text);
                    cm.Parameters.AddWithValue("@maxBorrowDays", txtBorrowDays.Text);
                    cm.Parameters.AddWithValue("@fine", txtFine.Text);
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
    }
}
