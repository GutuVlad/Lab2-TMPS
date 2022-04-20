using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Aircraft : IAircraft
    {
        public string brand = "";
        public string model = "";
        public int price = 0;
        public bool hasExtendedSeats = false;
        public bool hasExtendedFuelTanks = false;

        public Aircraft(string _brand, string _model, int _price)
        {
            this.brand = _brand;
            this.model = _model;
            this.price = _price;
        }

        public bool hasDecoration
        {
            get { return false; }
            set { }
        }

        public void apply_decoration(Aircraft _ac, string decorationType, bool hasOrNot)
        {
            if (decorationType == "fueltank") this.hasExtendedFuelTanks = hasOrNot;
            else if (decorationType == "seats") this.hasExtendedSeats = hasOrNot;
        }

        public void print_aircraft_information()
        {
            Console.WriteLine("#################################");
            Console.WriteLine("Aircraft Brand : " + this.brand);
            Console.WriteLine("Aircraft model : " + this.model);
            Console.WriteLine("Aircraft price : " + this.price);
            Console.WriteLine("Aircraft has Extended Seats : " + this.hasExtendedSeats.ToString());
            Console.WriteLine("Aircraft has Extended FuelTanks : " + this.hasExtendedFuelTanks.ToString());
            Console.WriteLine("#################################");
        }
    }
}
