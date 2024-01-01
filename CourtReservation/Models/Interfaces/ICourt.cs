using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Models.Interfaces
{
    internal interface ICourt
    {
        public int CourtId { get; set; }

        public string Descreption { get; set; }

        public string Type { get; set; }

        public abstract string ShowCollection(string collection);
    }
}
