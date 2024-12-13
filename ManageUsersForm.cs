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
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            LibraryContext context = new LibraryContext();
            var usersGrid = context.Users.ToList();
            dataGridView1.DataSource = usersGrid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryContext context = new LibraryContext();
            User user = new User();


            user.Email = textBoxEmail.Text;
            user.Password = textBoxPassword.Text;
            user.Username = textBoxUserName.Text;
            user.Role = comboBoxRole.Text;
            
            if (context.Users.Where(p=>p.Email == textBoxEmail.Text).Any() )
            {
                MessageBox.Show("Already Existing E-Mail");
            }
            else
            {
                context.Users.Add(user);

                try
                {
                    context.SaveChanges();
                    dataGridView1.DataSource = context.Users.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erorr On Adding Operation " + ex.Message);
                }
            }           
                    
        }



        int selectedIDFromGrid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LibraryContext context = new LibraryContext();
            int selectedUserId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value);
            var selectedUser = context.Users.Find(selectedUserId);
            selectedIDFromGrid = selectedUserId;

            if (selectedUser != null)
            {
                textBoxUserName.Text = selectedUser.Username;
                textBoxEmail.Text = selectedUser.Email;
                comboBoxRole.Text = selectedUser.Role;
                textBoxPassword.Text = selectedUser.Password;
            }
            else
                MessageBox.Show("Invalid Selection");

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            LibraryContext context = new LibraryContext();
            var selectedUser = context.Users.Find(selectedIDFromGrid);
            if (selectedUser != null)
            {
                selectedUser.Email = textBoxEmail.Text;
                selectedUser.Password = textBoxPassword.Text;
                selectedUser.Username = textBoxUserName.Text;
                selectedUser.Role = comboBoxRole.Text;

                try
                {
                    context.SaveChanges();
                    dataGridView1.DataSource = context.Users.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erorr On Savind Edit Operation " + ex.Message);
                }




            }
            else
                MessageBox.Show("Invalid Selection");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            LibraryContext context = new LibraryContext();
            var selectedUser = context.Users.Find(selectedIDFromGrid);
            if (selectedUser != null)
            {
                textBoxEmail.Text = "";
                textBoxPassword.Text = "";
                textBoxUserName.Text = "";
                comboBoxRole.Text = "";
                context.Users.Remove(selectedUser);

                try
                {
                    context.SaveChanges();
                    dataGridView1.DataSource = context.Users.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erorr On Savind Edit Operation " + ex.Message);
                }




            }
            else
                MessageBox.Show("Invalid Selection");
        }
    }
    
}
