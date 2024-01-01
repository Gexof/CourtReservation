using CourtReservation.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Models
{
    internal class Admin : IUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }

        public Admin(int id, string userName, int password)
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
