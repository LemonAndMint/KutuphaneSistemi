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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

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
            if (checkBoxs())
            {

                Book createBook = new Book();
                BookController bookController = (BookController)ControllerFactory.createController("book");

                try
                {
                    createBook.BookCopyCount = int.Parse(bookCopyCount.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Kopya sayısı karakter içermemelidir.");
                    return;
                }

                createBook.BookName = bookName.Text;
                createBook.BookAuthor = bookAuthor.Text;
                createBook.BookCategory = bookCategory.Text;
                createBook.BookMaterial = bookMaterial.Text;
                createBook.BookShelfID = bookSelfID.Text;
                createBook.BookAssetNumber = bookAssetNumber.Text;
                createBook.BookISBN = bookISBN.Text;

                try
                {
                    bookController.createBook(createBook);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Yayın oluşturulamadı." + exception.HResult);
                    return;
                }

                MessageBox.Show("Kitap Kayıtı Tamamlanmıştır");

                Hide();
            }

        }

        private bool checkBoxs()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
                {
                    MessageBox.Show("Alanlar boş bırakılmamalıdır.");
                    return false;
                }
            }

            return true;
        }
    }
}
