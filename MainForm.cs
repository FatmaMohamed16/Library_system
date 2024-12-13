using Library_Management_System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();


            LibraryContext context = new LibraryContext();
            var CategoryCount = context.Books.Select(p=>p.Genre).Distinct().Count().ToString();
            label_categories_count.Text = CategoryCount;

            var UsersCount = context.Users.Select(p => p.UserID).Distinct().Count().ToString();
            label_users_count.Text = UsersCount;

            var BooksCount = context.Books.Sum(p => (double?)p.Quantity ?? 0).ToString();
            label_Available_books_count.Text = BooksCount;
        }
        

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_collapse_Click(object sender, EventArgs e)
        {
            if (panel1.Size.Width == 270)
            {
                panel1.Width = 80;
                btn_collapse.Location = new Point(4, 35);
                label_UserName_MainForm.Visible = false;
                pictureBoxUser.Visible = false;

            }
            else
            {
                panel1.Width = 270;
                btn_collapse.Location = new Point(220, 35);
                label_UserName_MainForm.Visible = true;
                pictureBoxUser.Visible = true;

            }




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

        private void btn_OpenBooksForm_Click(object sender, EventArgs e)
        {
            BooksListForm books = new BooksListForm();
            books.ShowDialog();
        }

        private void btn_OpenUsersForm_Click(object sender, EventArgs e)
        {
            ManageUsersForm manageUsers = new ManageUsersForm();
            manageUsers.ShowDialog();
        }
    }
}
