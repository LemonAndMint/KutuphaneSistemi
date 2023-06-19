using KutuphaneSistemiWinForms.Controller;
using KutuphaneSistemiWinForms.Displays.MemberDisplay;
using KutuphaneSistemiWinForms.Displays.RezervationDisplay;
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
    public partial class NormalMemberMenuDisplay : Form
    {
        public NormalMemberMenuDisplay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RezervationMakeDisplay rezervationMake = new RezervationMakeDisplay();
            rezervationMake.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RezervationHistoryDisplay rezervationHistory = new RezervationHistoryDisplay();
            rezervationHistory.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MemberController.currentMember.PersonelTitle != null)
            {
                PersonelMemberUpdateDisplay personelMemberUpdate = new PersonelMemberUpdateDisplay();
                personelMemberUpdate.Show();
            }

            MemberUpdateDisplay memberUpdate = new MemberUpdateDisplay();
            memberUpdate.Show();

        }

        private void NormalMemberMenuDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
