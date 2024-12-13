using Library_Management_System.Data;
using System.Windows.Forms;

namespace Library_Management_System
{
    partial class AddBookForm
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
            panel2 = new Panel();
            button2 = new Button();
            pictureBoxAdd_EditForm = new PictureBox();
            labelAdd_EditFormTittle = new Label();
            panel3 = new Panel();
            button3 = new Button();
            pictureBoxBookImage = new PictureBox();
            panel4 = new Panel();
            labelQuantityMatch = new Label();
            label13 = new Label();
            label11 = new Label();
            label5 = new Label();
            label1 = new Label();
            labelTittleMatch = new Label();
            labelisbnMatch = new Label();
            comboBoxGenre = new ComboBox();
            textBoxyear = new TextBox();
            button5 = new Button();
            btn_Add_Edit_Book = new Button();
            textBoxQuantity = new TextBox();
            label12 = new Label();
            textBoxisban = new TextBox();
            label9 = new Label();
            label6 = new Label();
            textBoxpublish = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBoxtittle = new TextBox();
            textBoxauthor = new TextBox();
            label3 = new Label();
            label4 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            openFileDialog1 = new OpenFileDialog();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdd_EditForm).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBookImage).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 64);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(pictureBoxAdd_EditForm);
            panel2.Controls.Add(labelAdd_EditFormTittle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1038, 89);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveBorder;
            button2.ForeColor = Color.Transparent;
            button2.Image = Properties.Resources.icons8_close_48;
            button2.Location = new Point(945, 11);
            button2.Name = "button2";
            button2.Size = new Size(81, 72);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // pictureBoxAdd_EditForm
            // 
            pictureBoxAdd_EditForm.Image = Properties.Resources.book__2_;
            pictureBoxAdd_EditForm.Location = new Point(262, 6);
            pictureBoxAdd_EditForm.Name = "pictureBoxAdd_EditForm";
            pictureBoxAdd_EditForm.Size = new Size(126, 75);
            pictureBoxAdd_EditForm.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAdd_EditForm.TabIndex = 1;
            pictureBoxAdd_EditForm.TabStop = false;
            // 
            // labelAdd_EditFormTittle
            // 
            labelAdd_EditFormTittle.AutoSize = true;
            labelAdd_EditFormTittle.Font = new Font("Arial", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAdd_EditFormTittle.ForeColor = SystemColors.ButtonHighlight;
            labelAdd_EditFormTittle.Location = new Point(407, 24);
            labelAdd_EditFormTittle.Margin = new Padding(4, 0, 4, 0);
            labelAdd_EditFormTittle.Name = "labelAdd_EditFormTittle";
            labelAdd_EditFormTittle.Size = new Size(248, 37);
            labelAdd_EditFormTittle.TabIndex = 0;
            labelAdd_EditFormTittle.Text = "Add New Book ";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(pictureBoxBookImage);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 89);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(362, 545);
            panel3.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 64, 64);
            button3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(21, 379);
            button3.Name = "button3";
            button3.Size = new Size(314, 44);
            button3.TabIndex = 11;
            button3.Text = "Choose Image";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBoxBookImage
            // 
            pictureBoxBookImage.BackColor = Color.Silver;
            pictureBoxBookImage.Image = Properties.Resources.book;
            pictureBoxBookImage.Location = new Point(70, 77);
            pictureBoxBookImage.Name = "pictureBoxBookImage";
            pictureBoxBookImage.Size = new Size(218, 252);
            pictureBoxBookImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBookImage.TabIndex = 0;
            pictureBoxBookImage.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.InactiveBorder;
            panel4.Controls.Add(labelQuantityMatch);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(labelTittleMatch);
            panel4.Controls.Add(labelisbnMatch);
            panel4.Controls.Add(comboBoxGenre);
            panel4.Controls.Add(textBoxyear);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(btn_Add_Edit_Book);
            panel4.Controls.Add(textBoxQuantity);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(textBoxisban);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(textBoxpublish);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(textBoxtittle);
            panel4.Controls.Add(textBoxauthor);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(362, 89);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(676, 545);
            panel4.TabIndex = 3;
            // 
            // labelQuantityMatch
            // 
            labelQuantityMatch.AutoSize = true;
            labelQuantityMatch.Location = new Point(544, 389);
            labelQuantityMatch.Name = "labelQuantityMatch";
            labelQuantityMatch.Size = new Size(0, 22);
            labelQuantityMatch.TabIndex = 46;
            labelQuantityMatch.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.Desktop;
            label13.Location = new Point(544, 330);
            label13.Name = "label13";
            label13.Size = new Size(88, 22);
            label13.TabIndex = 45;
            label13.Text = "Required";
            label13.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.Desktop;
            label11.Location = new Point(544, 269);
            label11.Name = "label11";
            label11.Size = new Size(88, 22);
            label11.TabIndex = 44;
            label11.Text = "Required";
            label11.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(544, 210);
            label5.Name = "label5";
            label5.Size = new Size(88, 22);
            label5.TabIndex = 43;
            label5.Text = "Required";
            label5.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(544, 155);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 42;
            label1.Text = "Required";
            label1.Visible = false;
            // 
            // labelTittleMatch
            // 
            labelTittleMatch.AutoSize = true;
            labelTittleMatch.ForeColor = SystemColors.Desktop;
            labelTittleMatch.Location = new Point(544, 99);
            labelTittleMatch.Name = "labelTittleMatch";
            labelTittleMatch.Size = new Size(88, 22);
            labelTittleMatch.TabIndex = 41;
            labelTittleMatch.Text = "Required";
            labelTittleMatch.Visible = false;
            // 
            // labelisbnMatch
            // 
            labelisbnMatch.AutoSize = true;
            labelisbnMatch.Location = new Point(544, 44);
            labelisbnMatch.Name = "labelisbnMatch";
            labelisbnMatch.Size = new Size(76, 22);
            labelisbnMatch.TabIndex = 40;
            labelisbnMatch.Text = "Match ?";
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(212, 210);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(305, 30);
            comboBoxGenre.TabIndex = 32;
            comboBoxGenre.SelectedIndexChanged += comboBoxGenre_SelectedIndexChanged;
            // 
            // textBoxyear
            // 
            textBoxyear.Font = new Font("Arial", 14.25F);
            textBoxyear.Location = new Point(212, 325);
            textBoxyear.Name = "textBoxyear";
            textBoxyear.Size = new Size(305, 35);
            textBoxyear.TabIndex = 34;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 64, 64);
            button5.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(324, 454);
            button5.Name = "button5";
            button5.Size = new Size(160, 50);
            button5.TabIndex = 37;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btn_Add_Edit_Book
            // 
            btn_Add_Edit_Book.BackColor = Color.FromArgb(0, 64, 64);
            btn_Add_Edit_Book.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btn_Add_Edit_Book.ForeColor = SystemColors.ButtonHighlight;
            btn_Add_Edit_Book.Location = new Point(55, 454);
            btn_Add_Edit_Book.Name = "btn_Add_Edit_Book";
            btn_Add_Edit_Book.Size = new Size(160, 50);
            btn_Add_Edit_Book.TabIndex = 36;
            btn_Add_Edit_Book.Text = "Add Book";
            btn_Add_Edit_Book.UseVisualStyleBackColor = false;
            btn_Add_Edit_Book.Click += btn_AddBook_Click;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Font = new Font("Arial", 14.25F);
            textBoxQuantity.Location = new Point(212, 384);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(305, 35);
            textBoxQuantity.TabIndex = 35;
            textBoxQuantity.TextChanged += textBoxQuantity_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 14.25F);
            label12.Location = new Point(25, 389);
            label12.Name = "label12";
            label12.Size = new Size(117, 27);
            label12.TabIndex = 32;
            label12.Text = "Quantity :";
            // 
            // textBoxisban
            // 
            textBoxisban.Font = new Font("Arial", 14.25F);
            textBoxisban.Location = new Point(212, 38);
            textBoxisban.Name = "textBoxisban";
            textBoxisban.Size = new Size(305, 35);
            textBoxisban.TabIndex = 29;
            textBoxisban.TextChanged += textBoxisban_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 14.25F);
            label9.Location = new Point(25, 41);
            label9.Name = "label9";
            label9.Size = new Size(81, 27);
            label9.TabIndex = 28;
            label9.Text = "ISBN :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F);
            label6.Location = new Point(23, 329);
            label6.Name = "label6";
            label6.Size = new Size(183, 27);
            label6.TabIndex = 27;
            label6.Text = "Publisher Year :";
            // 
            // textBoxpublish
            // 
            textBoxpublish.Font = new Font("Arial", 14.25F);
            textBoxpublish.Location = new Point(212, 266);
            textBoxpublish.Name = "textBoxpublish";
            textBoxpublish.Size = new Size(305, 35);
            textBoxpublish.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F);
            label8.Location = new Point(25, 269);
            label8.Name = "label8";
            label8.Size = new Size(128, 27);
            label8.TabIndex = 23;
            label8.Text = "Publisher :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 14.25F);
            label7.Location = new Point(23, 210);
            label7.Name = "label7";
            label7.Size = new Size(93, 27);
            label7.TabIndex = 22;
            label7.Text = "Gener :";
            // 
            // textBoxtittle
            // 
            textBoxtittle.Font = new Font("Arial", 14.25F);
            textBoxtittle.Location = new Point(212, 93);
            textBoxtittle.Name = "textBoxtittle";
            textBoxtittle.Size = new Size(305, 35);
            textBoxtittle.TabIndex = 30;
            textBoxtittle.TextChanged += textBoxtittle_TextChanged;
            // 
            // textBoxauthor
            // 
            textBoxauthor.Font = new Font("Arial", 14.25F);
            textBoxauthor.Location = new Point(212, 150);
            textBoxauthor.Name = "textBoxauthor";
            textBoxauthor.Size = new Size(305, 35);
            textBoxauthor.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F);
            label3.Location = new Point(27, 94);
            label3.Name = "label3";
            label3.Size = new Size(70, 27);
            label3.TabIndex = 16;
            label3.Text = "Title :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F);
            label4.Location = new Point(25, 150);
            label4.Name = "label4";
            label4.Size = new Size(97, 27);
            label4.TabIndex = 17;
            label4.Text = "Author :";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 634);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBookForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdd_EditForm).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBookImage).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
        private Label label4;
        private PictureBox pictureBoxBookImage;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label12;
        private Button button3;
        private Button button5;
        private Button button2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label labelisbnMatch;
        private Label labelTittleMatch;
        private Label label13;
        private Label label11;
        private Label label5;
        private Label label1;
        private Label labelQuantityMatch;
        private OpenFileDialog openFileDialog1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        public PictureBox pictureBoxAdd_EditForm;
        public Label labelAdd_EditFormTittle;
        public Button btn_Add_Edit_Book;
        public TextBox textBoxtittle;
        public TextBox textBoxauthor;
        public TextBox textBoxpublish;
        public TextBox textBoxisban;
        public TextBox textBoxQuantity;
        public TextBox textBoxyear;
        public ComboBox comboBoxGenre;
    }
}