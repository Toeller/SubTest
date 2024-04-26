using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubTest
{
    internal interface IViewSubTest
    {
        IModelSubTest Model { get; set; }
        IControllerSubTest Controller { get; set; }
    }
}
