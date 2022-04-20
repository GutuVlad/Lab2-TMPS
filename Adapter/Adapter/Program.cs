using System;
namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialDeviceManager manager = new SerialDeviceManager();
            manager.connectDevice();
            Console.WriteLine("Make here some operations...");
            manager.disconnectDevice();
            Console.ReadLine();

        }
    }
}