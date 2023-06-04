using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneSistemi.SystemData
{
    public class Book : Data
    {
        public int BookID { get; set; }
        public string BookISBN { get; set; }
        public string BookAssetNumber { get; set; } //Demirbas Numarasi, kitap ilk kayit edildiginde rastgele verilir ve bidaha degistirilemez. / Corpyr
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string BookCategory { get; set; }
        public string BookMaterial { get; set; }
        public int BookCopyCount { get; set; }
        public string BookShelfID { get; set; }

        public Book()
        {

        }

    }
}
