using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubTest
{
    internal interface IModelSubTest
    {
        IViewSubTest View { get; set; }
        IControllerSubTest Controller { get; set; }
    }
}
