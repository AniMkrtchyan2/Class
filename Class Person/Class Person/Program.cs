using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Person
{
    public class Person
    {
        private string name;
        private string username;
        private int age;
        private float weight;
        private string gender;

        public Person() { }
        public Person(string name, string username, int age, float weight, string gender)
        {
            this.name = name;
            this.username = username;
            this.age = age;
            this.weight = weight;
            this.gender = gender;
        }
        public void PrintName()
        {
            Console.WriteLine($"Name is {name}");
        }
        public void PrintUsername()
        {
            Console.WriteLine($"Username is {username}");
        }

        public void PrintAge()
        {
            Console.WriteLine($"Age is {age}");
        }

        public void PrintWeight()
        {
            Console.WriteLine($"Weight is {weight}");
        }

        public void PrintGender()
        {
            Console.WriteLine($"Gender is {gender}");
        }

        
        public void Person2name (string newname)

        { name = newname; }

        public void Person2username(string newusername)

        { username = newusername; }

        public void Person2age(int newage)

        { age = newage; }

        public void Person2weight(float newweight)

        { weight = newweight; }

        public void Person2gander  (string newgender)

        { gender = newgender;}

        class Program
        {
            static void Main(string[] args)
            {
                Person person1 = new Person("Monika", "Belucci", 55, 64, "female");
               
                person1.PrintName();
                person1.PrintUsername();
                person1.PrintAge();
                person1.PrintWeight();
                person1.PrintGender();

                // Console.Write(person1.PrintName() "  ");
                Console.Write("Person2 name is   ");
                person1.Person2name(Console.ReadLine());
                Console.Write("Person2 usernamenameis  ");
                person1.Person2username(Console.ReadLine());
                Console.Write("Person2 age is  ");
                person1.Person2age(int.Parse(Console.ReadLine()));
                Console.Write("Person2 weight is  ");
                person1.Person2weight(float.Parse(Console.ReadLine()));
                Console.Write("Person2 genderis  ");
                person1.Person2gander(Console.ReadLine());
                Console.ReadKey();
            }
        }

    }
}