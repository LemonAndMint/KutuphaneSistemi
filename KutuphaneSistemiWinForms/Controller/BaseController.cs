using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneSistemiWinForms.Database.Manager;

namespace KutuphaneSistemiWinForms.Controller
{
    public class BaseController
    {
        public DatabaseManager databaseManager { get; set; }

        public BaseController()
        {
            databaseManager = new DatabaseManager();
        }

    }
}
