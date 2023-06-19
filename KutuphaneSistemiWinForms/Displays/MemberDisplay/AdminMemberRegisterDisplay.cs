using KutuphaneSistemiWinForms.Controller;
using KutuphaneSistemiWinForms.Controller.Factory;
using KutuphaneSistemiWinForms.SystemData.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneSistemiWinForms.Displays.MemberDisplay
{
    public partial class AdminMemberRegisterDisplay : Form
    {
        public AdminMemberRegisterDisplay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxs())
            {

                NormalMember createMember = new NormalMember();
                MemberController memberController = (MemberController)ControllerFactory.createController("member");

                createMember.MemberName = memberName.Text;
                createMember.MemberNick = memberNick.Text;
                createMember.MemberPassword = memberPassword.Text;
                createMember.MemberTelNo = memberTelNo.Text;
                createMember.MemberMail = memberMail.Text;
                createMember.MemberAdress = memberAdress.Text;
                createMember.PersonelTitle = personelTitle.Text;
                createMember.isPersonel = 1;
                createMember.isAdmin = 0;

                memberController.createMember(createMember);

                MessageBox.Show("Kullanıcı Kayıt Etme Tamamlanmıştır");

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
