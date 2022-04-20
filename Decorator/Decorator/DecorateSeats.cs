using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class DecorateSeats : IAircraft
    {
        private bool hasExtendenSeats = false;

        public bool hasDecoration
        {
            get { return hasExtendenSeats; }
            set { hasExtendenSeats = value; }
        }

        public void apply_decoration(Aircraft _ac, string decorationType, bool hasOrNot)
        {
            this.hasExtendenSeats = hasOrNot;
            _ac.apply_decoration(_ac, decorationType, hasOrNot);
            Console.WriteLine("Seats decoration Applied Status : " + hasOrNot.ToString());
        }
    }
}
