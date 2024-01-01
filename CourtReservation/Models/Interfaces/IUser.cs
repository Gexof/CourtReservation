using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Models.Interfaces
{
    internal interface IUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        //public string UserType { get; }


        void PrintUserData();

    }
}
