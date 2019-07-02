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
        private int weight;
        private string gender;

        //public Person(string name)
        //{
        //    this.name = name;
        //    Console.Write(" " + name + "  ");
        //}
        //public Person(string name, string username) : this(name)
        //{
        //    this.username = username;
        //    Console.WriteLine(username);
        //}
        //public Person(int age)
        //{
        //    this.age = age;
        //    Console.Write("age-" + age + "  ");
        //}
        //public Person(int age, int weight) : this(age)
        //{
        //    this.weight = weight;
        //    Console.WriteLine("weight-" + weight);
        //}
        //public Person(int age, int weight, string gender) : this(age: age, weight: weight)
        //{
        //    this.gender = gender;
        //    Console.WriteLine("   " + gender);
        //}
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           // Person Myperson = new Person("Monika", "Belucci");
           // Person Myperson1 = new Person(55, 64, "female");
            Person person1 = new Person();
            person1.Name = "Zinedine";
            person1.Username = "Zidane";
            person1.Age = 47;
            person1.Weight = 80;
            person1.Gender = "Male";
            Console.Write(person1.Name + "  ");
            Console.WriteLine(person1.Username);
            Console.Write("age-" + person1.Age);
            Console.WriteLine("  Weight-" + person1.Weight + "kg");
            Console.WriteLine("  " + person1.Gender);
        }
    }
}
