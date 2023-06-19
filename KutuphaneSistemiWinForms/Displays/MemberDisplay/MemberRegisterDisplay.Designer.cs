namespace KutuphaneSistemiWinForms.Displays.MemberDisplay
{
    partial class MemberRegisterDisplay
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
            memberPasswordAgain = new TextBox();
            memberNick = new TextBox();
            label2 = new Label();
            memberTelNo = new TextBox();
            label7 = new Label();
            label6 = new Label();
            memberAdress = new TextBox();
            label3 = new Label();
            memberPassword = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(172, 188);
            button1.Name = "button1";
            button1.Size = new Size(137, 23);
            button1.TabIndex = 34;
            button1.Text = "Kayıt Ol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 18;
            label1.Text = "Ad-Soyad";
            // 
            // memberMail
            // 
            memberMail.Location = new Point(14, 136);
            memberMail.Name = "memberMail";
            memberMail.Size = new Size(137, 23);
            memberMail.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 15);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 26;
            label5.Text = "Kullanıcı Adı";
            // 
            // memberName
            // 
            memberName.Location = new Point(14, 33);
            memberName.Name = "memberName";
            memberName.Size = new Size(137, 23);
            memberName.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 118);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 24;
            label4.Text = "Mail ";
            // 
            // memberPasswordAgain
            // 
            memberPasswordAgain.Location = new Point(172, 136);
            memberPasswordAgain.Name = "memberPasswordAgain";
            memberPasswordAgain.Size = new Size(137, 23);
            memberPasswordAgain.TabIndex = 31;
            // 
            // memberNick
            // 
            memberNick.Location = new Point(172, 33);
            memberNick.Name = "memberNick";
            memberNick.Size = new Size(137, 23);
            memberNick.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 15);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 20;
            label2.Text = "Açık Adres";
            // 
            // memberTelNo
            // 
            memberTelNo.Location = new Point(14, 84);
            memberTelNo.Name = "memberTelNo";
            memberTelNo.Size = new Size(137, 23);
            memberTelNo.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(172, 118);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 30;
            label7.Text = "Şifre Tekrar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(172, 66);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 28;
            label6.Text = "Şifre";
            // 
            // memberAdress
            // 
            memberAdress.Location = new Point(329, 33);
            memberAdress.Multiline = true;
            memberAdress.Name = "memberAdress";
            memberAdress.Size = new Size(137, 126);
            memberAdress.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 66);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 22;
            label3.Text = "Telefon Numarası";
            // 
            // memberPassword
            // 
            memberPassword.Location = new Point(172, 84);
            memberPassword.Name = "memberPassword";
            memberPassword.Size = new Size(137, 23);
            memberPassword.TabIndex = 29;
            // 
            // MemberRegisterDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 223);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(memberMail);
            Controls.Add(label5);
            Controls.Add(memberName);
            Controls.Add(label4);
            Controls.Add(memberPasswordAgain);
            Controls.Add(memberNick);
            Controls.Add(label2);
            Controls.Add(memberTelNo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(memberAdress);
            Controls.Add(label3);
            Controls.Add(memberPassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MemberRegisterDisplay";
            Text = "Kullanıcı Kayıt Olma";
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
        private TextBox memberPasswordAgain;
        private TextBox memberNick;
        private Label label2;
        private TextBox memberTelNo;
        private Label label7;
        private Label label6;
        private TextBox memberAdress;
        private Label label3;
        private TextBox memberPassword;
    }
}