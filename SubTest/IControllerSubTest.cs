using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubTest
{
    internal interface IControllerSubTest
    {
        IModelSubTest Model { get; set; }
        IViewSubTest View { get; set; }
    }
}
