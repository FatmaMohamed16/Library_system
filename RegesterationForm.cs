using Library_Management_System.Data;
using Library_Management_System.Models;
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
    public partial class RegesterationForm : Form
    {
        public RegesterationForm()
        {
            InitializeComponent();
            comboBoxRole.Items.Add("Admin");
            comboBoxRole.Items.Add("User");
        }

        private void btn_Close_Register_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            LibraryContext context = new LibraryContext();
            User user = new User();
            user.Username = txt_register_useName.Text;
            user.Email = txt_register_email.Text;
            user.Password = txt_register_password.Text;
            user.Role = comboBoxRole.Text;


            if (context.Users.Where(p => p.Email == txt_register_email.Text).Any())
            {
                MessageBox.Show("Already Existing E-Mail");
            }
            else if (txt_register_password.Text != txt_repeat_password.Text)
                MessageBox.Show("Not-Matched Passwords");
            else
            {
                context.Users.Add(user);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erorr On Regesteration Operation " + ex.Message);
                }
            }
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (register_showPass.Checked == true)
                txt_register_password.PasswordChar = default;
            else
                txt_register_password.PasswordChar = '*';
        }

        private void Confirm_register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (Confirm_register_showPass.Checked == true)
                txt_repeat_password.PasswordChar = default;
            else
                txt_repeat_password.PasswordChar = '*';
        }

        private void txt_repeat_password_TextChanged(object sender, EventArgs e)
        {
            if (txt_repeat_password.Text !=txt_register_password.Text)
            {
                labelMatchPassword.Text = "Not Mathed";
                labelMatchPassword.ForeColor= Color.Red;
            }
            else
            {
                labelMatchPassword.Text = "Mathed";
                labelMatchPassword.ForeColor = Color.Green;
            }
        }
    }
}
