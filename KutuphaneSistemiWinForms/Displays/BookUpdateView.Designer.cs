namespace KutuphaneSistemiWinForms.Displays
{
    partial class BookUpdateView
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
            label9 = new Label();
            pictureBox1 = new PictureBox();
            bookCopyCount = new TextBox();
            label1 = new Label();
            bookMaterial = new TextBox();
            label8 = new Label();
            label5 = new Label();
            bookName = new TextBox();
            label4 = new Label();
            bookShelfID = new TextBox();
            bookISBN = new TextBox();
            label2 = new Label();
            bookCategory = new TextBox();
            label7 = new Label();
            label6 = new Label();
            bookAuthor = new TextBox();
            label3 = new Label();
            bookAssetNumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(257, 304);
            button1.Name = "button1";
            button1.Size = new Size(164, 41);
            button1.TabIndex = 55;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(257, 21);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 54;
            label9.Text = "Yayın Resmi";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(257, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 211);
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // bookCopyCount
            // 
            bookCopyCount.Location = new Point(257, 274);
            bookCopyCount.Name = "bookCopyCount";
            bookCopyCount.Size = new Size(164, 23);
            bookCopyCount.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 37;
            label1.Text = "Yayın Adı";
            // 
            // bookMaterial
            // 
            bookMaterial.Location = new Point(15, 178);
            bookMaterial.Name = "bookMaterial";
            bookMaterial.Size = new Size(220, 23);
            bookMaterial.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(257, 256);
            label8.Name = "label8";
            label8.Size = new Size(103, 15);
            label8.TabIndex = 51;
            label8.Text = "Yayın Kopya Sayısı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 209);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 45;
            label5.Text = "Yayın ISBN Numarası";
            // 
            // bookName
            // 
            bookName.Location = new Point(15, 39);
            bookName.Name = "bookName";
            bookName.Size = new Size(220, 23);
            bookName.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 160);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 43;
            label4.Text = "Yayın Materyali";
            // 
            // bookShelfID
            // 
            bookShelfID.Location = new Point(15, 322);
            bookShelfID.Name = "bookShelfID";
            bookShelfID.Size = new Size(220, 23);
            bookShelfID.TabIndex = 50;
            // 
            // bookISBN
            // 
            bookISBN.Location = new Point(15, 227);
            bookISBN.Name = "bookISBN";
            bookISBN.Size = new Size(220, 23);
            bookISBN.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 67);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 39;
            label2.Text = "Yazar Adı-Soyadı";
            // 
            // bookCategory
            // 
            bookCategory.Location = new Point(15, 131);
            bookCategory.Name = "bookCategory";
            bookCategory.Size = new Size(220, 23);
            bookCategory.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 304);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 49;
            label7.Text = "Yayın Raf Numarası";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 256);
            label6.Name = "label6";
            label6.Size = new Size(142, 15);
            label6.TabIndex = 47;
            label6.Text = "Yayın Demirbaş Numarası";
            // 
            // bookAuthor
            // 
            bookAuthor.Location = new Point(15, 85);
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Size = new Size(220, 23);
            bookAuthor.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 113);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 41;
            label3.Text = "Yayın Kategorisi";
            // 
            // bookAssetNumber
            // 
            bookAssetNumber.Location = new Point(15, 274);
            bookAssetNumber.Name = "bookAssetNumber";
            bookAssetNumber.Size = new Size(220, 23);
            bookAssetNumber.TabIndex = 48;
            // 
            // BookUpdateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 373);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(bookCopyCount);
            Controls.Add(label1);
            Controls.Add(bookMaterial);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(bookName);
            Controls.Add(label4);
            Controls.Add(bookShelfID);
            Controls.Add(bookISBN);
            Controls.Add(label2);
            Controls.Add(bookCategory);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(bookAuthor);
            Controls.Add(label3);
            Controls.Add(bookAssetNumber);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BookUpdateView";
            Text = "Yayın Güncelleme";
            Load += BookUpdateView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label9;
        private PictureBox pictureBox1;
        private TextBox bookCopyCount;
        private Label label1;
        private TextBox bookMaterial;
        private Label label8;
        private Label label5;
        private TextBox bookName;
        private Label label4;
        private TextBox bookShelfID;
        private TextBox bookISBN;
        private Label label2;
        private TextBox bookCategory;
        private Label label7;
        private Label label6;
        private TextBox bookAuthor;
        private Label label3;
        private TextBox bookAssetNumber;
    }
}