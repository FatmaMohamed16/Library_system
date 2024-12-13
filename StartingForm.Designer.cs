namespace Library_Management_System
{
    partial class StartingForm
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
            components = new System.ComponentModel.Container();
            panel_progress_Start = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_Close_Login = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_progress_Start
            // 
            panel_progress_Start.BackColor = Color.White;
            panel_progress_Start.Location = new Point(1, 409);
            panel_progress_Start.Name = "panel_progress_Start";
            panel_progress_Start.Size = new Size(68, 40);
            panel_progress_Start.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngimg_com___book_PNG2105;
            pictureBox1.Location = new Point(99, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(576, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 23F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(86, 277);
            label1.Name = "label1";
            label1.Size = new Size(601, 69);
            label1.TabIndex = 2;
            label1.Text = "Library Management System";
            // 
            // btn_Close_Login
            // 
            btn_Close_Login.BackColor = Color.DarkSlateGray;
            btn_Close_Login.Cursor = Cursors.Hand;
            btn_Close_Login.FlatAppearance.BorderSize = 0;
            btn_Close_Login.FlatStyle = FlatStyle.Flat;
            btn_Close_Login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Close_Login.ForeColor = Color.White;
            btn_Close_Login.Location = new Point(766, 2);
            btn_Close_Login.Margin = new Padding(4, 5, 4, 5);
            btn_Close_Login.Name = "btn_Close_Login";
            btn_Close_Login.Size = new Size(33, 33);
            btn_Close_Login.TabIndex = 3;
            btn_Close_Login.Text = "X";
            btn_Close_Login.TextAlign = ContentAlignment.MiddleRight;
            btn_Close_Login.UseVisualStyleBackColor = false;
            btn_Close_Login.Click += btn_Close_Login_Click;
            // 
            // StartingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Close_Login);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel_progress_Start);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartingForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_progress_Start;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_Close_Login;
    }
}