namespace KutuphaneSistemiWinForms
{
    partial class BookRegisterDisplay
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
            bookMaterial = new TextBox();
            label5 = new Label();
            label4 = new Label();
            bookISBN = new TextBox();
            bookCategory = new TextBox();
            label6 = new Label();
            label3 = new Label();
            bookAssetNumber = new TextBox();
            bookAuthor = new TextBox();
            label7 = new Label();
            label2 = new Label();
            bookSelfID = new TextBox();
            bookName = new TextBox();
            label8 = new Label();
            label1 = new Label();
            bookCopyCount = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // bookMaterial
            // 
            bookMaterial.Location = new Point(14, 193);
            bookMaterial.Name = "bookMaterial";
            bookMaterial.Size = new Size(137, 23);
            bookMaterial.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 16);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 9;
            label5.Text = "Yayın ISBN Numarası";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 175);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 7;
            label4.Text = "Yayın Materyali";
            // 
            // bookISBN
            // 
            bookISBN.Location = new Point(172, 34);
            bookISBN.Name = "bookISBN";
            bookISBN.Size = new Size(137, 23);
            bookISBN.TabIndex = 10;
            // 
            // bookCategory
            // 
            bookCategory.Location = new Point(14, 137);
            bookCategory.Name = "bookCategory";
            bookCategory.Size = new Size(137, 23);
            bookCategory.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(172, 67);
            label6.Name = "label6";
            label6.Size = new Size(142, 15);
            label6.TabIndex = 11;
            label6.Text = "Yayın Demirbaş Numarası";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 119);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 5;
            label3.Text = "Yayın Kategorisi";
            // 
            // bookAssetNumber
            // 
            bookAssetNumber.Location = new Point(172, 85);
            bookAssetNumber.Name = "bookAssetNumber";
            bookAssetNumber.Size = new Size(137, 23);
            bookAssetNumber.TabIndex = 12;
            // 
            // bookAuthor
            // 
            bookAuthor.Location = new Point(14, 85);
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Size = new Size(137, 23);
            bookAuthor.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(172, 119);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 13;
            label7.Text = "Yayın Raf Numarası";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 67);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 3;
            label2.Text = "Yazar Adı-Soyadı";
            // 
            // bookSelfID
            // 
            bookSelfID.Location = new Point(172, 137);
            bookSelfID.Name = "bookSelfID";
            bookSelfID.Size = new Size(137, 23);
            bookSelfID.TabIndex = 14;
            // 
            // bookName
            // 
            bookName.Location = new Point(14, 34);
            bookName.Name = "bookName";
            bookName.Size = new Size(137, 23);
            bookName.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(172, 175);
            label8.Name = "label8";
            label8.Size = new Size(103, 15);
            label8.TabIndex = 15;
            label8.Text = "Yayın Kopya Sayısı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 16);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Yayın Adı";
            // 
            // bookCopyCount
            // 
            bookCopyCount.Location = new Point(172, 193);
            bookCopyCount.Name = "bookCopyCount";
            bookCopyCount.Size = new Size(137, 23);
            bookCopyCount.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(105, 242);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 17;
            button1.Text = "Yayını Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // BookRegisterDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 279);
            Controls.Add(button1);
            Controls.Add(bookCopyCount);
            Controls.Add(label1);
            Controls.Add(bookMaterial);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(bookName);
            Controls.Add(label4);
            Controls.Add(bookSelfID);
            Controls.Add(bookISBN);
            Controls.Add(label2);
            Controls.Add(bookCategory);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(bookAuthor);
            Controls.Add(label3);
            Controls.Add(bookAssetNumber);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BookRegisterDisplay";
            Text = "Yayın Kayıt Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bookMaterial;
        private Label label5;
        private Label label4;
        private TextBox bookISBN;
        private TextBox bookCategory;
        private Label label6;
        private Label label3;
        private TextBox bookAssetNumber;
        private TextBox bookAuthor;
        private Label label7;
        private Label label2;
        private TextBox bookSelfID;
        private TextBox bookName;
        private Label label8;
        private Label label1;
        private TextBox bookCopyCount;
        private Button button1;
    }
}