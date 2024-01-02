using CourtReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Screens
{
    internal class DashbordScreen
    {
        public static void DashbordView()
        {

            AuthService authService = new();


            Console.WriteLine("=================== Welcome To Court Reservation =================== \n");
            Console.WriteLine("[1] Load Users");

            string UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case "1":
                    authService.LoadUsers();
                    Console.ReadKey();
                    break;

            }
        }
    }
}
