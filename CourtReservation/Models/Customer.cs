using CourtReservation.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Models
{
    internal class Customer : User
    {
        //Attribute
        public string ReservedList { get; set; }

        //Default Constructor
        public Customer()
        {
            ReservedList = string.Empty;
        }

        //Parametarized Constructor
        public Customer(int id, string userName, string password, string reservedList) :base (id,userName, password, "Customer") { }

        
        public void ShowReserved() { }

        public void Reservation() { }


    }
}
