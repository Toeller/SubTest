using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubTest
{
    internal static class Program
    {


        private static IModelSubTest modelSubTest;
        private static IViewSubTest viewSubTest;
        private static IControllerSubTest controllerSubTest;

        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            modelSubTest = new ModelSubTest();
            viewSubTest = new ViewSubTest();
            controllerSubTest = new ControllerSubTest();

            modelSubTest.View = viewSubTest;
            modelSubTest.Controller = controllerSubTest;

            viewSubTest.Model = modelSubTest;
            viewSubTest.Controller = controllerSubTest;

            controllerSubTest.Model = modelSubTest;
            controllerSubTest.View = viewSubTest;

            Application.Run((Form) viewSubTest);
        }
    }
}
