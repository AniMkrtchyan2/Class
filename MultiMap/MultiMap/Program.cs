using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiMap
{
    class Program
    {
        static void Main()
        {
            var mm =new Dictionary<int, string>();

            mm.Add(1, "America");
            mm.Add(2, "Europa");
            mm.Add(3, "Asia");
            mm.Add(4, "Africa");
            Console.WriteLine();
            foreach (KeyValuePair<int, string> kvp in mm)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }

            // To get the values alone, use the Values property.
            ICollection<string> icoll = mm.Values;

            foreach (string s in icoll)
            {
                Console.WriteLine("Value = {0}", s);
            }

            icoll =mm.Values;
            Console.WriteLine();
            foreach (string s in icoll)
            {
                Console.WriteLine("Key = {0}", s);
            }

            // Use the Remove method to remove a key/value pair.
            Console.WriteLine("\nRemove(\"1\")");
            mm.Remove(1);

            if (!mm.ContainsKey(1))
            {
                Console.WriteLine("Key \"1\" is not found.");
            }
        }
    }
}
