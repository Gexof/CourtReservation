﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Models
{
    internal class User
    {
        //Attribute
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; }


        public User()
<<<<<<< HEAD
        {
            // You can initialize default values if needed
        }


        //Parametarized Constructor
        public User(string userName, string password, string userType)
=======
>>>>>>> ca8bf0c0aa2539f1c9d15700230432eab529da94
        {

        }
        //Parametarized Constructor
        public User(int id,string userName, string password, string userType)
        {
            Id = id;
            UserName = userName;
            Password = password;
            UserType = userType;
        }

        public User(string userName, string password) : this( 0,userName, password, "") { }




        //Method
        public virtual void PrintUserData()
        {
            Console.WriteLine("Id is" + Id);
            Console.WriteLine("UserName is" + UserName);
            Console.WriteLine("Password is" + Password);
        }
    }
}






