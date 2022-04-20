using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //These are my complex and single classes
            Employees employees = new Employees();
            Machines machines = new Machines();
            Parts parts = new Parts();

            employees.addEmploye("Burak", "Engineer");
            employees.addEmploye("Hamdi", "Mechanic");
            employees.addEmploye("TUFAN", "Developer");
            employees.addEmploye("TheCodeProgram", "Boss");

            machines.addMachine("Driller", "Mechanical");
            machines.addMachine("Computer", "Electronic");

            parts.addPart("Wing");
            parts.addPart("WEngine");
            parts.addPart("Landing Gears");
            parts.addPart("Rudder");

            Console.WriteLine("##The aircraft was produced by :##");
            employees.listEmployees();
            Console.WriteLine(" ##using## ");
            machines.listMachines();
            Console.WriteLine(" ##with get combined##");
            parts.listParts();

            Console.ReadLine();
        }
    }
}