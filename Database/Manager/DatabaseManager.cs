using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Services.Maps;

using KutuphaneSistemi.Database.EntityFramework;
using KutuphaneSistemi.SystemData;
using KutuphaneSistemi.SystemData.Member;
using KutuphaneSistemi.WinUI;
using System.Reflection;
using System.Diagnostics;
using MySqlX.XDevAPI.Common;

namespace KutuphaneSistemi.Database.Manager
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
        public void createData<T>(T data) where T : Data {

            context = new DatabaseContext();

            if (typeof(T) == typeof(Book))
            {
                /* data once object tipine sonrasinda Book tipine donusturulur. 
                 * bu donusturme asagisi icin de gecerlidir. \ Corpyr
                 */
                DatabaseCRUD.createFrom<Book>(context.Book, (Book)(object)data);
            }
            else if (typeof(T) == typeof(SystemHistory))
            {
                DatabaseCRUD.createFrom<SystemHistory>(context.SystemHistory, (SystemHistory)(object)data);
            }
            else if (typeof(T) == typeof(Rezervation))
            {
                DatabaseCRUD.createFrom<Rezervation>(context.Rezervation, (Rezervation)(object)data);
            }
            else if (typeof(T) == typeof(PersonelMember))
            {
                DatabaseCRUD.createFrom<PersonelMember>(context.PersonelMember, (PersonelMember)(object)data);
            }
            else if (typeof(T) == typeof(NormalMember))
            {
                DatabaseCRUD.createFrom<NormalMember>(context.NormalMember, (NormalMember)(object)data);
            }
            else
            {
                new Exception();
            }
        }

        /*
         * listData metodu icin switch/case yapisi kullanilamadi. Type degiskenleri
         * switch/case yapisinda pattern type'larla karsilastirilamiyor. \ Corpyr
         */
        public List<Data> listData<T>(List<String> variableNames, List<String> searchValues) where T : Data
        {
            context = new DatabaseContext();
            
            List<Data> result = null;
            String query = Parser.unparseAdd<T>(variableNames, searchValues);

            if (typeof(T) == typeof(Book))
            {
                result = DatabaseCRUD.readFrom<Book>(context.Book, query);
            }
            else if (typeof(T) == typeof(SystemHistory))
            {
                result = DatabaseCRUD.readFrom<SystemHistory>(context.SystemHistory, query);
            }
            else if (typeof(T) == typeof(Rezervation))
            {
                result = DatabaseCRUD.readFrom<Rezervation>(context.Rezervation, query);
            }
            else if (typeof(T) == typeof(PersonelMember))
            {
                result = DatabaseCRUD.readFrom<PersonelMember>(context.PersonelMember, query);
            }
            else if (typeof(T) == typeof(NormalMember))
            {
                result = DatabaseCRUD.readFrom<NormalMember>(context.NormalMember, query);
            }
            else
            {
                new Exception();
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
                DatabaseCRUD.updateFrom<Book>(context.Book, (Book)(object)data);
            }
            else if (typeof(T) == typeof(SystemHistory))
            {
                DatabaseCRUD.updateFrom<SystemHistory>(context.SystemHistory, (SystemHistory)(object)data);
            }
            else if (typeof(T) == typeof(Rezervation))
            {
                DatabaseCRUD.updateFrom<Rezervation>(context.Rezervation, (Rezervation)(object)data);
            }
            else if (typeof(T) == typeof(PersonelMember))
            {
                DatabaseCRUD.updateFrom<PersonelMember>(context.PersonelMember, (PersonelMember)(object)data);
            }
            else if (typeof(T) == typeof(NormalMember))
            {
                DatabaseCRUD.updateFrom<NormalMember>(context.NormalMember, (NormalMember)(object)data);
            }
            else
            {
                new Exception();
            }
        }
        public void deleteData<T>(T data) where T : Data
        {
            context = new DatabaseContext();

            if (typeof(T) == typeof(Book))
            {
                /* data once object tipine sonrasinda Book tipine donusturulur. 
                 * bu donusturme asagisi icin de gecerlidir. \ Corpyr
                 */
                DatabaseCRUD.deleteFrom<Book>(context.Book, (Book)(object)data);
            }
            else if (typeof(T) == typeof(SystemHistory))
            {
                DatabaseCRUD.deleteFrom<SystemHistory>(context.SystemHistory, (SystemHistory)(object)data);
            }
            else if (typeof(T) == typeof(Rezervation))
            {
                DatabaseCRUD.deleteFrom<Rezervation>(context.Rezervation, (Rezervation)(object)data);
            }
            else if (typeof(T) == typeof(PersonelMember))
            {
                DatabaseCRUD.deleteFrom<PersonelMember>(context.PersonelMember, (PersonelMember)(object)data);
            }
            else if (typeof(T) == typeof(NormalMember))
            {
                DatabaseCRUD.deleteFrom<NormalMember>(context.NormalMember, (NormalMember)(object)data);
            }
            else
            {
                new Exception();
            }
        }




    }
}
