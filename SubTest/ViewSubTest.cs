using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubTest
{
    public partial class ViewSubTest : Form , IViewSubTest
    {
        public ViewSubTest()
        {
            InitializeComponent();
        }

        IModelSubTest IViewSubTest.Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IControllerSubTest IViewSubTest.Controller { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
