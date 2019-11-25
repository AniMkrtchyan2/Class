using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airpot
{
    class Airport
    {
        public Airport(string name, string countryCode, Size sizeOfTheAirport)
        {
            Name = name;
            CountryCode = countryCode;
            SizeOfTheAirport = sizeOfTheAirport;
        }
        public Airport(Size sizeOfTheAirport)
        {
            SizeOfTheAirport = sizeOfTheAirport;
        }

        public Airport()
        {
        }

        public string Name { get; set; }
        public string CountryCode { get; set; }
        public Size SizeOfTheAirport { get; set; }
        public override string ToString()
        {
            return String.Format(" {0}\t---  {1}\t", this.Name, this.CountryCode);
        }
    }
   internal class AirportComparer<T> : IComparer<T>
        where T:Airport
    {
        public int Compare(T x, T y) 
        {
            if (x.SizeOfTheAirport > y.SizeOfTheAirport)
            {
                return -1;
            }
            if (x.SizeOfTheAirport < y.SizeOfTheAirport)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}

