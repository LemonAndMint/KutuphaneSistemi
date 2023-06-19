namespace KutuphaneSistemiWinForms.Displays.RezervationDisplay
{
    partial class RezervationMakeDisplay
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label5 = new Label();
            bookName = new TextBox();
            bookISBN = new TextBox();
            label2 = new Label();
            bookAuthor = new TextBox();
            bookCategory = new TextBox();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 317);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 11;
            label1.Text = "Yayın Adı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(170, 14);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 15;
            label5.Text = "Yayın ISBN Numarası";
            // 
            // bookName
            // 
            bookName.Location = new Point(12, 32);
            bookName.Name = "bookName";
            bookName.Size = new Size(137, 23);
            bookName.TabIndex = 12;
            // 
            // bookISBN
            // 
            bookISBN.Location = new Point(170, 32);
            bookISBN.Name = "bookISBN";
            bookISBN.Size = new Size(137, 23);
            bookISBN.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 13;
            label2.Text = "Yazar Adı-Soyadı";
            // 
            // bookAuthor
            // 
            bookAuthor.Location = new Point(12, 83);
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Size = new Size(137, 23);
            bookAuthor.TabIndex = 14;
            // 
            // bookCategory
            // 
            bookCategory.Location = new Point(170, 83);
            bookCategory.Name = "bookCategory";
            bookCategory.Size = new Size(137, 23);
            bookCategory.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 65);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 17;
            label3.Text = "Yayın Kategorisi";
            // 
            // button1
            // 
            button1.Location = new Point(329, 83);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 19;
            button1.Text = "Yayını Ara";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RezervationDisplay
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
            Name = "RezervationDisplay";
            Text = "Yayın Rezervasyonu Yapma";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label5;
        private TextBox bookName;
        private TextBox bookISBN;
        private Label label2;
        private TextBox bookAuthor;
        private TextBox bookCategory;
        private Label label3;
        private Button button1;
    }
}