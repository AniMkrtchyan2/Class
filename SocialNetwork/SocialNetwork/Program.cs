﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            User.PrintUsersNumber();
            User defaultUser=new User();
            User annaUser= new User();
            annaUser.UserName = "Anna;";
            annaUser.DateOfBirth = new DateTime(2000, 10, 11);
            annaUser.Gender = Gender.Female;
            annaUser.UserProfile.AddInterest(Intersets.Sport);
            annaUser.UserProfile.AddInterest(Intersets.Music);
            annaUser.PrintUserDetails();
            int numOfFriends=annaUser.UserProfile.NumberOfFriends();
            var userStr=annaUser.ToString();
            Console.WriteLine(userStr);
            Console.WriteLine(numOfFriends);
            Console.WriteLine(annaUser);

            User johnUser = new User()
            {
                UserName = "John",
                DateOfBirth=new DateTime(2000, 11, 12),
                Gender=Gender.Male,
            };
            User johnUser1 = new User()
            {
                UserName = "John",
                DateOfBirth = new DateTime(2000, 11, 12),
                Gender = Gender.Male
            };

            if (johnUser.Equals(johnUser1))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            if(johnUser1 == johnUser)
            {

            }
            User jackUser = new User("Jack", new DateTime(2000, 09, 05), Gender.Male);
            User user = new User("Jack", new DateTime(2000, 09, 05));

            User.PrintUsersNumber();
            Console.ReadLine();
            }

        static void PrintUserDetails(User user)
            {
          
            Console.WriteLine(user.UserName);
            Console.WriteLine(user.DateOfBirth);
            Console.WriteLine(user.Gender);
            Console.WriteLine();
            }

        }
    }

