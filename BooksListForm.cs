using Library_Management_System.Data;
using Library_Management_System.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class BooksListForm : Form
    {

        int BookIdFrom_DGV;

        public BooksListForm()
        {
            InitializeComponent();
            MainForm form = new MainForm();
            if (form.labelRole.Text != "Admin")
            {
                btnDelete.Enabled = false;
                btnDelete.Enabled = false;
            }

            else
            {
                
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }

        }




        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int selectedBookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            try
            {
                int selectedBookId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["BookID"].Value);
                BookIdFrom_DGV = selectedBookId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Selection");
            }

        }


        private void BooksListForm_Load(object sender, EventArgs e)
        {
            LibraryContext context = new LibraryContext();
            var allbooks = context.Books.ToList();
            dataGridView1.DataSource = allbooks;
        }

        private void btn_Maxmize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {


            LibraryContext context = new LibraryContext();
            var selected_Book = context.Books.Where(x => x.BookID == BookIdFrom_DGV).FirstOrDefault();
            if (selected_Book != null)
            {
                if (selected_Book.Image != null)
                {
                    EditBookForm editBookForm = new EditBookForm(BookIdFrom_DGV, selected_Book.Image);
                    editBookForm.textBoxisban.Text = selected_Book.ISBN.ToString();
                    editBookForm.textBoxtittle.Text = selected_Book.Title;
                    editBookForm.textBoxauthor.Text = selected_Book.Author;
                    editBookForm.comboBoxGenre.Text = selected_Book.Genre;
                    editBookForm.textBoxpublish.Text = selected_Book.Publisher;
                    editBookForm.textBoxyear.Text = selected_Book.PublicationYear.ToString();
                    editBookForm.textBoxQuantity.Text = selected_Book.Quantity.ToString();
                    editBookForm.ShowDialog();
                }
                else
                {
                    string img_def_Path = "D:\\MY-ITI-Library-Project\\Library-Management-System-ITI-Project\\Resources\\2tuju-19.jpg";
                    EditBookForm editBookForm = new EditBookForm(BookIdFrom_DGV, img_def_Path);
                    editBookForm.textBoxisban.Text = selected_Book.ISBN.ToString();
                    editBookForm.textBoxtittle.Text = selected_Book.Title;
                    editBookForm.textBoxauthor.Text = selected_Book.Author;
                    editBookForm.comboBoxGenre.Text = selected_Book.Genre;
                    editBookForm.textBoxpublish.Text = selected_Book.Publisher;
                    editBookForm.textBoxyear.Text = selected_Book.PublicationYear.ToString();
                    editBookForm.textBoxQuantity.Text = selected_Book.Quantity.ToString();
                    editBookForm.ShowDialog();
                }
            }
            else
                MessageBox.Show("Please Select a Book to Edit...");


        }
        public int BookIdSelectedFromGrid;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LibraryContext context = new LibraryContext();
            var selected_Book = context.Books.Where(x => x.BookID == BookIdFrom_DGV).FirstOrDefault();
            if (selected_Book != null)
            {
                context.Books.Remove(selected_Book);
                try
                {
                    context.SaveChanges();
                    dataGridView1.DataSource = context.Books.ToList();
                    MessageBox.Show("Successfully Deleted...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error occurred while Deleting: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invaild ID");
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
