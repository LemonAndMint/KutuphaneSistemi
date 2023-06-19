namespace KutuphaneSistemiWinForms.Displays.MemberDisplay
{
    partial class MemberUpdateDisplay
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
            label1 = new Label();
            memberMail = new TextBox();
            label5 = new Label();
            memberName = new TextBox();
            label4 = new Label();
            memberNick = new TextBox();
            label2 = new Label();
            memberTelNo = new TextBox();
            label6 = new Label();
            memberAdress = new TextBox();
            label3 = new Label();
            memberPassword = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(171, 144);
            button1.Name = "button1";
            button1.Size = new Size(137, 23);
            button1.TabIndex = 49;
            button1.Text = "Profil Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 23);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 35;
            label1.Text = "Ad-Soyad";
            // 
            // memberMail
            // 
            memberMail.Location = new Point(13, 144);
            memberMail.Name = "memberMail";
            memberMail.Size = new Size(137, 23);
            memberMail.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(171, 23);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 43;
            label5.Text = "Kullanıcı Adı";
            // 
            // memberName
            // 
            memberName.Location = new Point(13, 41);
            memberName.Name = "memberName";
            memberName.ReadOnly = true;
            memberName.Size = new Size(137, 23);
            memberName.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 126);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 41;
            label4.Text = "Mail ";
            // 
            // memberNick
            // 
            memberNick.Location = new Point(171, 41);
            memberNick.Name = "memberNick";
            memberNick.ReadOnly = true;
            memberNick.Size = new Size(137, 23);
            memberNick.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 23);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 37;
            label2.Text = "Açık Adres";
            // 
            // memberTelNo
            // 
            memberTelNo.Location = new Point(13, 92);
            memberTelNo.Name = "memberTelNo";
            memberTelNo.Size = new Size(137, 23);
            memberTelNo.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(171, 74);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 45;
            label6.Text = "Şifre";
            // 
            // memberAdress
            // 
            memberAdress.Location = new Point(328, 41);
            memberAdress.Multiline = true;
            memberAdress.Name = "memberAdress";
            memberAdress.Size = new Size(137, 126);
            memberAdress.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 74);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 39;
            label3.Text = "Telefon Numarası";
            // 
            // memberPassword
            // 
            memberPassword.Location = new Point(171, 92);
            memberPassword.Name = "memberPassword";
            memberPassword.Size = new Size(137, 23);
            memberPassword.TabIndex = 46;
            // 
            // MemberUpdateDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 198);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(memberMail);
            Controls.Add(label5);
            Controls.Add(memberName);
            Controls.Add(label4);
            Controls.Add(memberNick);
            Controls.Add(label2);
            Controls.Add(memberTelNo);
            Controls.Add(label6);
            Controls.Add(memberAdress);
            Controls.Add(label3);
            Controls.Add(memberPassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MemberUpdateDisplay";
            Text = "Profil Güncelleme";
            Load += MemberUpdateDisplay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox memberMail;
        private Label label5;
        private TextBox memberName;
        private Label label4;
        private TextBox memberNick;
        private Label label2;
        private TextBox memberTelNo;
        private Label label6;
        private TextBox memberAdress;
        private Label label3;
        private TextBox memberPassword;
    }
}