using KutuphaneSistemi.Database.Manager;
using KutuphaneSistemi.SystemData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneSistemi.Controller
{
    public class BookController : BaseController
    {
        public void createBook(Book book)
        {
            databaseManager.createData<Book>(book);
        }
        public void updateBook(Book book)
        {
            databaseManager.updateData<Book>(book);
        }

        /*
         * listData List<Data> listesi dondurur. List<Data> listesini Cast<T> yardimiyla 
         * Book tipine, sonra da Listeye donusturduk. \Corpyr
         */
        public List<Book> searchBook(List<String> variableNames, List<String> searchValues)
        {
            List<Book> listOfBooks = databaseManager.listData<Book>(variableNames, searchValues).Cast<Book>().ToList();

            return listOfBooks;
        }
    }
}
