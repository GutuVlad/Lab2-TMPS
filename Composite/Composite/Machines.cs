using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Machines
    {
        //I will keep my machines in here
        private int machine_count = 0;
        private string[] machiness = new string[10];
        private string[] mac_types = new string[10];

        public void addMachine(string name, string type)
        {
            machiness[machine_count] = name;
            mac_types[machine_count] = type;
            machine_count++;
        }

        public void listMachines()
        {
            Console.WriteLine("There are " + machine_count + " Machines ");
            for (int i = 0; i < machine_count; i++)
            {
                Console.WriteLine("Machine: " + machiness[i] + " and Type : " + mac_types[i]);
            }
        }
    }
}
