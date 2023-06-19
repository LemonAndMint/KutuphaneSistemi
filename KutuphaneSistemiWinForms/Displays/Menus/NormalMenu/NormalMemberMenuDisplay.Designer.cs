namespace KutuphaneSistemiWinForms.Displays.Menus.NormalMenu
{
    partial class NormalMemberMenuDisplay
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
            button2 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(97, 89);
            button1.Name = "button1";
            button1.Size = new Size(163, 48);
            button1.TabIndex = 0;
            button1.Text = "Yayın Rezervesi Yapma";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(97, 220);
            button2.Name = "button2";
            button2.Size = new Size(163, 48);
            button2.TabIndex = 1;
            button2.Text = "Profil Bilgisi Değiştirme";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(97, 154);
            button4.Name = "button4";
            button4.Size = new Size(163, 48);
            button4.TabIndex = 3;
            button4.Text = "Yayın Rezerve Geçmişi Görüntülemesi";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // NormalMemberMenuDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 373);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "NormalMemberMenuDisplay";
            Text = "Kullanıcı Menüsü";
            FormClosing += NormalMemberMenuDisplay_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
    }
}