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

        public Admin()
        {

        }
        public Admin(int id, string userName, string password): base(id, userName, password,"admin") { }



        public void AddCourt() { }
        public void RemoveCourt() { }
        public void UpdateCourt() { }
        public void ShowCourt() { }
        public void AcceptRes() { }

    }
}
