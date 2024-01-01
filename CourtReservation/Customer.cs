using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation
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
        public Customer(int id, string userName, int password, string reservedList) : base(id, userName, password, "Customer")
        {
            this.ReservedList = reservedList;
        }

        //Method
        public override void PrintUserData()
        {
            base.PrintUserData();
            Console.WriteLine("ReservedList is" + this.ReservedList);
        }
    }
}
