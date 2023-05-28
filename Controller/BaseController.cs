using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KutuphaneSistemi.Database.Manager;

namespace KutuphaneSistemi.Controller
{
    public class BaseController
    {
        public DatabaseManager databaseManager { get; set; }

        public void DestroyController()
        {

        }
    }
}
