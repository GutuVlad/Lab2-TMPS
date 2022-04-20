using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Employees
    {
        //I will keep my employees in here
        private int employee_count = 0;
        private string[] employees = new string[10];
        private string[] emp_roles = new string[10];

        public void addEmploye(string name, string role)
        {
            employees[employee_count] = name;
            emp_roles[employee_count] = role;
            employee_count++;
        }

        public void listEmployees()
        {
            Console.WriteLine("There are " + employee_count + " employees ");
            for (int i = 0; i < employee_count; i++)
            {
                Console.WriteLine("Name: " + employees[i] + ". Role : " + emp_roles[i]);
            }
        }
    }
}
