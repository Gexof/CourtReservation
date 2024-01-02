using CourtReservation.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Models
{
    internal class Admin : User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Admin()
        {

        }
        public Admin(int id, string userName, string password)
        {
            this.Id = id;
            this.UserName = userName;
            this.Password = password;
        }

        public void PrintUserData()
        {
         
        }
    }
}
