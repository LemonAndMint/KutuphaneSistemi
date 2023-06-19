using KutuphaneSistemiWinForms.Controller.Factory;
using KutuphaneSistemiWinForms.Controller;
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

namespace KutuphaneSistemiWinForms.Displays
{
    public partial class BookUpdateView : Form
    {
        public Book book;

        public BookUpdateView()
        {
            InitializeComponent();
        }

        private void BookUpdateView_Load(object sender, EventArgs e)
        {
            bookName.Text = book.BookName;
            bookAuthor.Text = book.BookAuthor;
            bookCategory.Text = book.BookCategory;
            bookMaterial.Text = book.BookMaterial;
            bookISBN.Text = book.BookISBN;
            bookAssetNumber.Text = book.BookAssetNumber;
            bookShelfID.Text = book.BookShelfID;
            bookCopyCount.Text = book.BookCopyCount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book updateBook = new Book();
            BookController bookController = (BookController)ControllerFactory.createController("book");

            updateBook.BookID = book.BookID;
            updateBook.BookName = bookName.Text;
            updateBook.BookAuthor = bookAuthor.Text;
            updateBook.BookCategory = bookCategory.Text;
            updateBook.BookMaterial = bookMaterial.Text;
            updateBook.BookShelfID = bookShelfID.Text;
            updateBook.BookAssetNumber = bookAssetNumber.Text;
            updateBook.BookISBN = bookISBN.Text;

            bookController.updateBook(updateBook);

            MessageBox.Show("Kitap Güncellemesi Tamamlanmıştır");

            Hide();
        }

        
    }
}
