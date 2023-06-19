namespace KutuphaneSistemiWinForms.Displays.BookDisplay
{
    partial class BookUpdateDisplay
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
            button1 = new Button();
            bookCategory = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            bookName = new TextBox();
            bookISBN = new TextBox();
            label2 = new Label();
            bookAuthor = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(329, 82);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 29;
            button1.Text = "Yayını Ara";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bookCategory
            // 
            bookCategory.Location = new Point(170, 82);
            bookCategory.Name = "bookCategory";
            bookCategory.Size = new Size(137, 23);
            bookCategory.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 64);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 27;
            label3.Text = "Yayın Kategorisi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 21;
            label1.Text = "Yayın Adı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(170, 13);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 25;
            label5.Text = "Yayın ISBN Numarası";
            // 
            // bookName
            // 
            bookName.Location = new Point(12, 31);
            bookName.Name = "bookName";
            bookName.Size = new Size(137, 23);
            bookName.TabIndex = 22;
            // 
            // bookISBN
            // 
            bookISBN.Location = new Point(170, 31);
            bookISBN.Name = "bookISBN";
            bookISBN.Size = new Size(137, 23);
            bookISBN.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 23;
            label2.Text = "Yazar Adı-Soyadı";
            // 
            // bookAuthor
            // 
            bookAuthor.Location = new Point(12, 82);
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Size = new Size(137, 23);
            bookAuthor.TabIndex = 24;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 317);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BookUpdateDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(bookCategory);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(bookName);
            Controls.Add(bookISBN);
            Controls.Add(label2);
            Controls.Add(bookAuthor);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BookUpdateDisplay";
            Text = "Kitap Güncelleme";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox bookCategory;
        private Label label3;
        private Label label1;
        private Label label5;
        private TextBox bookName;
        private TextBox bookISBN;
        private Label label2;
        private TextBox bookAuthor;
        private DataGridView dataGridView1;
    }
}