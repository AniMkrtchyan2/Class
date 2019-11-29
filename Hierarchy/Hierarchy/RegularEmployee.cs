using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class RegularEmployee : Employee
    {
        public RegularEmployee(uint id, string name, string lastname, int salary, Department department)
            : base(id, name, lastname, salary, department)
        {
        }
    }
}
