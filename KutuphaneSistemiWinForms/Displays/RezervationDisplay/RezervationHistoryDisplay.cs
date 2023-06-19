using KutuphaneSistemiWinForms.Controller;
using KutuphaneSistemiWinForms.Controller.Factory;
using KutuphaneSistemiWinForms.SystemData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneSistemiWinForms.Displays.RezervationDisplay
{
    public partial class RezervationHistoryDisplay : Form
    {
        public RezervationHistoryDisplay()
        {
            InitializeComponent();
        }

        private void RezervationHistoryDisplay_Load(object sender, EventArgs e)
        {
            RezervationController rezervationController = (RezervationController)ControllerFactory.createController("rezervation");
            List<Rezervation> rezervations = rezervationController.getRezervationFromMember(MemberController.currentMember.MemberID);

            BookController bookController = (BookController)ControllerFactory.createController("book");

            dataGridView1.DataSource = rezervations;
        }
    }
}
