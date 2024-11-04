using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Department main = new Department("Company");
            Department d1 = new Department("Managment");
            Department d2 = new Department("HR");
            Department d3 = new Department("IT");

            Employee e1 = new Employee("Alex", "manager", 320000, false);
            Employee e2 = new Employee("Koko", "hr-manager", 250000, false);
            Employee e3 = new Employee("Alan", "developer", 650000, false);
            Employee e4 = new Employee("Poky", "manager", 350000, true);
            Employee e5 = new Employee("Bob", "software tester", 300000, false);
            Employee e6 = new Employee("Anna", "developer", 1200000, false);

            main.AddComponent(d1);
            main.AddComponent(d3);

            d1.AddComponent(d2);
            d1.AddComponent(e1);
            d1.AddComponent(e4);

            d2.AddComponent(e2);

            d3.AddComponent(e3);
            d3.AddComponent(e5);
            d3.AddComponent(e6);

            main.Display(0);
            Console.WriteLine();

            main.FindEmployee("Koko");
            Console.WriteLine();

            d1.Display(0);
            Console.WriteLine();

            e2.Salary = 400000;

            d1.Display(0);
            Console.WriteLine();
        }

    }
}
