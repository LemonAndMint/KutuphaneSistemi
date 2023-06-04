using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data;
using System.Linq.Expressions;

using KutuphaneSistemi.Database.EntityFramework;
using KutuphaneSistemi.SystemData.Member;
using KutuphaneSistemi.SystemData;

using Microsoft.EntityFrameworkCore;

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

            entities.Add(data);

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

            resultDataList = entities.FromSqlRaw(query).ToList<Data>();
            
            return resultDataList;
        }

        /* create ve update islemlerinin ayri ayri yazilmasinin nedeni CRUD
         * yapisinin korunmasi ve okunabilirliginj arttirilmasidir. \ Corpyr
         */
        static public void updateFrom<T> (DbSet<T> entities, T data) where T : Data {
           
            entities.Update(data); // data veritabaninda yoksa veriyi ekler eger varsa gunceller ama biz verinin veritabanında oldugunu varsayiyoruz. / Corpyr
        
        }
        static public void deleteFrom<T>(DbSet<T> entities, T data) where T : Data {
          
            entities.Remove(data);

        }
      
    }
}
