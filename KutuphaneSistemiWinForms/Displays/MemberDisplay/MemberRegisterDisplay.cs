
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneSistemiWinForms.SystemData;
using KutuphaneSistemiWinForms.Controller;
using KutuphaneSistemiWinForms.SystemData.Member;
using KutuphaneSistemiWinForms.Controller.Factory;

namespace KutuphaneSistemiWinForms.Displays.MemberDisplay
{
    public partial class MemberRegisterDisplay : Form
    {
        public MemberRegisterDisplay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxs())
            {

                NormalMember createMember = new NormalMember();
                MemberController memberController = (MemberController)ControllerFactory.createController("member");

                if (memberPassword.Text != memberPasswordAgain.Text)
                {
                    MessageBox.Show("Girilen şifreler birbiriyle örtüşmelidir.");
                    clearBoxs();
                    return;
                }

                createMember.MemberName = memberName.Text;
                createMember.MemberTelNo = memberTelNo.Text;
                createMember.MemberMail = memberMail.Text;
                createMember.MemberAdress = memberAdress.Text;
                createMember.MemberNick = memberNick.Text;
                createMember.MemberPassword = memberPassword.Text;
                createMember.isPersonel = 0;
                createMember.isAdmin = 0;

                try
                {
                    memberController.createMember(createMember);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Kayıt yapılamadı." + exception.HResult);
                    clearBoxs();
                    return;
                }

                MessageBox.Show("Kullanıcı Kayıtı Tamamlanmıştır");

                Hide();
            }

        }

        private bool checkBoxs()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
                {
                    MessageBox.Show("Alanlar boş bırakılmamalıdır.");
                    return false;
                }
            }

            return true;
        }
        private void clearBoxs()
        {
            foreach (Control control in this.Controls)
            {
                foreach (var textboxitem in control.Controls.OfType<TextBox>())
                {
                    textboxitem.Clear();
                }
            }

        }

    }
}
