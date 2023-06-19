using KutuphaneSistemiWinForms.Displays.BookDisplay;
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
    public partial class PersonelMemberMenuDisplay : Form
    {
        public PersonelMemberMenuDisplay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookRegisterDisplay bookRegister = new BookRegisterDisplay();
            bookRegister.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookUpdateDisplay bookUpdate = new BookUpdateDisplay();
            bookUpdate.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RezervationTakeDisplay rezervationTake = new RezervationTakeDisplay();
            rezervationTake.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void PersonelMemberMenuDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
