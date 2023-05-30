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
        /*
         * listData metodu icin reflection kullanmayi denedik fakat DatabaseContext sinifindaki
         * DBSet degiskenlerinin kullanimi Invoke ile mumkun olmadi. Kullansaydik yine bir switch/case yapisi 
         * kurmamiz gerekeceginden su anki yapiya donduk. \ Corpyr.
         */
        public List<Data> listData<T>(T data, List<String> variableNames, List<String> searchValues)
        {

            String query = null;
            List<Data> result = null;

            context = new DatabaseContext();

            switch (data)
            {
                case Book:

                    query = Parser.unparseAdd<Book>(variableNames, searchValues);
                    result = DatabaseCRUD.readFrom<Book>(context.Book, query);
                        break;

                case SystemHistory:

                    query = Parser.unparseAdd<SystemHistory>(variableNames, searchValues);
                    result = DatabaseCRUD.readFrom<SystemHistory>(context.SystemHistory, query);
                    break;

                case Rezervation:

                    query = Parser.unparseAdd<SystemHistory>(variableNames, searchValues);
                    result = DatabaseCRUD.readFrom<SystemHistory>(context.SystemHistory, query);
                    break;

                case PersonelMember: //Her zaman ustte olmak zorunda cunku NormalMember parent. \Corpyr.

                    query = Parser.unparseAdd<PersonelMember>(variableNames, searchValues);
                    result = DatabaseCRUD.readFrom<PersonelMember>(context.PersonelMember, query);
                    break;

                case NormalMember:
                    
                    query = Parser.unparseAdd<NormalMember>(variableNames, searchValues);
                    result = DatabaseCRUD.readFrom<NormalMember>(context.NormalMember, query);
                    
                    break;

                default:

                    new Exception();
                    break;
            }

            return result;
            
        }

    }
}
