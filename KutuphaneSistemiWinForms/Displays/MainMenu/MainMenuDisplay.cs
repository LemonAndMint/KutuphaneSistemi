using KutuphaneSistemiWinForms.Controller;
using KutuphaneSistemiWinForms.Displays.MemberDisplay;
using KutuphaneSistemiWinForms.Displays.Menus.NormalMenu;
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

namespace KutuphaneSistemiWinForms.Displays.MainMenu
{
    public partial class MainMenuDisplay : Form
    {
        public MainMenuDisplay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NormalMember anonimMember = new NormalMember();

            anonimMember.MemberID = 4;
            anonimMember.MemberName = "";
            anonimMember.MemberNick = "";
            anonimMember.MemberTelNo = "";
            anonimMember.MemberAdress = "";
            anonimMember.isAdmin = 0;
            anonimMember.isPersonel = 0;
            anonimMember.PersonelTitle = "";

            MemberController.currentMember = anonimMember;

            AnonimMenuDisplay anonimMenu = new AnonimMenuDisplay();
            anonimMenu.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemberLogin memberLogin = new MemberLogin();
            memberLogin.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MemberRegisterDisplay memberRegister = new MemberRegisterDisplay();
            memberRegister.Show();
        }

        private void MainMenuDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
