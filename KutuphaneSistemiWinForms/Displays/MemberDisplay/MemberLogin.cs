using KutuphaneSistemiWinForms.SystemData.Member;
using KutuphaneSistemiWinForms.Controller;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneSistemiWinForms.Controller.Factory;
using KutuphaneSistemiWinForms.Displays.Menus.NormalMenu;

namespace KutuphaneSistemiWinForms.Displays.MemberDisplay
{
    public partial class MemberLogin : Form
    {
        public MemberLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxs())
            {

                MemberController memberController = (MemberController)ControllerFactory.createController("member");

                String nickname = memberNick.Text;
                String password = memberPassword.Text;

                if (memberController.loginMember(nickname, password) != true)
                {
                    MessageBox.Show("Yanlış kullanıcı adı ya da şifre.");
                    clearBoxs();
                    return;
                }

                if (MemberController.currentMember.isPersonel == 1)
                {
                    PersonelMemberMenuDisplay personelMemberMenu = new PersonelMemberMenuDisplay();
                    personelMemberMenu.Show();
                    Hide();
                    return;
                }

                if (MemberController.currentMember.isAdmin == 1)
                {
                    AdminMenuDisplay personelMemberMenu = new AdminMenuDisplay();
                    personelMemberMenu.Show();
                    Hide();
                    return;
                }

                NormalMemberMenuDisplay normalMemberMenu = new NormalMemberMenuDisplay();
                normalMemberMenu.Show();
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

        private void MemberLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
