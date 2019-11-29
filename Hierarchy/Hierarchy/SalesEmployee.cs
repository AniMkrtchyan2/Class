using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class SalesEmployee : RegularEmployee
    {
        private IList<Sale> sales;
        public IList<Sale> Sales
        {
            get=>this.sales; 
            set { this.sales = value; }
        }
        public SalesEmployee(uint id, string name, string lastname, int salary, Department department, IList<Sale> sales) 
            : base(id, name, lastname, salary, department)
        {
            this.Sales = sales;
        }
        public override string ToString()
        {
            string saleStr = string.Join("\n", this.sales);
            return "\nSaler -> " + base.ToString() + string.Format("\n{0} made sales:\n{1}", this.Name, saleStr);
        }
    }
}
