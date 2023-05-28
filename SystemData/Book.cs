using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace KutuphaneSistemi.SystemData
{
    public class Book : Data
    {
        public int BookISBN { get; set; }
        public string BookAssetNumber { get; } //Demirbas Numarasi, kitap ilk kayit edildiginde rastgele verilir ve bidaha degistirilemez. / Corpyr
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string BookCategory { get; set; }
        public string BookMaterial { get; set; }
        public int BookCopyCount { get; set; }
        public string BookShelfID { get; set; }

        public Book()
        {
            //#TODO: Eger kitap datasi olusturulmasi gerekilirse bura kullanilacak
        }

    }
}
