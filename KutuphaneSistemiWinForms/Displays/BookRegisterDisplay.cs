using KutuphaneSistemi.Controller;
using KutuphaneSistemi.SystemData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneSistemiWinForms
{
    public partial class BookRegisterDisplay : Form
    {
        public BookRegisterDisplay()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Book createBook = new Book();
            BookController bookController = new BookController();

            createBook.BookName = bookName.Text;
            createBook.BookAuthor = bookAuthor.Text;
            createBook.BookCategory = bookCategory.Text;
            createBook.BookMaterial = bookMaterial.Text;
            createBook.BookShelfID = bookSelfID.Text;
            createBook.BookAssetNumber = bookAssetNumber.Text;
            createBook.BookISBN = bookISBN.Text;
            createBook.BookCopyCount = int.Parse(bookCopyCount.Text);

            //#TODO bos texboxlara bak ve pop up olustur.

            bookController.createBook(createBook);
        }
    }
}
