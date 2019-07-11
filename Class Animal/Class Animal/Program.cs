using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Animal
{
    public class Animals
    {
        public string Voice { get; set; }
        public int Age { get; set; }
        public bool Breathe { get; set; }
        public int Move { get; set; }
        public Animals(string voice, int age, bool breathe, int move)
        {
            voice = Voice;
            age = Age;
            breathe = Breathe;
            move = Move;
        }
    }
    public class Herbivore : Animals
    {
        public Herbivore(string voice, int age, bool breathe, int move) : base(voice, age, breathe, move)
        {

        }
        public void Eat()
        {
            Console.WriteLine("An animal that eats almost only plants ");
        }

    }
    public class Carnivore : Animals
    {
        public Carnivore(string voice, int age, bool breathe, int move) : base(voice, age, breathe, move)
        {
        }
        public void Eat()
        {
            Console.WriteLine("Thats eats almost only meat");
        }
    }

    public class Omnivore : Animals
    {
        public Omnivore(string voice, int age, bool breathe, int move) : base(voice, age, breathe, move)
        {
        }

        public void Eat()
        {
            Console.WriteLine("Thats eats plants and meat");
        }
    }

    class Rabbit : Herbivore
    {
        private string Name { get; set; }
        public Rabbit(string name, string voice, int age, bool breathe, int move) : base(voice, age, breathe, move)
        {
            Name = name;
        }

        //public void Voice()
        // { Console.WriteLine( "Squeak squeak "); }

        public void Eat()
        {
            Console.WriteLine("Rabbit like carrot");
        }
        public void BreatheRabbit()
        {
            if (Breathe = true)
                Console.WriteLine("It's alive");
            else
                Console.WriteLine("It's a dead");
        }
        private void SetMove()
        {
            Move = 90;
        }
    }



    public class Lion : Carnivore
    {
        private string NameLion { get; set; }
        public Lion(string nameLion, string voice, int age, bool breathe, int move) : base(voice, age, breathe, move)
        {
            NameLion = nameLion;
        }
        // public void Voice()
        //   { Console.WriteLine("Roar Roar"); }
        public void EatLion()
        {
            Console.WriteLine("A single lion kills about 15 large animals each year"
               + "And, of course, they're perfectly happy to eat human beings as well");
        }
        public void BodyLion()
        {
            Console.WriteLine("it is a muscular, deep-chested cat with a short,"
               + " rounded head, a reduced neck and round ears, and a hairy tuft at the end of its tail");
        }
        public void MoveLion()
        { Console.WriteLine("It Max speed  80 km/h"); }
    }


    public class Hyena : Carnivore
    {
        private string NameHyena;
        public Hyena(string nameHyena, string voice, int age, bool breathe, int move) : base(voice, age, breathe, move)
        {
            NameHyena = nameHyena;
        }
        public void WeightHyena()
        { Console.WriteLine("It max weigt 64 kg"); }
    }
    public class Man : Omnivore
    {
        private string NameMan;
        public Man(string nameMan, string voice, int age, bool breathe, int move) : base(voice, age, breathe, move)
        {
            NameMan = nameMan;
        }

        public void IntelligenceMan()
        { Console.WriteLine("Man is the most intelligent of the animals"); }
        public void GenderMan()
        { Console.WriteLine("A man is a male human"); }

    }


    class program
    {
        static void Main(string[] args)
        {
            Rabbit NewRabbit = new Rabbit("Napo", "Squeak squeak", 10, true, 60);
            Console.Write("Me type is Herbivore");
            NewRabbit.Eat();
            NewRabbit.BreatheRabbit();



            Lion NewLion = new Lion("King","Roar Roar", 15, true, 80);
            Console.Write("Me type is Carnivore");
            NewLion.EatLion();
            NewLion.BodyLion();
            NewLion.MoveLion();

            Hyena NewHyena = new Hyena("Boreni","kay kay", 12, true, 70);
            NewHyena.WeightHyena();
            

            Man NewMan = new Man("Arman", "speak", 150, true, 10);
            NewMan.IntelligenceMan();
            NewMan.GenderMan();
            Console.ReadKey();

        }
    }
}

