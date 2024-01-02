using CourtReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Screens
{
    internal class LoginScreen
    {


        public static void LoginView() {
            Console.WriteLine("=================== Login =================== \n");
            Console.WriteLine("Please Select Account Type:");
            Console.WriteLine("[1] Customer");
            Console.WriteLine("[2] Admin");

            User user = new();

            string UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case "1":
                    Customer customer = new();
                    Console.Write("Username: ");
                    string username = Console.ReadLine();
                    Console.Write("\nPassowrd: ");
                    string password = Console.ReadLine();
                    customer.login(username,password);
                    break;
                case "2":
                    Admin admin = new();
                    Console.Clear();
                    Console.Write("Username: ");
                    username = Console.ReadLine();
                    Console.Write("\nPassowrd: ");
                    password = Console.ReadLine();
                    admin.login(username, password);
                    Console.Clear() ;
                    DashbordScreen.DashbordView();
                    admin.PrintUserData();
                    break;
                default:
                    Console.WriteLine("Wrong Option");
                    break;
            };
        }
    }
}
