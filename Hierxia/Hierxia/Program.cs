using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierxia
{
    public class Animals
   {
       public string Voice{get; set;}
       public int Age {get; set;}
       public bool Breathe{get;set; } 
       public int Move{get; set;}
       public Animals (string voice, int age, bool breathe,int move)
            {
            voice=Voice;
            age=Age;
            breathe=Breathe;
            move=Move;
            }

       public class Herbivore : Animals
       { public  Herbivore (string voice,int age): base("Herbivore", voice,age)
                {
                }
           public void Eat()
           {
               Console.WriteLine( "An animal that eats almost only plants ");
           }

       }
       public class Carnivore : Animals
       {
          public  Carnivore (string voice,int age): base("Carnivore", voice,age)
                {
                }
           public void Eat()
           {
               Console.WriteLine( "Thats eats almost only meat");
           }
       }

       public class Omnivore : Animals
       {
        public  Omnivore (string voice,int age): base("Omnivore", voice,age)
                {
                }

           public void Eat()
           {
               Console.WriteLine( "Thats eats plants and meat");
           }
       }

        class Rabbit : Herbivore
       {
        private string Name;
         public Rabbit(string voice, int age, string name):base(voice, age)
         { name=Name;
         }

           //public void Voice()
          // { Console.WriteLine( "Squeak squeak "); }

           public void Eat()
           {
               Console.WriteLine( "Rabbit like carrot");
           }
           public void BreatheRabbit ()
           {
               if (Breathe = true)
                   Console.WriteLine("It's alive");
               else
                   Console.WriteLine("It's a dead");
           }
           private void SetMove()
           {
               Move= 90;
           }
       }



       public class Lion : Carnivore
       {private string NameLion;
       public Lion (string voice, int age, string nameLion):base(voice, age)
         { nameLion=NameLion;
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
       { private string NameHyena;
       public Hyena(string voice, int age, string nameHyena):base(voice, age)
         { nameHyena=NameHyena;
         }
           public void weightHyena()
           { Console.WriteLine("It max weigt 64 kg"); }
       }
       public class Man : Omnivore
       { private string NameMan;
       public Man (string voice, int age, string nameMan):base(voice, age)
         { nameMan=NameMan;
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
               Rabbit NewRabbit = new Rabbit("Squeak squeak",10,"Napo");

               Console.Write("Me type is Herbivore");
               NewRabbit.Voice();
               NewRabbit.Age();
               NewRabbit.Name();

               Lion NewLion = new Lion("Roar Roar", 15, "King");
               Console.Write("Me type is Carnivore");
               NewLion.Voice();
                NewLion.Age();
                NewLion.NameLion();

                Hyena NewHyena=new Hyena("kay kay", 12, "Boreni");
                NewHyena.Voice();
                NewHyena.Age();
                NewHyena.NameHyena();
                 
               Man NewMan= new Man("speak", 150, "Arman");
                NewMan.Voice();
                NewMan.Age();
                NewMan.NameMan();

               Console.ReadKey();

}
            }
     }   }
    



