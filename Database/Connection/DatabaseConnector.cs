using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace KutuphaneSistemi.Database.Connection
{
    public class DatabaseConnector
    {
        public MySqlConnection connector { get; }
        public DatabaseConnector() //Default ayarlarla bağlanma. / Corpyr
        {
            //Default ayarlar localhost servere baglanan ve herhangi bir veritabanina baglanmayan bir baglantidir. / Corpyr
            connector = new MySqlConnection("Server=localhost;Database=;Uid=root;Pwd='1234';");
            OpenConnection();
        }

        public void OpenConnection()
        {
            try
            {
                connector.Open();
                Debug.WriteLine("Opened");
            }
            catch (MySqlException sqlException)
            {
                connector.Close();
                Debug.WriteLine("Couldnt Started");
                Debug.WriteLine(sqlException.Code);
                Debug.WriteLine(sqlException.Message); //Hata Mesajı
                throw;
            }
        }

        public void CloseConnection()
        {
            try
            {
                connector.Close();
            }
            catch (MySqlException sqlException)
            {
                Debug.WriteLine("Couldnt Stoped");
                Debug.WriteLine(sqlException.Code);
                Debug.WriteLine(sqlException.Message); //Hata Mesajı
                throw;
            }
        }

    }
}
