using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Models
{
    internal class Reservation()
    {


        int resrvationid { set; get; }
        dateOnly date { set; get; }

        public void show_reservation_details()
        {
            Console.WriteLine(resrvationid);
            Console.WriteLine(username);
            Console.WriteLine(courttype);
            Console.WriteLine(date);
        }
        public void cancel_reservation()
        {

        }
        public Reservation(int resrvationid, string username, string courttype, dateOnly date)
            : base(username, type)
        {
            this.resrvationid = resrvationid;
            this.date = date;
        }





    }


}
