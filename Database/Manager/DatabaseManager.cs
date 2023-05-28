using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Services.Maps;

using KutuphaneSistemi.Database.Connection;
using KutuphaneSistemi.Database.EntityFramework;
using KutuphaneSistemi.SystemData;
using KutuphaneSistemi.SystemData.Member;

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

        public String listData<T>(T data, List<String> variableNames, List<String> searchValues)
        {



            context = new DatabaseContext();

            switch (data)
            {
                case Book:
                    DatabaseCRUD.readFrom<Book>(context.Book, )
                        break;
                case SystemHistory:

                case Rezervation:

                case NormalMember: 


                default:
                    break;
            }

            
        }

    }
}
