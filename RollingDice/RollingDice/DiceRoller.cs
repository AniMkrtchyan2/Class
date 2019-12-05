using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollingDice
{
    class DiceRoller
    {
        private void TwoSix(object sender, DiceEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Triggered " + e.Message + " event");
            Console.ResetColor();
        }

        private void GreaterOrEq20(object sender, DiceEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Triggered " + e.Message + "event");
            Console.ResetColor();
        }

        public void Run(int n)
        {
            Dice dice = new Dice();

            //register TwoSix event handler to two_six_row event
            dice.two_six_row += this.TwoSix;

            //register GreaterOrEq20 event handler to greater than or equal to 20 event
            dice.greater_than_or_equal_20 += this.GreaterOrEq20;
            dice.RollN(n);
            Console.Read();
        }
    }
}
