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
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel_progress_Start.Width += 6;
            if (panel_progress_Start.Width >= 799)
            {
                timer1.Stop();

                LibraryContext context = new LibraryContext();
                if (context.Users.Where(p=>p.Role =="Admin").FirstOrDefault() != null)
                {
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.WindowState = FormWindowState.Minimized;
                }
                else
                {
                    RegesterationForm RegForm = new RegesterationForm();
                    RegForm.Show();
                    this.WindowState = FormWindowState.Minimized;
                }
                
            }
        }

        private void btn_Close_Login_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
