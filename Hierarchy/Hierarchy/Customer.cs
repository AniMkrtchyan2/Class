using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Customer : Person
    {
        private decimal purchaseAmount;

        public Customer(uint id, string name, string lastname, decimal purchaseAmount)
            : base(id, name, lastname)
        {
            this.PurchaseAmount = purchaseAmount;
        }
        public decimal PurchaseAmount
        {
            get=>this.purchaseAmount;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Net purchase amount cannot be negative!");
                }
                this.purchaseAmount = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Net purchase amount: {0}", this.purchaseAmount);
        }
    }
}
