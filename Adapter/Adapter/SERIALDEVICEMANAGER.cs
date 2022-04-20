using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class SerialDeviceManager : SerialDeviceInterface
    {
        public void connectDevice()
        {
            Console.WriteLine("Device Connected...");
        }

        public void disconnectDevice()
        {
            Console.WriteLine("Device Disconnected...");
        }

        private void anotherMethod()
        {
            //This method not required at main program
        }
    }
}
