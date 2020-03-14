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
        frmBook frmlist;

        public frmAddEditBook(frmBook flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmlist = flist;
            this.dtCreated.Value = DateTime.Now;
        }

        private void FrmAddEditBook_Load(object sender, EventArgs e)
        {
            dtCreated.Enabled = false;
        }

        private void Clear()
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtEdition.Text = "";
            txtGenre.Text = "";
            txtISBN.Text = "";
            txtPublisher.Text = "";
            txtPrice.Text = "";
            cboMediaType.Items.Clear();
            txtLanguage.Text = "";
            dtCreated.Text = "";
            txtISBN.Focus();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this book?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //open connection to the database
                    cn.Open();
                    //command to be executed on the database
                    cm = new SqlCommand("INSERT INTO tblBook (bkISBN, bkTitle, bkEdition, bkGenre, bkMediaType, bkLanguage, bkAuthor, bkPublisher, bkPrice, bkDate)VALUES (@ISBN, @booktitle, @edition, @genre, @mediatype, @language, @author, @publisher, @price, @date)", cn);
                    //set parameters value
                    cm.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    cm.Parameters.AddWithValue("@booktitle", txtTitle.Text);
                    cm.Parameters.AddWithValue("@edition", txtEdition.Text);
                    cm.Parameters.AddWithValue("@genre", txtGenre.Text);
                    cm.Parameters.AddWithValue("@mediatype",cboMediaType.Text);
                    cm.Parameters.AddWithValue("@language", txtLanguage.Text);
                    cm.Parameters.AddWithValue("@author", txtAuthor.Text);
                    cm.Parameters.AddWithValue("@publisher", txtPublisher.Text);
                    cm.Parameters.AddWithValue("@price", txtPrice.Text);
                    cm.Parameters.AddWithValue("@date", dtCreated.Text);
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
    }
}
