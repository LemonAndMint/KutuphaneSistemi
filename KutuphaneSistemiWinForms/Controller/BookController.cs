using KutuphaneSistemiWinForms.Database.Manager;
using KutuphaneSistemiWinForms.SystemData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneSistemiWinForms.Controller
{
    public class BookController : BaseController
    {
        public void createBook(Book book)
        {
            databaseManager.createData(book);
        }
        public void updateBook(Book book)
        {
            databaseManager.updateData(book);
        }

        /*
         * listData List<Data> listesi dondurur. List<Data> listesini Cast<T> yardimiyla 
         * Book tipine, sonra da Listeye donusturduk. \Corpyr
         */
        public List<Book> searchBook(List<string> variableNames, List<string> searchValues)
        {
            List<Book> listOfBooks = databaseManager.listData<Book>(variableNames, searchValues).Cast<Book>().ToList();

            return listOfBooks;
        }
    }
}
