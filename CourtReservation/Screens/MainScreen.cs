using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Screens
{
    internal class MainScreen
    {
        public static void Weclome()
        {
            Console.Title = "Court Reservation";

            Console.WriteLine("=============================");
            Console.WriteLine("Welcome To Court Reservation");
            Console.WriteLine("============================= \n");

            Console.WriteLine("Please Select an Option Register or Login");
            Console.WriteLine("[1] Register");
            Console.WriteLine("[2] Login");
        }
    }
}
