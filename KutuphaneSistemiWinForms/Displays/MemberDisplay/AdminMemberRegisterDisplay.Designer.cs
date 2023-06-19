namespace KutuphaneSistemiWinForms.Displays.MemberDisplay
{
    partial class AdminMemberRegisterDisplay
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
            personelTitle = new TextBox();
            label2 = new Label();
            memberTelNo = new TextBox();
            memberAdress = new TextBox();
            label3 = new Label();
            label6 = new Label();
            memberNick = new TextBox();
            label7 = new Label();
            memberPassword = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(171, 234);
            button1.Name = "button1";
            button1.Size = new Size(137, 23);
            button1.TabIndex = 49;
            button1.Text = "Kayıt Et";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 22);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 35;
            label1.Text = "Ad-Soyad";
            // 
            // memberMail
            // 
            memberMail.Location = new Point(13, 234);
            memberMail.Name = "memberMail";
            memberMail.Size = new Size(137, 23);
            memberMail.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(171, 22);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 43;
            label5.Text = "Memur Rütbesi";
            // 
            // memberName
            // 
            memberName.Location = new Point(13, 40);
            memberName.Name = "memberName";
            memberName.Size = new Size(137, 23);
            memberName.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 216);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 41;
            label4.Text = "Mail ";
            // 
            // personelTitle
            // 
            personelTitle.Location = new Point(171, 40);
            personelTitle.Name = "personelTitle";
            personelTitle.Size = new Size(137, 23);
            personelTitle.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 73);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 37;
            label2.Text = "Açık Adres";
            // 
            // memberTelNo
            // 
            memberTelNo.Location = new Point(13, 91);
            memberTelNo.Name = "memberTelNo";
            memberTelNo.Size = new Size(137, 23);
            memberTelNo.TabIndex = 40;
            // 
            // memberAdress
            // 
            memberAdress.Location = new Point(171, 91);
            memberAdress.Multiline = true;
            memberAdress.Name = "memberAdress";
            memberAdress.Size = new Size(137, 122);
            memberAdress.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 73);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 39;
            label3.Text = "Telefon Numarası";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 121);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 50;
            label6.Text = "Kullanıcı Adı";
            // 
            // memberNick
            // 
            memberNick.Location = new Point(13, 139);
            memberNick.Name = "memberNick";
            memberNick.Size = new Size(137, 23);
            memberNick.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 172);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 52;
            label7.Text = "Şifre";
            // 
            // memberPassword
            // 
            memberPassword.Location = new Point(13, 190);
            memberPassword.Name = "memberPassword";
            memberPassword.Size = new Size(137, 23);
            memberPassword.TabIndex = 53;
            // 
            // AdminMemberRegisterDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 274);
            Controls.Add(label6);
            Controls.Add(memberNick);
            Controls.Add(label7);
            Controls.Add(memberPassword);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(memberMail);
            Controls.Add(label5);
            Controls.Add(memberName);
            Controls.Add(label4);
            Controls.Add(personelTitle);
            Controls.Add(label2);
            Controls.Add(memberTelNo);
            Controls.Add(memberAdress);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminMemberRegisterDisplay";
            Text = "Admin Kullanıcı Kayıt Etme";
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
        private TextBox personelTitle;
        private Label label2;
        private TextBox memberTelNo;
        private TextBox memberAdress;
        private Label label3;
        private Label label6;
        private TextBox memberNick;
        private Label label7;
        private TextBox memberPassword;
    }
}