using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankAccount
    {

        protected double InterestRate;
        protected double Balance;
        protected string Owner;

        /// <summary>
        /// Revisiting the BankAccount Class
        /// </summary>
        /// <param name="o"></param>
        /// <param name="b"></param>
        /// <param name="ir"></param>
        public BankAccount(string o, double b, double ir)
        {
            this.InterestRate = ir;
            this.Balance = b;
            this.Owner = o;
        }

        public BankAccount(string o, double ir):this(o, 0.0, ir)
        {

        }
        /// <summary>
        /// The Deposit method is augment it is the Balance
        /// </summary>
        /// <param name="amount"></param>
        public void Deposit(double amount)
        {
           this.Balance += amount;
        }
        /// <summary>
        /// The Withdraw method is reduce it from Balance
        /// </summary>
        /// <param name="amount"></param>
        public virtual void Withdraw(double amount)
        {
            if (this.Balance >= amount)
            {
                this.Balance -= amount;
            }
            else
            {
                throw new InsufficientBalance("Balance too low:{0}", this.Balance);
            }
        }

        /// <summary>
        /// This method calculates the interstrate of money 
        /// </summary>
        /// <param name="interestrate"></param>
        public virtual void AddInterest(double interestrate)
        {
            if (interestrate >= 0.0 && interestrate <= 22.0)
            {
                Balance += Balance * interestrate;
            }
            else
                throw new InvalidInterstRateException("InterestRate it can be between 0.0 and 22.0", this.InterestRate);
        }

        public double GetBalance() => this.Balance;

        public virtual void ShowBankAccount()
        {
            Console.WriteLine("Account Number: {0}\tCurrentBalance: { 1} ",  this.Owner, this.Balance.ToString());
        }


    }
}
