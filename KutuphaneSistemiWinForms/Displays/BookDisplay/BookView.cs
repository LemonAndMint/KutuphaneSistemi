using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KutuphaneSistemiWinForms.Controller;
using KutuphaneSistemiWinForms.Controller.Factory;
using KutuphaneSistemiWinForms.SystemData;

namespace KutuphaneSistemiWinForms.Displays.BookDisplay
{
    public partial class BookView : Form
    {
        public Book book;
        bool isrezerved;

        public BookView()
        {
            InitializeComponent();
        }

        private void BookView_Load(object sender, EventArgs e)
        {
            bookName.Text = book.BookName;
            bookAuthor.Text = book.BookAuthor;
            bookCategory.Text = book.BookCategory;
            bookMaterial.Text = book.BookMaterial;
            bookISBN.Text = book.BookISBN;
            bookAssetNumber.Text = book.BookAssetNumber;
            bookShelfID.Text = book.BookShelfID;
            bookCopyCount.Text = book.BookCopyCount.ToString();

            int bookID = int.Parse(book.BookID.ToString());

            RezervationController rezervationController = (RezervationController)ControllerFactory.createController("rezervation");
            isrezerved = rezervationController.getRezervOrTaken(bookID);

            if (isrezerved == true)
            {
                button1.Text = "Rezerve Sırasına Gir";
            }
            else
            {
                button1.Text = "Rezerve Et";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RezervationController rezervationController = (RezervationController)ControllerFactory.createController("rezervation");
            BookController bookController = (BookController)ControllerFactory.createController("book");

            Rezervation rezervation = new Rezervation();

            rezervation.bookID = book.BookID;
            rezervation.memberID = MemberController.currentMember.MemberID;
            rezervation.startTime = DateTime.Now;
            rezervation.rezOver = 0;

            rezervationController.createRezervation(rezervation);

            MessageBox.Show("Rezervasyon Tamamlanmıştır");

            Hide();
        }
    }
}
