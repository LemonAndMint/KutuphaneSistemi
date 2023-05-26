using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneSistemi.Database.Connection;
using Windows.Services.Maps;

namespace KutuphaneSistemi.Database.Manager
{
    /*
     * DatabaseManager, veritabanina erisim ve islemleri icin kullanilacak olan siniftir.
     * Tum veritabani islemlerini tek bir siniftan erisim saglayacagiz. Singleton bir siniftir. / Corpyr
     */
    public sealed class DatabaseManager 
    {
        private static DatabaseManager instance = null;
        private List<DatabaseConnector> dbconnections;

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

        public DatabaseManager()
        {
            
        }

        public void StartDatabaseConnection() //#TODO: Dictionary seklinde yap. /Corpyr
        {
            dbconnections.add = new DatabaseConnector();
        }

        public void OpenDatabaseConnection()
        {
            dbconnection.OpenConnection();
        }

        public void CloseDatabaseConnecton() 
        {
            dbconnection.CloseConnection();
        }


    }
}
