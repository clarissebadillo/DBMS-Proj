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
    public partial class frmAddEditBook : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
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
            //
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
                        cm = new SqlCommand("INSERT INTO tblBook (bkTitle, bkSubject, bkGenre, bkMediaType, bkLanguage, bkAuthor, bkPublisher, bkPrice, bkISBN, bkYear, bkAllCopies, bkCopies)  VALUES (@booktitle, @subject, @genre, @mediatype, @language, @author, @publisher, @price, @ISBN, @year, @allcopies, @copies)", cn);
                        //set parameters value
                        cm.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                        cm.Parameters.AddWithValue("@booktitle", txtTitle.Text);
                        cm.Parameters.AddWithValue("@allcopies", txtCopies.Text);
                        cm.Parameters.AddWithValue("@copies", txtCopies.Text);
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

                        popupNotifier.ContentText = txtTitle.Text + "has been successfully added!";
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
                        cm = new SqlCommand("UPDATE tblBook SET bkISBN = @ISBN, bkTitle = @booktitle, bkSubject = @subject, bkGenre = @genre, bkMediaType = @mediatype, bkLanguage = @language, bkAuthor = @author, bkPublisher = @publisher, bkPrice = @price, bkYear = @year WHERE bookID LIKE '" + lblID + "'", cn);
                        cm.Parameters.AddWithValue("@ISBN", txtISBN.Text);
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
