using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneSistemi.Database.Connection;
using MySql.Data.MySqlClient;

namespace KutuphaneSistemi
{
    public class TestBackEnd
    {
        public TestBackEnd()
        {
            DatabaseConnector e = new DatabaseConnector();

            try
            {
                e.connector.Open();
                Debug.WriteLine("Opened");
            }
            catch (MySqlException sqlException)
            {
                e.connector.Close();
                Debug.WriteLine("Couldnt Started");
                Debug.WriteLine(sqlException.Message); //Hata Mesajı
                throw;
            }

            e.connector.Close();
        }
    }
}
