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

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //modelSubTest = new ModelSubTest();
            //viewSubTest = new ViewSubTest();
            //controllerSubTest = new ControllerSubTest();

            //modelSubTest.ViewSubtest = viewSubTest;
            //modelSubTest.ControllerSubtest = controllerSubTest;

            //viewSubTest.ModelSubTest = modelSubTest;
            //viewSubTest.ControllerSubTest = controllerSubTest;

            //controllerSubTest.ModelSubTest =  modelSubTest;
            //controllerSubTest.ViewSubTest = viewSubTest;

            Application.Run(new ViewSubTest());
        }
    }
}
