using KutuphaneSistemiWinForms.Displays.MemberDisplay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneSistemiWinForms.Displays.Menus.NormalMenu
{
    public partial class AdminMenuDisplay : Form
    {
        public AdminMenuDisplay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMemberRegisterDisplay adminMemberRegister = new AdminMemberRegisterDisplay();
            adminMemberRegister.Show();

        }

        private void AdminMenuDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
