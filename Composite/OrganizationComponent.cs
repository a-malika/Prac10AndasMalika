using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10
{
    public abstract class OrganizationComponent
    {
        public abstract void Display(int depth);
        public virtual void AddComponent(OrganizationComponent component)
        {
            throw new NotImplementedException();
        }
        public abstract int GetBudget();
        public abstract int CountEmployees();
        public abstract void FindEmployee(string name);
    }
}
