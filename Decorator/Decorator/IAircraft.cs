using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    interface IAircraft
    {
        void apply_decoration(Aircraft _ac, string decorationType, bool hasOrNot);
    }
}
