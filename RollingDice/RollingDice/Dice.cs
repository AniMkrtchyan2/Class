using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RollingDice
{
    class Dice
    {
           
            private readonly List<int> toss_values;

            public int Count
            {
                get; private set;
            }

            
            private readonly Random random;

            
            public Dice()
            {
                this.Count = 0;
                this.toss_values = new List<int>();
                this.random = new Random();
            }

            
            public delegate void DiceEventHandler<TEventArgs>(object sender, TEventArgs e);

            
            public event DiceEventHandler<DiceEventArgs> two_six_row;

            
            public event DiceEventHandler<DiceEventArgs> greater_than_or_equal_20;

            
            protected virtual void NewTwoSix(DiceEventArgs e)
            {
                if (this.two_six_row != null)
                {
                    this.two_six_row(this, e);
                }
            }

            
            protected virtual void NewGreaterThan20(DiceEventArgs e)
            {
                if (this.greater_than_or_equal_20 != null)
                {
                    this.greater_than_or_equal_20(this, e);
                }
            }

            
            public void SimulateNewTwoSix(string message)
            {
                DiceEventArgs e = new DiceEventArgs(message);
                this.NewTwoSix(e);
            }

            
            public void SimulateNewGreater(string message)
            {
                DiceEventArgs e = new DiceEventArgs(message);
                this.NewGreaterThan20(e);
            }

            
            public void RollN(int n)
            {
                int i = 0, sum = 0;

                //rolls die n times
                while (i != n)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Rolling a dice...");
                    Console.ResetColor();

                    //rolls a die every 2 seconds
                    Thread.Sleep(1000);

                    this.toss_values.Add(random.Next(1, 7));

                    Console.WriteLine((i + 1) + ".Dice toss value:" + this.toss_values[i]);

                    //calculate the sum of tosses values
                    sum += this.toss_values[i];

                    //if 6 is shown two times in a row
                    //raise TwoSixInaRow event 
                    if (this.toss_values.Count > 1 && this.toss_values[i] == 6 && this.toss_values[i - 1] == 6)
                    {
                        this.Count++;
                        this.SimulateNewTwoSix("\"Two sixes in a row\"");
                    }


                    //if there is more than 4 elements in toss values list
                    if (this.toss_values.Count > 4)
                    {
                        if (this.toss_values.Count != 5)
                        {
                            sum -= this.toss_values[i - 5];
                        }

                        //if in 5 consequent tosses the sum of number is gretaer than or equal to 20
                        //raise Greater than or equal to 20 event.
                        if (sum >= 20)
                        {
                            this.SimulateNewGreater("\"5 consequent tosses values is greater than or equal to 20\"");
                        }
                    }
                    ++i;
                    Console.WriteLine("Number of two sixes in a row: " + this.Count + Environment.NewLine);
                }
            }

        
    }
}
