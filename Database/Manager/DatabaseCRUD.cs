using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

using MySql.Data.MySqlClient;

using KutuphaneSistemi.Database.Connection;
using KutuphaneSistemi.Database.EntityFramework;
using KutuphaneSistemi.SystemData.Member;
using KutuphaneSistemi.SystemData;

namespace KutuphaneSistemi.Database.Manager
{
    static public class DatabaseCRUD
    {

        /*
         * Bu sinifta olusturulmus metodlarda CRUD islemlerinin genellestirilmesi icin 
         * kullanilacak veri ve database ile veri sinifleri arasindaki baglantiyi kuracak olan entity framework 
         * generic olarak yazilmistir. / Corpyr
         */
        static public void createFrom<T>(DbSet<T> entities,T data) where T : Data {

            try
            {
                using (DatabaseContext context = new DatabaseContext())
                {
                    entities.Add(data);

                }
            }
            catch (MySqlException sqlException)
            {
                Debug.WriteLine("CRUD Create");
                Debug.WriteLine(sqlException.Code);
                Debug.WriteLine(sqlException.Message);
                Debug.WriteLine(data);
                throw;
            }
        
        }
        /*
         * query degiskeni burda Parser tarafindan hazirlanacak olan bir arama istegidir. Normalde Linq ile kullanilan 
         * arama isteklerini direkt metod icerisine yazmak yerine metoda string degisken olarak atadık boylece metodu 
         * modulerlestirdik. 
         * 
         * Burda sadece okuma yaptigimizdan herhangi bir veri girisi almak yerine bir query aldik. 
         * 
         * Sadece bu metodda bir query degiskeni vardir cunku diger islemler komplike sql queryleri icermez.
         * Entity Framework icerisindeki metodlari kullanabiliriz. / Corpyr
         */
        static public List<Data> readFrom<T>(DbSet<T> entities, String query) where T : Data {

            List<Data> resultDataList = null;

            try
            {
                using (DatabaseContext context = new DatabaseContext())
                {
                   resultDataList = entities.SqlQuery(query).ToList<Data>();
                }
            }
            catch (MySqlException sqlException)
            {
                Debug.WriteLine("CRUD Read");
                Debug.WriteLine(sqlException.Code);
                Debug.WriteLine(sqlException.Message);
                throw;
            }

            return resultDataList;
        }

        /* create ve update islemlerinin ayri ayri yazilmasinin nedeni CRUD
         * yapisinin korunmasi ve okunabilirliginj arttirilmasidir. \ Corpyr
         */
        static public void updateFrom<T> (DbSet<T> entities, T data) where T : Data {

            try
            {
                using (DatabaseContext context = new DatabaseContext())
                {
                    entities.AddOrUpdate(data); // data veritabaninda yoksa veriyi ekler eger varsa gunceller ama biz verinin veritabanında oldugunu varsayiyoruz. / Corpyr
                }
            }
            catch (MySqlException sqlException)
            {
                Debug.WriteLine("CRUD Update");
                Debug.WriteLine(sqlException.Code);
                Debug.WriteLine(sqlException.Message);
                throw;
            }

        }
        static public void deleteFrom<T>(DbSet<T> entities, T data) where T : Data {

            try
            {
                using (DatabaseContext context = new DatabaseContext())
                {
                    entities.Remove(data);
                }
            }
            catch (MySqlException sqlException)
            {
                Debug.WriteLine("CRUD Delete");
                Debug.WriteLine(sqlException.Code);
                Debug.WriteLine(sqlException.Message);
                throw;
            }

        }
      
    }
}
