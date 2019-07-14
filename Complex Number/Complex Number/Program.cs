using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex val1 = new Complex(7, 1);
            Complex val2 = new Complex(2, 6);
            // Add both of them
            Complex res = val1 + val2;
            Console.WriteLine("First:  {0}", val1);
            Console.WriteLine("Second: {0}", val2);
            // display the result
            Console.WriteLine("Result (Sum): {0}", res);

            Complex Sub = val1 - val2;
            Console.WriteLine("Result (Sub): {0}", Sub);
            Complex Multy = val1 * val2;
            Console.WriteLine("Result (Multy): {0}", Multy);
            Complex Devide = val1 / val2;
            Console.WriteLine("Result (Devide): {0}", Devide);
            Console.ReadLine();
        }
    }
    }

