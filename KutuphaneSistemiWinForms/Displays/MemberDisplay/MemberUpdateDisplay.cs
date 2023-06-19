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
    public partial class MemberUpdateDisplay : Form
    {
        public MemberUpdateDisplay()
        {
            InitializeComponent();
        }

        private void MemberUpdateDisplay_Load(object sender, EventArgs e)
        {
            memberName.Text = MemberController.currentMember.MemberName;
            memberNick.Text = MemberController.currentMember.MemberNick;
            memberPassword.Text = MemberController.currentMember.MemberPassword;
            memberTelNo.Text = MemberController.currentMember.MemberTelNo;
            memberAdress.Text = MemberController.currentMember.MemberAdress;
            memberMail.Text = MemberController.currentMember.MemberMail;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberController memberController = (MemberController)ControllerFactory.createController("member");

            NormalMember updatedMember = new NormalMember();

            updatedMember.MemberID = MemberController.currentMember.MemberID;
            updatedMember.MemberName = MemberController.currentMember.MemberName;
            updatedMember.MemberNick = MemberController.currentMember.MemberNick;

            updatedMember.MemberTelNo = memberTelNo.Text;
            updatedMember.MemberPassword = memberPassword.Text;
            updatedMember.MemberMail = memberMail.Text;
            updatedMember.MemberAdress = memberAdress.Text;

            memberController.updateMember(updatedMember);

            MessageBox.Show("Kullanıcı Güncellemesi Tamamlanmıştır");

            Hide();
        }
    }
}