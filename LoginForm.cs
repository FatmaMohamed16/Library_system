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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Close_Login_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegesterationForm regesterationForm = new RegesterationForm();
            regesterationForm.Show();
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LibraryContext context = new LibraryContext();
            var user = context.Users.Where(p => p.Email == textBox_user_Email_login.Text).FirstOrDefault();
            if ( user != null )
            {
                MainForm form = new MainForm();
                if (user.Role == "Admin")
                {
                    form.labelRole.Text = "Admin";
                    form.label_UserName_MainForm.Text = user.Username;
                    form.pictureBoxUser.Image = Properties.Resources.admin;
                    form.Show();
                    this.Hide();
                }
                else
                {
                    form.btn_OpenUsersForm.Enabled = false;
                    form.btn_addBook.Enabled = false;
                    form.labelRole.Text = "User";
                    form.label_UserName_MainForm.Text= user.Username;
                    form.pictureBoxUser.Image = Properties.Resources.profile;
                    form.Show();
                    this.Hide();
                }
                
            }
            else
            {
                MessageBox.Show("User Not Found , Please Ask an Admin To Add You...");
            }



           
        }
    }
}
