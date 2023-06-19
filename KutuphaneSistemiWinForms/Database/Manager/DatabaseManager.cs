using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;
using KutuphaneSistemiWinForms.SystemData;
using KutuphaneSistemiWinForms.SystemData.Member;
using KutuphaneSistemiWinForms;
using KutuphaneSistemiWinForms.Database.EntityFramework;

namespace KutuphaneSistemiWinForms.Database.Manager
{
    /*
     * DatabaseManager, veritabanina erisim ve islemleri icin kullanilacak olan siniftir.
     * Tum veritabani islemlerini tek bir siniftan erisim saglayacagiz. Singleton bir siniftir. / Corpyr
     */
    public sealed class DatabaseManager
    {
        private static DatabaseManager instance = null;
        private DatabaseContext context;

        public static DatabaseManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseManager();

                }
                return instance;
            }
        }
        public void createData<T>(T data) where T : Data
        {

            context = new DatabaseContext();

            if (typeof(T) == typeof(Book))
            {
                /* data once object tipine sonrasinda Book tipine donusturulur. 
                 * bu donusturme asagisi icin de gecerlidir. \ Corpyr
                 */
                DatabaseCRUD.createFrom(context.Book, (Book)(object)data);
            }
            else if (typeof(T) == typeof(SystemHistory))
            {
                DatabaseCRUD.createFrom(context.SystemHistory, (SystemHistory)(object)data);
            }
            else if (typeof(T) == typeof(Rezervation))
            {
                DatabaseCRUD.createFrom(context.Rezervation, (Rezervation)(object)data);
            }
            else if (typeof(T) == typeof(NormalMember))
            {
                DatabaseCRUD.createFrom(context.NormalMember, (NormalMember)(object)data);
            }
            else
            {
                new Exception();
                return;

            }

            context.SaveChanges();
        }

        /*
         * listData metodu icin switch/case yapisi kullanilamadi. Type degiskenleri
         * switch/case yapisinda pattern type'larla karsilastirilamiyor. \ Corpyr
         */
        public List<Data> listData<T>(List<string> variableNames, List<string> searchValues) where T : Data
        {
            if (variableNames == null || searchValues == null || variableNames.Count != searchValues.Count)
            {
                return null;
            }

            context = new DatabaseContext();

            List<Data> result = null;
            string query = Parser.unparseAdd<T>(variableNames, searchValues);

            if (typeof(T) == typeof(Book))
            {
                result = DatabaseCRUD.readFrom(context.Book, query);
            }
            else if (typeof(T) == typeof(SystemHistory))
            {
                result = DatabaseCRUD.readFrom(context.SystemHistory, query);
            }
            else if (typeof(T) == typeof(Rezervation))
            {
                result = DatabaseCRUD.readFrom(context.Rezervation, query);
            }
            else if (typeof(T) == typeof(NormalMember))
            {
                result = DatabaseCRUD.readFrom(context.NormalMember, query);
            }
            else
            {
                new Exception();
                return null;

            }
            return result;

        }

        public void updateData<T>(T data) where T : Data
        {
            context = new DatabaseContext();

            if (typeof(T) == typeof(Book))
            {
                /* data once object tipine sonrasinda Book tipine donusturulur. 
                 * bu donusturme asagisi icin de gecerlidir. \ Corpyr
                 */
                DatabaseCRUD.updateFrom(context.Book, (Book)(object)data);
            }
            else if (typeof(T) == typeof(SystemHistory))
            {
                DatabaseCRUD.updateFrom(context.SystemHistory, (SystemHistory)(object)data);
            }
            else if (typeof(T) == typeof(Rezervation))
            {
                DatabaseCRUD.updateFrom(context.Rezervation, (Rezervation)(object)data);
            }
            else if (typeof(T) == typeof(NormalMember))
            {
                DatabaseCRUD.updateFrom(context.NormalMember, (NormalMember)(object)data);
            }
            else
            {
                new Exception();
                return;

            }
            context.SaveChanges();
        }
        public void deleteData<T>(T data) where T : Data
        {
            context = new DatabaseContext();

            if (typeof(T) == typeof(Book))
            {
                /* data once object tipine sonrasinda Book tipine donusturulur. 
                 * bu donusturme asagisi icin de gecerlidir. \ Corpyr
                 */
                DatabaseCRUD.deleteFrom(context.Book, (Book)(object)data);
            }
            else if (typeof(T) == typeof(SystemHistory))
            {
                DatabaseCRUD.deleteFrom(context.SystemHistory, (SystemHistory)(object)data);
            }
            else if (typeof(T) == typeof(Rezervation))
            {
                DatabaseCRUD.deleteFrom(context.Rezervation, (Rezervation)(object)data);
            }
            else if (typeof(T) == typeof(NormalMember))
            {
                DatabaseCRUD.deleteFrom(context.NormalMember, (NormalMember)(object)data);
            }
            else
            {
                new Exception();
                return;
            }

            context.SaveChanges();

        }

    }
}
