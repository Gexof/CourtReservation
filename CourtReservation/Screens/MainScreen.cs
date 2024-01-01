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

            Console.WriteLine("[1] Login");
            Console.WriteLine("[2] Register");
            Console.WriteLine("[0] Exit");
            Console.Write("Enter your choice: ");




        }
    }
}
