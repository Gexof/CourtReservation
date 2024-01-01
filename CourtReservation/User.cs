using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation
{
    internal class User
    {
        //Attribute
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public string UserType { get;}


        //Default Constructor
        public User()
        {
            Id = 0;
            UserName = "";
            Password = 0;
            UserType = "";
        }

        //Parametarized Constructor
        public User(int id, string userName, int password,string userType)
        {
            this.Id = id;
            this.UserName = userName;
            this.Password = password;
            this.UserType = userType;

        }

        public User(string userName, int password) : this(100, userName, password,"") { }




        //Method
        public virtual void PrintUserData()
        {
            Console.WriteLine("Id is" + this.Id);
            Console.WriteLine("UserName is" + this.UserName);
            Console.WriteLine("Password is" + this.Password);
        }
    }
}






