using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface SerialDeviceInterface
    {
        void connectDevice();
        void disconnectDevice();
    }
}
