using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class User
    {
        private static int numbOfCreatedUsers;
        public string UserName { get; set; }
        private DateTime dateOfBirth;
        public DateTime DateOfBirth 
        {
        get{ return this.dateOfBirth;}
        set
           {
             if (value.Year<2010)
                {
                this.dateOfBirth=value;
                }
             else
                {
                this.dateOfBirth=DateTime.Now;
                }
             }
        }
        private Gender gender;
        public Profile UserProfile {get; set;} =new Profile ();
        
        public Gender Gender
        {
            get { return this.gender; }

            set {
                if (value ==Gender.Male || value ==Gender.Female)
                {
                    this.gender = value;
                }
                else
                {
                    gender = Gender.Unknown;
                }

            }
        }

        public User()
        {
            numbOfCreatedUsers++;
        }

        public User(string name, DateTime dateOfBrith, Gender gender=Gender.Unknown) :this ()
        {
            this.UserName = name;
            this.DateOfBirth = dateOfBrith;
            this.Gender = gender;
           
        }

       public void PrintUserDetails ()
            {
            Console.WriteLine(this.UserName);
            Console.WriteLine(this.DateOfBirth);
            Console.WriteLine(this.Gender);
            this.UserProfile.PrintInterests();

            Console.WriteLine();
            }
         public override string ToString()
        {
            return $"{this.UserName} {this.DateOfBirth}";
            //return base.ToString();
        }
         
         public override bool Equals(object obj)
        {
            User otherUser = (User)obj;
            return this.UserName == otherUser.UserName &&
                this.DateOfBirth == otherUser.dateOfBirth &&
                this.Gender == otherUser.Gender;

            //return base.Equals(obj);
        }
        public static void PrintUsersNumber ()
            {
            Console.WriteLine(numbOfCreatedUsers);
            }


    }
}
