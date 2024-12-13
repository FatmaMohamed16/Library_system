using System.Windows.Forms;

namespace Library_Management_System
{
    partial class ManageUsersForm
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
            panel1 = new Panel();
            button4 = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            comboBox2 = new ComboBox();
            btn_Delete = new Button();
            btn_Edit = new Button();
            btn_add = new Button();
            panel2 = new Panel();
            textBoxUserName = new TextBox();
            textBoxEmail = new TextBox();
            labelUserName = new Label();
            label1 = new Label();
            label3 = new Label();
            comboBoxRole = new ComboBox();
            textBoxPassword = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1129, 108);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Image = Properties.Resources.icons8_close_48;
            button4.Location = new Point(1049, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(80, 108);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(420, 36);
            label2.Name = "label2";
            label2.Size = new Size(249, 40);
            label2.TabIndex = 4;
            label2.Text = "Manage Users";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.profile;
            pictureBox2.Location = new Point(217, 7);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(182, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(14, 176);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1103, 431);
            panel3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveBorder;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1103, 431);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 64, 64);
            button6.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(144, 116);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(177, 52);
            button6.TabIndex = 11;
            button6.Text = "Search By";
            button6.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ID", "Title", "Author" });
            comboBox2.Location = new Point(341, 131);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(319, 28);
            comboBox2.TabIndex = 10;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.FromArgb(0, 64, 64);
            btn_Delete.Font = new Font("Arial", 12F);
            btn_Delete.ForeColor = SystemColors.ButtonHighlight;
            btn_Delete.Location = new Point(785, 24);
            btn_Delete.Margin = new Padding(3, 4, 3, 4);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(169, 64);
            btn_Delete.TabIndex = 14;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.FromArgb(0, 64, 64);
            btn_Edit.Font = new Font("Arial", 12F);
            btn_Edit.ForeColor = SystemColors.ButtonHighlight;
            btn_Edit.Location = new Point(478, 24);
            btn_Edit.Margin = new Padding(3, 4, 3, 4);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(183, 64);
            btn_Edit.TabIndex = 13;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(0, 64, 64);
            btn_add.Font = new Font("Arial", 12F);
            btn_add.ForeColor = SystemColors.ButtonHighlight;
            btn_add.Location = new Point(153, 24);
            btn_add.Margin = new Padding(3, 4, 3, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(170, 64);
            btn_add.TabIndex = 12;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.Controls.Add(btn_Delete);
            panel2.Controls.Add(btn_add);
            panel2.Controls.Add(btn_Edit);
            panel2.Location = new Point(14, 745);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1103, 120);
            panel2.TabIndex = 15;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Font = new Font("Segoe UI", 13F);
            textBoxUserName.Location = new Point(14, 673);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(258, 36);
            textBoxUserName.TabIndex = 25;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 13F);
            textBoxEmail.Location = new Point(608, 673);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(318, 36);
            textBoxEmail.TabIndex = 27;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUserName.Location = new Point(14, 631);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(116, 28);
            labelUserName.TabIndex = 20;
            labelUserName.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(608, 631);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 21;
            label1.Text = "E-Mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(965, 631);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 22;
            label3.Text = "Role";
            // 
            // comboBoxRole
            // 
            comboBoxRole.Font = new Font("Segoe UI", 11F);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Admin", "User" });
            comboBoxRole.Location = new Point(965, 673);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(151, 33);
            comboBoxRole.TabIndex = 28;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 13F);
            textBoxPassword.Location = new Point(311, 673);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(258, 36);
            textBoxPassword.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(311, 631);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 25;
            label4.Text = "Password";
            // 
            // ManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1129, 881);
            Controls.Add(label4);
            Controls.Add(textBoxPassword);
            Controls.Add(comboBoxRole);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(labelUserName);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxUserName);
            Controls.Add(panel2);
            Controls.Add(button6);
            Controls.Add(comboBox2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageUsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUsersForm";
            Load += ManageUsersForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Button button4;
        private Button button6;
        private ComboBox comboBox2;
        private Button btn_Delete;
        private Button btn_Edit;
        private Button btn_add;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox textBoxUserName;
        private TextBox textBoxEmail;
        private Label labelUserName;
        private Label label1;
        private Label label3;
        private ComboBox comboBoxRole;
        private TextBox textBoxPassword;
        private Label label4;
    }
}