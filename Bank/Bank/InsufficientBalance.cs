using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    //The exception class derives fromSystem.Exception
   public class InsufficientBalance :System.Exception
    {
        //It prints a message by calling theconstructor of this base class
        public InsufficientBalance(string msg, double amount) : base(msg)
        {
            // Additionally, it prints the balance.
            Console.WriteLine(" " + amount.ToString());
        }
    }
}
