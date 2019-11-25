using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Airpot
{
    class Program
    {
        static void Main(string[] args)
        {
            AirportComparer<Airport> cp = new AirportComparer<Airport>();
            List<Airport> airports = new List<Airport>();
            airports.Add(new Airport("Singapore Changi", "Singapore", Size.SuperMega));
            airports.Add(new Airport("Zvartnots", "Armenia", Size.Medium));
            airports.Add(new Airport("Tokyo Haneda", "Japan", Size.Mega));
            airports.Add(new Airport("Erebuni", "Armenia", Size.Small));
            airports.Add(new Airport("Zurich", "Switzerland", Size.Large));
            
            

            Console.WriteLine("The World’s Airports \n");
            Console.WindowWidth = 100;
            foreach (Airport a in airports)
                Console.WriteLine(a);

            Console.WriteLine("\n The sort Airport\n");
            airports.Sort(cp);
            foreach (Airport a in airports)
                Console.WriteLine(a);

            Console.ReadLine();
        }
    }

}
