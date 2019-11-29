using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Manager : Employee, IManager
    {
        public Manager(uint id, string name, string lastname, int salary, Department department,IList<RegularEmployee> employees) 
            : base(id, name, lastname, salary, department)
        {
            this.Employees = employees;
        }
        private IList<RegularEmployee> employees;
        public IList<RegularEmployee> Employees
        {
            get => this.employees;
            set { this.employees=value; }
        }
        public override string ToString()
        {
            string employeesStr = string.Join("\n", this.employees);
            return "Manager -> " + base.ToString() + string.Format("\nEmployees under command:\n{0}\n", employeesStr);
        }
    }
}
