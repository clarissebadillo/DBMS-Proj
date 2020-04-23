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
using MyMessage;

namespace LMS
{
    public partial class frmAddEditBook : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmBookList frmlist;

        public frmAddEditBook(frmBookList flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmlist = flist;
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

        private void FrmAddEditBook_Load(object sender, EventArgs e)
        {
            LoadSubjects();

            List<string> genre = new List<string>();
            genre.Add("Fiction");
            genre.Add("Non-Fiction");
            cboGenre.DataSource = genre;

            List<string> mediaType = new List<string>();
            mediaType.Add("Book");
            mediaType.Add("DVD");
            mediaType.Add("Magazine");
            cboMediaType.DataSource = mediaType;
        }

        void LoadSubjects()
        {
            List<string> subj = new List<string>();
            cn.Open();
            cm = new SqlCommand("SELECT subject FROM tblSubjects", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                subj.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
            subj.Add("Others");
            cboSubject.DataSource = subj;
        }

        private void Clear()
        {
            frmlist.lblAuthor.Text = "";
            frmlist.lblBookTitle.Text = "";
            frmlist.lblGenre.Text = "";
            frmlist.lblISBN.Text = "";
            frmlist.lblLanguage.Text = "";
            frmlist.lblMediaType.Text = "";
            frmlist.lblPrice.Text = "";
            frmlist.lblPublisher.Text = "";
            frmlist.lblSubject.Text = "";
            frmlist.lblYear.Text = "";

            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtISBN.Text = "";
            txtPublisher.Text = "";
            txtPrice.Text = "";
            txtLanguage.Text = "";
            txtYear.Text = "";
            txtCopies.Text = "";
            cboGenre.SelectedIndex = -1;
            cboMediaType.SelectedIndex = -1;
            cboSubject.SelectedIndex = -1;
            txtISBN.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtAuthor.Text == "" || txtISBN.Text == "" || txtPublisher.Text == "" || txtPrice.Text == "" || txtLanguage.Text == "" || txtLanguage.Text == "" || txtLanguage.Text == "" || txtLanguage.Text == "" || txtYear.Text == "" || txtCopies.Text == "" || cboGenre.Text == "" || cboMediaType.Text == "" || cboSubject.Text == "")
            {
                txtTitle.Focus();
                MyMessageBox.ShowMessage("Please don't leave blank spaces! Add 'NA' for blank spaces instead.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (MyMessageBox.ShowMessage("Are you sure you want to add " + txtTitle.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //open connection to the database
                        cn.Open();
                        //command to be executed on the database
                        cm = new SqlCommand("INSERT INTO tblBook (bookTitle, bookISBN, subject, genre, mediaType, language, author, publisher, price, pubYear, allCopies, availableCopies)  VALUES (@booktitle, @bookisbn, @subject, @genre, @mediatype, @language, @author, @publisher, @price, @year, @allcopies, @available)", cn);
                        //set parameters value
                        cm.Parameters.AddWithValue("@bookisbn", txtISBN.Text);
                        cm.Parameters.AddWithValue("@booktitle", txtTitle.Text);
                        cm.Parameters.AddWithValue("@allcopies", txtCopies.Text);
                        cm.Parameters.AddWithValue("@available", txtCopies.Text);
                        cm.Parameters.AddWithValue("@subject", cboSubject.Text);
                        cm.Parameters.AddWithValue("@genre", cboGenre.Text);
                        cm.Parameters.AddWithValue("@mediatype", cboMediaType.Text);
                        cm.Parameters.AddWithValue("@language", txtLanguage.Text);
                        cm.Parameters.AddWithValue("@author", txtAuthor.Text);
                        cm.Parameters.AddWithValue("@publisher", txtPublisher.Text);
                        cm.Parameters.AddWithValue("@price", txtPrice.Text);
                        cm.Parameters.AddWithValue("@year", txtYear.Text);
                        //ask db to execute query
                        cm.ExecuteNonQuery();
                        //close connection
                        cn.Close();
                        Logs();

                        popupNotifier.ContentText = txtTitle.Text + " has been successfully added!";
                        popupNotifier.Popup();
                        Clear();
                        frmlist.LoadRecords();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtAuthor.Text == "" || txtISBN.Text == "" || txtPublisher.Text == "" || txtPrice.Text == "" || txtLanguage.Text == "" || txtLanguage.Text == "" || txtLanguage.Text == "" || txtLanguage.Text == "" || txtYear.Text == "" || txtCopies.Text == "" || cboGenre.Text == "" || cboMediaType.Text == "" || cboSubject.Text == "")
            {
                txtTitle.Focus();
                MyMessageBox.ShowMessage("Please don't leave blank spaces! Add 'NA' for blank spaces instead.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (MyMessageBox.ShowMessage("Are you sure you want to update " + txtTitle.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        UpdateBookLogs();
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblBook SET bookISBN = @bookisbn, bookTitle = @booktitle, subject = @subject, genre = @genre, mediaType = @mediatype, language = @language, author = @author, publisher = @publisher, price = @price, pubyear = @year WHERE bookID LIKE '" + lblID.Text + "'", cn);
                        cm.Parameters.AddWithValue("@bookisbn", txtISBN.Text);
                        cm.Parameters.AddWithValue("@booktitle", txtTitle.Text);
                        cm.Parameters.AddWithValue("@subject", cboSubject.Text);
                        cm.Parameters.AddWithValue("@genre", cboGenre.Text);
                        cm.Parameters.AddWithValue("@mediatype", cboMediaType.Text);
                        cm.Parameters.AddWithValue("@language", txtLanguage.Text);
                        cm.Parameters.AddWithValue("@author", txtAuthor.Text);
                        cm.Parameters.AddWithValue("@publisher", txtPublisher.Text);
                        cm.Parameters.AddWithValue("@price", txtPrice.Text);
                        cm.Parameters.AddWithValue("@year", txtYear.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        popupNotifier.ContentText = txtTitle.Text + " has been successfully updated!";
                        popupNotifier.Popup();
                        Clear();
                        frmlist.LoadRecords();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TxtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
            {
                //accept . character
            }
            else if (e.KeyChar == 8)
            {
                //accept backspace
            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57)) //ascii code 48-57 between 0-99
            {
                e.Handled = true;
            }
        }

        private void TxtCopies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        void Logs()
        {
            var details = lblLibrarian.Text + " added a new stock of book (" + txtTitle.Text + ") with " + txtCopies.Text + " copies";

            cn.Open();
            cm = new SqlCommand("INSERT INTO tblLogs VALUES (@details, GETDATE())", cn);
            cm.Parameters.AddWithValue("@details", details);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        void UpdateBookLogs()
        {
            var details = lblLibrarian.Text + " updated the book details of " + txtTitle.Text + "";

            cn.Open();
            cm = new SqlCommand("INSERT INTO tblLogs VALUES (@details, GETDATE())", cn);
            cm.Parameters.AddWithValue("@details", details);
            cm.ExecuteNonQuery();
            cn.Close();
        }
    }
}
