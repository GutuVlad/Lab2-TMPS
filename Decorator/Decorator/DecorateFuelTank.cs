using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class DecorateFuelTank : IAircraft
    {
        private bool hasExtendenFuelTank = false;

        public bool hasDecoration
        {
            get { return hasExtendenFuelTank; }
            set { hasExtendenFuelTank = value; }
        }

        public void apply_decoration(Aircraft _ac, string decorationType, bool hasOrNot)
        {
            this.hasExtendenFuelTank = hasOrNot;
            _ac.apply_decoration(_ac, decorationType, hasOrNot);
            Console.WriteLine("FuelTank decoration Applied Status : " + hasOrNot.ToString());
        }
    }
}
