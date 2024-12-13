namespace Library_Management_System
{
    partial class RegesterationForm
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
            txt_register_email = new TextBox();
            label6 = new Label();
            register_showPass = new CheckBox();
            signIn_btn = new Button();
            register_btn = new Button();
            txt_register_password = new TextBox();
            label4 = new Label();
            txt_register_useName = new TextBox();
            label3 = new Label();
            btn_Close_Register = new Button();
            pictureBox1 = new PictureBox();
            Confirm_register_showPass = new CheckBox();
            txt_repeat_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxRole = new ComboBox();
            labelMatchPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_register_email
            // 
            txt_register_email.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_register_email.Location = new Point(48, 174);
            txt_register_email.Margin = new Padding(4, 5, 4, 5);
            txt_register_email.Multiline = true;
            txt_register_email.Name = "txt_register_email";
            txt_register_email.Size = new Size(373, 44);
            txt_register_email.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 142);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(156, 27);
            label6.TabIndex = 32;
            label6.Text = "Email Address:";
            // 
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_showPass.Location = new Point(269, 387);
            register_showPass.Margin = new Padding(4, 5, 4, 5);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(148, 25);
            register_showPass.TabIndex = 31;
            register_showPass.Text = "Show Password";
            register_showPass.UseVisualStyleBackColor = true;
            register_showPass.CheckedChanged += register_showPass_CheckedChanged;
            // 
            // signIn_btn
            // 
            signIn_btn.BackColor = Color.FromArgb(62, 73, 73);
            signIn_btn.Cursor = Cursors.Hand;
            signIn_btn.FlatAppearance.BorderSize = 0;
            signIn_btn.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            signIn_btn.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            signIn_btn.FlatStyle = FlatStyle.Flat;
            signIn_btn.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signIn_btn.ForeColor = Color.White;
            signIn_btn.Location = new Point(51, 705);
            signIn_btn.Margin = new Padding(4, 5, 4, 5);
            signIn_btn.Name = "signIn_btn";
            signIn_btn.Size = new Size(375, 46);
            signIn_btn.TabIndex = 45;
            signIn_btn.Text = "Go To SIGN IN";
            signIn_btn.UseVisualStyleBackColor = false;
            signIn_btn.Click += signIn_btn_Click;
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(62, 73, 73);
            register_btn.Cursor = Cursors.Hand;
            register_btn.FlatAppearance.BorderSize = 0;
            register_btn.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            register_btn.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_btn.ForeColor = Color.White;
            register_btn.Location = new Point(51, 610);
            register_btn.Margin = new Padding(4, 5, 4, 5);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(375, 61);
            register_btn.TabIndex = 44;
            register_btn.Text = "REGISTER";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // txt_register_password
            // 
            txt_register_password.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_register_password.Location = new Point(51, 341);
            txt_register_password.Margin = new Padding(4, 5, 4, 5);
            txt_register_password.Multiline = true;
            txt_register_password.Name = "txt_register_password";
            txt_register_password.PasswordChar = '*';
            txt_register_password.Size = new Size(373, 44);
            txt_register_password.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 308);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 27);
            label4.TabIndex = 26;
            label4.Text = "Password:";
            // 
            // txt_register_useName
            // 
            txt_register_useName.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_register_useName.Location = new Point(51, 261);
            txt_register_useName.Margin = new Padding(4, 5, 4, 5);
            txt_register_useName.Multiline = true;
            txt_register_useName.Name = "txt_register_useName";
            txt_register_useName.Size = new Size(373, 44);
            txt_register_useName.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 227);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 27);
            label3.TabIndex = 24;
            label3.Text = "Username:";
            // 
            // btn_Close_Register
            // 
            btn_Close_Register.BackColor = Color.FromArgb(62, 73, 73);
            btn_Close_Register.FlatStyle = FlatStyle.Flat;
            btn_Close_Register.Location = new Point(399, 0);
            btn_Close_Register.Margin = new Padding(4, 5, 4, 5);
            btn_Close_Register.Name = "btn_Close_Register";
            btn_Close_Register.Size = new Size(72, 32);
            btn_Close_Register.TabIndex = 35;
            btn_Close_Register.Text = "X";
            btn_Close_Register.UseVisualStyleBackColor = false;
            btn_Close_Register.Click += btn_Close_Register_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.LetsMoveIcon;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // Confirm_register_showPass
            // 
            Confirm_register_showPass.AutoSize = true;
            Confirm_register_showPass.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Confirm_register_showPass.Location = new Point(271, 469);
            Confirm_register_showPass.Margin = new Padding(4, 5, 4, 5);
            Confirm_register_showPass.Name = "Confirm_register_showPass";
            Confirm_register_showPass.Size = new Size(148, 25);
            Confirm_register_showPass.TabIndex = 38;
            Confirm_register_showPass.Text = "Show Password";
            Confirm_register_showPass.UseVisualStyleBackColor = true;
            Confirm_register_showPass.CheckedChanged += Confirm_register_showPass_CheckedChanged;
            // 
            // txt_repeat_password
            // 
            txt_repeat_password.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_repeat_password.Location = new Point(53, 422);
            txt_repeat_password.Margin = new Padding(4, 5, 4, 5);
            txt_repeat_password.Multiline = true;
            txt_repeat_password.Name = "txt_repeat_password";
            txt_repeat_password.PasswordChar = '*';
            txt_repeat_password.Size = new Size(373, 44);
            txt_repeat_password.TabIndex = 37;
            txt_repeat_password.TextChanged += txt_repeat_password_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 390);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 27);
            label1.TabIndex = 36;
            label1.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 486);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 27);
            label2.TabIndex = 39;
            label2.Text = "Role :";
            // 
            // comboBoxRole
            // 
            comboBoxRole.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(53, 528);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(364, 31);
            comboBoxRole.TabIndex = 41;
            // 
            // labelMatchPassword
            // 
            labelMatchPassword.AutoSize = true;
            labelMatchPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelMatchPassword.Location = new Point(114, 471);
            labelMatchPassword.Name = "labelMatchPassword";
            labelMatchPassword.Size = new Size(0, 28);
            labelMatchPassword.TabIndex = 46;
            // 
            // RegesterationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(149, 165, 165);
            ClientSize = new Size(471, 789);
            Controls.Add(labelMatchPassword);
            Controls.Add(comboBoxRole);
            Controls.Add(label2);
            Controls.Add(Confirm_register_showPass);
            Controls.Add(txt_repeat_password);
            Controls.Add(label1);
            Controls.Add(btn_Close_Register);
            Controls.Add(pictureBox1);
            Controls.Add(txt_register_email);
            Controls.Add(label6);
            Controls.Add(register_showPass);
            Controls.Add(signIn_btn);
            Controls.Add(register_btn);
            Controls.Add(txt_register_password);
            Controls.Add(label4);
            Controls.Add(txt_register_useName);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "RegesterationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Regesteration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txt_register_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox register_showPass;
        private System.Windows.Forms.Button signIn_btn;
        private System.Windows.Forms.TextBox txt_register_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_register_useName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Close_Register;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CheckBox Confirm_register_showPass;
        private TextBox txt_repeat_password;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxRole;
        public Button register_btn;
        private Label labelMatchPassword;
    }
}