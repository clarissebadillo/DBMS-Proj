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
    public partial class frmAddBook : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmListOfBooks frmlist;

        public frmAddBook(frmListOfBooks flist)
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

        private void Clear()
        {
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
            if (txtTitle.Text == "")
            {
                txtTitle.Focus();
                MessageBox.Show("Please add the book title", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to save this book?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                        popupNotifier.ContentText = txtTitle.Text + " has been successfully added!";
                        popupNotifier.Popup();

                        Clear();
                        frmlist.RetrieveBook();

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
            if (txtTitle.Text == "")
            {
                txtTitle.Focus();
                MessageBox.Show("Please add the book title", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to update this book?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
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
                        this.Close();
                        frmlist.RetrieveBook();

                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
