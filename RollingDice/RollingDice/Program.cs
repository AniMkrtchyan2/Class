using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RollingDice;

namespace RollingDice
{
    class Program
    {

        static void Main(string[] args)
        {
            DiceRoller dr = new DiceRoller();
            dr.Run(20);
        }
    }
}
