using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //First declare the Aircraft component
            Aircraft _aircraft = new Aircraft("Boeing", "B777", 295000000);
            //Then declare the decorator classes
            DecorateFuelTank decorateFuelTank = new DecorateFuelTank();
            DecorateSeats decorateSeats = new DecorateSeats();

            //then decorate the status of aircraft and print
            decorateFuelTank.apply_decoration(_aircraft, "fueltank", true);
            decorateSeats.apply_decoration(_aircraft, "seats", false);
            _aircraft.print_aircraft_information();

            Console.WriteLine("---------------------------------------");
            //redecorate it again and print again
            decorateFuelTank.apply_decoration(_aircraft, "fueltank", false);
            decorateSeats.apply_decoration(_aircraft, "seats", true);
            _aircraft.print_aircraft_information();
            Console.ReadLine();
        }
    }
}