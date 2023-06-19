using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneSistemiWinForms.Controller.Factory
{
    public sealed class ControllerFactory
    {
        private static ControllerFactory instance = null;

        public static ControllerFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ControllerFactory();
                }
                return instance;
            }
        }

        public static BaseController createController(string controllerName)
        {
            string procesedControllerName;

            procesedControllerName = controllerName.Trim();
            procesedControllerName = controllerName.ToLower();

            switch (procesedControllerName)
            {
                case ("book"):
                    return new BookController();
                case ("history"):
                    return new HistoryController();
                case ("member"):
                    return new MemberController();
                case ("rezervation"):
                    return new RezervationController();
                case ("ui"):
                    return new UIController();
                default:
                    return null;
            }

        }

    }
}
