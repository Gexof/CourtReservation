using CourtReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Screens
{
    internal class DashbordCustomerScreen
    {
        public static void DashbordCustomerView()
        {

            User user = new();
            Admin adimn = new();


            Console.WriteLine("=================== Welcome To Court Reservation =================== \n");
            Console.WriteLine("[1] Reserve Court");

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
