using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Windows.Forms;

namespace Library_Management_System
{
    partial class BooksListForm
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
            btn_Minimize = new Button();
            button1 = new Button();
            btn_Maxmize = new Button();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel5 = new Panel();
            button6 = new Button();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            panel6 = new Panel();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 64);
            panel2.Controls.Add(btn_Minimize);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btn_Maxmize);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1476, 65);
            panel2.TabIndex = 2;
            // 
            // btn_Minimize
            // 
            btn_Minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Minimize.Image = Properties.Resources.icons8_minimize_50;
            btn_Minimize.Location = new Point(1282, 3);
            btn_Minimize.Name = "btn_Minimize";
            btn_Minimize.Size = new Size(45, 63);
            btn_Minimize.TabIndex = 14;
            btn_Minimize.UseVisualStyleBackColor = true;
            btn_Minimize.Click += btn_Minimize_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.icons8_close_48;
            button1.Location = new Point(1397, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(79, 66);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btn_Maxmize
            // 
            btn_Maxmize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Maxmize.Image = Properties.Resources.icons8_maximize_48;
            btn_Maxmize.Location = new Point(1330, 2);
            btn_Maxmize.Name = "btn_Maxmize";
            btn_Maxmize.Size = new Size(65, 63);
            btn_Maxmize.TabIndex = 13;
            btn_Maxmize.UseVisualStyleBackColor = true;
            btn_Maxmize.Click += btn_Maxmize_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(351, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(352, 66);
            panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngimg_com___book_PNG2105;
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(159, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(189, 14);
            label2.Name = "label2";
            label2.Size = new Size(171, 40);
            label2.TabIndex = 2;
            label2.Text = "Book List";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonHighlight;
            panel5.Controls.Add(button6);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 65);
            panel5.Name = "panel5";
            panel5.Size = new Size(1476, 594);
            panel5.TabIndex = 3;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 64, 64);
            button6.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(184, 15);
            button6.Name = "button6";
            button6.Size = new Size(155, 39);
            button6.TabIndex = 5;
            button6.Text = "Search By";
            button6.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ID", "Title", "Author" });
            comboBox1.Location = new Point(358, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(280, 31);
            comboBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveBorder;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(6, 63);
            dataGridView1.Margin = new Padding(6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView1.Size = new Size(1470, 488);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.InactiveBorder;
            panel6.Controls.Add(btnEdit);
            panel6.Controls.Add(btnDelete);
            panel6.Controls.Add(btnAdd);
            panel6.Dock = DockStyle.Bottom;
            panel6.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel6.ForeColor = SystemColors.ButtonHighlight;
            panel6.Location = new Point(0, 623);
            panel6.Name = "panel6";
            panel6.Size = new Size(1476, 159);
            panel6.TabIndex = 4;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 64, 64);
            btnEdit.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(736, 34);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(164, 70);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(0, 64, 64);
            btnDelete.Location = new Point(547, 34);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(164, 70);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 64, 64);
            btnAdd.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(362, 34);
            btnAdd.Margin = new Padding(7);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(164, 70);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button2_Click;
            // 
            // BooksListForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1476, 782);
            ControlBox = false;
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "BooksListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BooksListForm";
            Load += BooksListForm_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel5;
        private Panel panel6;
        private Button btnAdd;
        private Button button1;
        private Button button6;
        private ComboBox comboBox1;
        private Button btn_Minimize;
        private Button btn_Maxmize;
        public DataGridView dataGridView1;
        public Button btnDelete;
        public Button btnEdit;
    }
}