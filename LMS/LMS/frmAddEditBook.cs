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
        SqlDataReader dr;
        frmBook frmlist;

        public frmAddEditBook(frmBook flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmlist = flist;
        }

        private void FrmAddEditBook_Load(object sender, EventArgs e)
        {
            //
        }

        private void Clear()
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtCategory.Text = "";
            txtGenre.Text = "";
            txtISBN.Text = "";
            txtPublisher.Text = "";
            txtPrice.Text = "";
            cboMediaType.Items.Clear();
            txtLanguage.Text = "";
            txtYear.Text = "";
            txtISBN.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this book?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //open connection to the database
                    cn.Open();
                    //command to be executed on the database
                    cm = new SqlCommand("INSERT INTO tblBook (bkISBN, bkTitle, bkCategory, bkGenre, bkMediaType, bkLanguage, bkAuthor, bkPublisher, bkPrice, bkYear)VALUES (@ISBN, @booktitle, @category, @genre, @mediatype, @language, @author, @publisher, @price, @year)", cn);
                    //set parameters value
                    cm.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    cm.Parameters.AddWithValue("@booktitle", txtTitle.Text);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.Parameters.AddWithValue("@genre", txtGenre.Text);
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
                    MessageBox.Show("Record has been sucessfully saved!");
                    Clear();
                    frmlist.LoadRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this book?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //open connection to the database
                    cn.Open();
                    //command to be executed on the database
                    cm = new SqlCommand("UPDATE tblBook SET bkISBN = @ISBN, bkTitle = @booktitle, bkCategory = @category, bkGenre = @genre, bkMediaType = @mediatype, bkLanguage = @language, bkAuthor = @author, bkPublisher = @publisher, bkPrice = @price, bkYear = @year WHERE bookID LIKE '" + lblID + "'", cn);
                    //set parameters value
                    cm.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    cm.Parameters.AddWithValue("@booktitle", txtTitle.Text);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.Parameters.AddWithValue("@genre", txtGenre.Text);
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
                    MessageBox.Show("Record has been successfully saved!");
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

        private void BtnCopies_Click(object sender, EventArgs e)
        {
            frmBookCopies fcopy = new frmBookCopies();
            fcopy.TopLevel = false;
            
            //
        }
    }
}
