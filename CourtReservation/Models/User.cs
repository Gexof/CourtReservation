using System;
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
        public int Password { get; set; }
        public string UserType { get; }


        //Default Constructor
        public User()
        {

        }


        //Parametarized Constructor
        public User(string userName, int password, string userType)
        {

            UserName = userName;
            Password = password;
            UserType = userType;

        }

        public User(string userName, int password) : this( userName, password, "") { }




        //Method
        public virtual void PrintUserData()
        {
            //Console.WriteLine("Id is" + Id);
            Console.WriteLine("UserName is" + UserName);
            Console.WriteLine("Password is" + Password);
        }
    }
}






