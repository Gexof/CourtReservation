using CourtReservation.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Models
{
    internal class Customer : IUser
    {
        //Attribute
        public string ReservedList { get; set; }
        public int Id { get; set; }
        public string UserName { get ; set; }
        public int Password { get; set; }

        //Default Constructor
        public Customer()
        {
            ReservedList = string.Empty;
        }

        //Parametarized Constructor
        public Customer(int id, string userName, int password, string reservedList)
        {
            this.Id = id;
            this.UserName = userName;
            this.Password = password;
            this.ReservedList = reservedList;
        }

        //Method
        public void PrintUserData()
        {
            
        }


    }
}
