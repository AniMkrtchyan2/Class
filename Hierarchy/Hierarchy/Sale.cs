using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Sale
    {
        private string productName;
        private DateTime date;
        private decimal price;
        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("The product name cannot be empty");
                }
                if ( !char.IsUpper(value, 0))
                {
                    throw new FormatException("The product name start with capital letter!");
                }
                this.productName = value;
            }
        }

        public DateTime Date
        {
            get=> this.date; 
            set { this.date = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price of product cannot be negative!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Product: {0}; Date of sale: {1}; Price: {2}LV", this.productName, this.date.ToString("d"), this.price);
        }
    }
}
