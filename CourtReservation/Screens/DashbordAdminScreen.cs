using CourtReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Screens
{
    internal class DashbordAdminScreen
    {
        public static void DashbordAdminView()
        {

            User user= new();
            Admin adimn= new();


            Console.WriteLine("=================== Welcome To Court Reservation =================== \n");
            Console.WriteLine("[1] Load Users");

            string UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case "1":
                    user.LoadUsers();
                    Console.ReadKey();
                    break;
            }
        }
    }
}
