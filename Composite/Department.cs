using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10
{
    public class Department : OrganizationComponent
    {
        private string name;
        private List<OrganizationComponent> components;
        public Department(string name)
        {
            this.name = name;
            components = new List<OrganizationComponent>();
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String(' ', depth) + $"{name} (count employees: {CountEmployees()}, total buget:{GetBudget()})");
            foreach (OrganizationComponent component in components)
            {
                component.Display(depth + 3);
            }
        }
        public override void AddComponent(OrganizationComponent component)
        {
            components.Add(component);
        }
        public override int GetBudget()
        {
            int budget = 0;
            foreach (OrganizationComponent component in components)
            {
                budget += component.GetBudget();
            }
            return budget;
        }
        public override int CountEmployees()
        {
            int count = 0;
            foreach (OrganizationComponent component in components)
            {
                count += component.CountEmployees();
            }
            return count;
        }
        public override void FindEmployee(string name)
        {
            foreach (OrganizationComponent component in components)
            {
                component.FindEmployee(name);
            }
        }
    }
}
