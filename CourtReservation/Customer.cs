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
        public Customer(int Id, string UserName, int Password, string ReservedList) : base(Id, UserName, Password)
        {
            this.ReservedList = ReservedList;
        }

        //Method
        public override void PrintUserData()
        {
            base.PrintUserData();
            Console.WriteLine("ReservedList is" + this.ReservedList);
        }
    }
}
