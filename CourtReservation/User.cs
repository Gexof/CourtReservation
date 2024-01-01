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


        //Default Constructor
        public User()
        {
            Id = 0;
            UserName = "";
            Password = 0;
        }

        //Parametarized Constructor
        public User(int Id, string UserName, int Password)
        {
            this.Id = Id;
            this.UserName = UserName;
            this.Password = Password;

        }

        public User(string UserName, int Password) : this(100, UserName, Password) { }


        //Method
        public virtual void PrintUserData()
        {
            Console.WriteLine("Id is" + this.Id);
            Console.WriteLine("UserName is" + this.UserName);
            Console.WriteLine("Password is" + this.Password);


        }
    }
}
