using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Employee : Person, IEmployee
    {
        private int salary;
        private Department department;
        public Employee(uint id, string name, string lastname, int salary, Department department) 
            : base(id, name, lastname)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public int Salary
        {
            get => this.salary;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative!");
                }
                this.salary = value;
            }
        }
        public Department Department
        {
            get => this.department;
            set { this.department = value; }
        }
        public override string ToString()
        {
            return base.ToString() + string.Format(" Salary: {0}LV; Departamnet: {1}", this.salary, this.department);
        }
    }
}
