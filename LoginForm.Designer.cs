namespace Library_Management_System
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Close_Login = new Button();
            label1 = new Label();
            textBox_user_Email_login = new TextBox();
            textBox_Password_login = new TextBox();
            btn_login = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Close_Login
            // 
            btn_Close_Login.BackColor = Color.FromArgb(62, 73, 73);
            btn_Close_Login.FlatStyle = FlatStyle.Flat;
            btn_Close_Login.ForeColor = Color.White;
            btn_Close_Login.Location = new Point(399, 0);
            btn_Close_Login.Margin = new Padding(4, 5, 4, 5);
            btn_Close_Login.Name = "btn_Close_Login";
            btn_Close_Login.Size = new Size(72, 32);
            btn_Close_Login.TabIndex = 1;
            btn_Close_Login.Text = "X";
            btn_Close_Login.UseVisualStyleBackColor = false;
            btn_Close_Login.Click += btn_Close_Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 262);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(369, 52);
            label1.TabIndex = 2;
            label1.Text = "Login To Your Account";
            // 
            // textBox_user_Email_login
            // 
            textBox_user_Email_login.Font = new Font("Segoe Print", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_user_Email_login.Location = new Point(38, 366);
            textBox_user_Email_login.Margin = new Padding(4, 5, 4, 5);
            textBox_user_Email_login.Name = "textBox_user_Email_login";
            textBox_user_Email_login.Size = new Size(383, 46);
            textBox_user_Email_login.TabIndex = 5;
            textBox_user_Email_login.Text = "Email";
            // 
            // textBox_Password_login
            // 
            textBox_Password_login.Font = new Font("Segoe Print", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Password_login.Location = new Point(38, 451);
            textBox_Password_login.Margin = new Padding(4, 5, 4, 5);
            textBox_Password_login.Name = "textBox_Password_login";
            textBox_Password_login.Size = new Size(383, 46);
            textBox_Password_login.TabIndex = 6;
            textBox_Password_login.Text = "Password";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(62, 73, 73);
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(144, 552);
            btn_login.Margin = new Padding(4, 5, 4, 5);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(171, 52);
            btn_login.TabIndex = 7;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.LetsMoveIcon;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(149, 165, 165);
            ClientSize = new Size(471, 789);
            Controls.Add(btn_login);
            Controls.Add(textBox_Password_login);
            Controls.Add(textBox_user_Email_login);
            Controls.Add(label1);
            Controls.Add(btn_Close_Login);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Close_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_user_Email_login;
        private System.Windows.Forms.TextBox textBox_Password_login;
        private System.Windows.Forms.Button btn_login;
    }
}