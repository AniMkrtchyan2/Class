using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Animal
{
    public class MyClass
    {
        public static string type;
        public string Name { get; set; }
        public string feature;

        static MyClass()
        {
            type = "Animal";
            Console.WriteLine(type);
        }
        public MyClass(string Name)
        {
            this.Name = Name;
        }

        public MyClass(string Name, string feature) : this(Name)
        {
            this.feature = feature;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass1 = new MyClass("Fish", "  Water Animal");
            Console.Write(myclass1.Name);
            Console.WriteLine(myclass1.feature);

            MyClass myclass2 = new MyClass("Panda", "  Land Animal");
            Console.Write(myclass2.Name);
            Console.WriteLine(myclass2.feature);
        }
    }
}

