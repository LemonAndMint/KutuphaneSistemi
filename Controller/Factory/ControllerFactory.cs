using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneSistemi.Controller.Factory
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

        public void createController(String controllerName)
        {

        }

        public void destryCurrentControllers(String displayName)
        {

        }

        public void destroyAllControllers()
        {

        }

    }
}
