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
    public partial class RezervationView : Form
    {
        public Book book;

        public RezervationView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RezervationController rezervationController = (RezervationController)ControllerFactory.createController("rezervation");
            Rezervation rezervation = rezervationController.getCurrentRezervationFromMember(MemberController.currentMember.MemberID);

            rezervation.rezOver = 1;

            rezervationController.updateRezervation(rezervation);

            Rezervation nextRezervation = rezervationController.getLatestRezervationQueue(book.BookID);
            nextRezervation.startTime = DateTime.Now;

            MessageBox.Show("Rezervasyon İadesi Tamamlanmıştır");

            Hide();

        }

        private void RezervationView_Load(object sender, EventArgs e)
        {
            bookName.Text = book.BookName;
            bookAuthor.Text = book.BookAuthor;
            bookCategory.Text = book.BookCategory;
            bookMaterial.Text = book.BookMaterial;
            bookISBN.Text = book.BookISBN;
            bookAssetNumber.Text = book.BookAssetNumber;
            bookShelfID.Text = book.BookShelfID;
            bookCopyCount.Text = book.BookCopyCount.ToString();

            memberName.Text = MemberController.currentMember.MemberName;
            memberNick.Text = MemberController.currentMember.MemberNick;
            memberTelNo.Text = MemberController.currentMember.MemberTelNo;
            memberAdress.Text = MemberController.currentMember.MemberAdress;
            memberMail.Text = MemberController.currentMember.MemberMail;

            RezervationController rezervationController = (RezervationController)ControllerFactory.createController("rezervation");
            Rezervation rezervation = rezervationController.getCurrentRezervationFromMember(MemberController.currentMember.MemberID);

            bookRezervationTime.Text = rezervation.startTime.ToShortDateString();
        }
    }
}
