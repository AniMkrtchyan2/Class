using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

           BankAccount account = new BankAccount("Mayql", 1230.70, 19.2);
           Console.WriteLine(account.ToString());

            // Test that the initial balances must be positive
            try
            {
                var invalidAccount = new BankAccount("invalid", -10);
            }
            catch (InsufficientBalance e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }

          //test that the interstrate must be between 0.0-22.0
            try
            {
                account.AddInterest(36.8);
            }
            catch (InvalidInterstRateException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            Console.ReadKey();

        }
    }
}
