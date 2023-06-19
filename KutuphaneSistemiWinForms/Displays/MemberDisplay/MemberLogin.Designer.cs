namespace KutuphaneSistemiWinForms.Displays.MemberDisplay
{
    partial class MemberLogin
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
            label5 = new Label();
            memberNick = new TextBox();
            label6 = new Label();
            memberPassword = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 27);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 30;
            label5.Text = "Kullanıcı Adı";
            // 
            // memberNick
            // 
            memberNick.Location = new Point(51, 45);
            memberNick.Name = "memberNick";
            memberNick.Size = new Size(137, 23);
            memberNick.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 78);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 32;
            label6.Text = "Şifre";
            // 
            // memberPassword
            // 
            memberPassword.Location = new Point(51, 96);
            memberPassword.Name = "memberPassword";
            memberPassword.Size = new Size(137, 23);
            memberPassword.TabIndex = 33;
            // 
            // button1
            // 
            button1.Location = new Point(51, 141);
            button1.Name = "button1";
            button1.Size = new Size(137, 23);
            button1.TabIndex = 34;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MemberLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 203);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(memberNick);
            Controls.Add(label6);
            Controls.Add(memberPassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MemberLogin";
            Text = "MemberLogin";
            FormClosing += MemberLogin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox memberNick;
        private Label label6;
        private TextBox memberPassword;
        private Button button1;
    }
}