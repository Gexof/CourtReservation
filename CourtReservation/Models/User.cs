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
        //public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; }


        //Parametarized Constructor
        public User(string userName, string password, string userType)
        {
            UserName = userName;
            Password = password;
            UserType = userType;

        }

        public User(string userName, string password) : this(userName, password, "") { }




        //Method
        public virtual void PrintUserData()
        {
            Console.WriteLine("UserName is" + UserName);
            Console.WriteLine("Password is" + Password);
        }


    }
}






