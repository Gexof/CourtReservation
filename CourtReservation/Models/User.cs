﻿using CourtReservation.Screens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Models
{
    internal class User 
    {

        private const string FileName = "C:\\Users\\Mohamed Ashraf\\source\\repos\\CourtReservation\\CourtReservation\\Data\\Users.json";

       
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }


        public User()

        {
            
        }


        //Parametarized Constructor
        public User(string userName, string password, string userType)

        {

        }
        public User(int id,string userName, string password, string userType)
        {
            Id = id;
            UserName = userName;
            Password = password;
            UserType = userType;
        }

        public User(string userName, string password) : this( 0,userName, password, "") { }


        public List<User> LoadUsers()
        {
            if (File.Exists(FileName))
            {
                string jsonText = File.ReadAllText(FileName);
                List<User> loadedUsers = JsonConvert.DeserializeObject<List<User>>(jsonText);
                return loadedUsers;
            }
            Console.WriteLine("No user data found.");
            return new List<User>();
        }


        public void RegisterUser(int id,string username, string password, string type)
        {
            List<User> users = LoadUsers(); 
            User newuser = new(id,username, password, type);
            users.Add(newuser); 
            string updateJson = JsonConvert.SerializeObject(users, Formatting.Indented); 
            File.WriteAllText(FileName, updateJson); 
        }


        public bool login(string userName, string password)
        {
            List<User> users = LoadUsers();

            //for (int attempt = 0; attempt < 3; attempt++)
            //{

            //    foreach (var user in users)
            //    {
            //        if (user.UserName == userName && user.Password == password) return true;
            //        else continue;
            //    }
            //    Console.WriteLine("Sorry, Try again");
            //}

            foreach (var user in users)
            {
                if (user.UserName == userName && user.Password == password) return true;
                else continue;
            }
            Console.WriteLine("Sorry, Try again.. Press Enter To Continue");
            Console.ReadKey();
            return false;
        }



    }
}






