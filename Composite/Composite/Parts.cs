using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Parts
    {
        //I will keep my parts in here
        private int part_count = 0;
        private string[] parts = new string[10];

        public void addPart(string name)
        {
            parts[part_count] = name;

            part_count++;
        }

        public void listParts()
        {
            Console.WriteLine("There are " + part_count + " parts ");
            for (int i = 0; i < part_count; i++)
            {
                Console.WriteLine("Machine: " + parts[i]);
            }
        }
    }
}
