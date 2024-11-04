using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10
{
    public class Employee : OrganizationComponent
    {
        private string name;
        private int salary;
        private string position;
        private bool isContractor;
        public int Salary
        {
            set
            {
                salary = value;
            }
        }
        public Employee(string name, string position, int salary, bool isContractor)
        {
            this.name = name;
            this.position = position;
            this.salary = salary;
            this.isContractor = isContractor;
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String(' ', depth) + $"{name} - {position}, {salary}");
        }
        public override int GetBudget()
        {
            if (!isContractor) { return salary; }
            return 0;
        }
        public override int CountEmployees()
        {
            return 1;
        }
        public override void FindEmployee(string name)
        {
            if (this.name == name)
            {
                Display(0);
            }
        }
    }
}
