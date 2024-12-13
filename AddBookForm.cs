using Library_Management_System.Data;
using Library_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AddBookForm : Form
    {
        string imagePath;
        public AddBookForm()
        {
            InitializeComponent();
            LibraryContext context = new LibraryContext();

            var genereList = context.Books.Select(x => x.Genre).Distinct().ToArray();
            comboBoxGenre.DataSource = genereList;
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }




        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            LibraryContext context = new LibraryContext();
            
            Book book = new Book();

            //Adding
            var SelectedBook = context.Books.Where(b => b.ISBN == textBoxisban.Text).FirstOrDefault();
            if (SelectedBook != null)
            {
                
                SelectedBook.Quantity += int.Parse(textBoxQuantity.Text);
                context.SaveChanges();
                BooksListForm books = new BooksListForm();
                books.ShowDialog();

                //Reset Fields
                textBoxauthor.Text = "";
                textBoxpublish.Text = "";
                textBoxisban.Text = "";
                textBoxQuantity.Text = "";
                textBoxtittle.Text = "";
                textBoxyear.Text = "";
            }
            else
            {
                book.Author = textBoxauthor.Text;
                book.Publisher = textBoxpublish.Text;
                book.Genre = comboBoxGenre.Text;
                book.ISBN = textBoxisban.Text;
                book.Title = textBoxtittle.Text;
                book.Image = imagePath;
                
                if (mathPattern(textBoxyear.Text, @"^\d*\.?\d+$"))
                    book.PublicationYear = int.Parse(textBoxyear.Text);
                else
                    textBoxyear.Text = "-1";

                if (mathPattern(textBoxQuantity.Text, @"^\d*\.?\d+$"))
                    book.Quantity = int.Parse(textBoxQuantity.Text);
                else
                    textBoxQuantity.Text = "-1";


                if (this.labelisbnMatch.Text == "Not Matched" ||
                    this.labelQuantityMatch.Text == "Not Matched" |
                    this.textBoxtittle.Text == null ||
                    this.textBoxpublish.Text == null ||
                    this.textBoxauthor.Text == null ||
                    this.comboBoxGenre.Text == null ||
                    this.textBoxQuantity.Text == null ||
                    this.textBoxyear.Text == null ||
                    int.Parse(textBoxQuantity.Text) <= 0 ||
                    int.Parse(textBoxyear.Text) <= 0
                    )
                {
                    MessageBox.Show("Invalid Inputs , Please Revise Your Input Values ...");
                }
                else
                {
                    try
                    {
                        context.Books.Add(book);
                        context.SaveChanges();
                        BooksListForm booksForm = new BooksListForm();
                        booksForm.ShowDialog();
                        this.labelQuantityMatch.Visible = false;
                        this.labelQuantityMatch.Visible = false;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error During Adding The Book : " + ex.Message);
                    }
                   
                }


                //Reset Fields
                textBoxauthor.Text = "";
                textBoxpublish.Text = "";
                textBoxisban.Text = "";
                textBoxQuantity.Text = "";
                textBoxtittle.Text = "";
                textBoxyear.Text = "";
            }
        }


        bool mathPattern(string text, string pattern)
        {
            if (Regex.IsMatch(text, pattern))
                return true;
            else
                return false;
        }
        private void textBoxisban_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^b\d+$";

            if (mathPattern(textBoxisban.Text, pattern))
            {
                this.labelisbnMatch.Text = "Matched";
                this.labelisbnMatch.ForeColor = Color.Green;
            }
            else
            {
                this.labelisbnMatch.Text = "Not Matched";
                this.labelisbnMatch.ForeColor = Color.Red;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxauthor.Text = "";
            textBoxpublish.Text = "";
            textBoxisban.Text = "";
            textBoxQuantity.Text = "";
            textBoxtittle.Text = "";
            textBoxyear.Text = "";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtittle_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^\d*\.?\d+$";

            if (mathPattern(textBoxQuantity.Text, pattern))
            {
                this.labelQuantityMatch.Text = "Matched";
                this.labelQuantityMatch.ForeColor = Color.Green;
                this.labelQuantityMatch.Visible = true;
            }
            else
            {
                this.labelQuantityMatch.Text = "Not Matched";
                this.labelQuantityMatch.ForeColor = Color.Red;
                this.labelQuantityMatch.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBoxBookImage.Image = Image.FromFile(openFileDialog.FileName);
                imagePath = openFileDialog.FileName;
                pictureBoxBookImage.ImageLocation = imagePath;
            }
        }
        
        private void imageFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
