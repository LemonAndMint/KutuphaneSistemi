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
    public partial class AnonimMenuDisplay : Form
    {
        public AnonimMenuDisplay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RezervationMakeDisplay rezervationMake = new RezervationMakeDisplay();
            rezervationMake.Show();
        }
    }
}
