using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Screens
{
    internal class RegisterScreen
    {
        public static void Register()
        {
            Console.WriteLine("=================== Register New Account =================== \n");
            Console.WriteLine("Please Select Account Type:");
            Console.WriteLine("[1] Customer");
            Console.WriteLine("[2] Admin");
            string UserChoice = Console.ReadLine();


            switch (UserChoice)
            {
                case "1":
                    Console.Write("Username: ");
                    string username = Console.ReadLine();
                    Console.Write("\nPassowrd: ");
                    string password = Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    Console.Write("Username: ");
                    username = Console.ReadLine();
                    Console.Write("\nPassowrd: ");
                    password = Console.ReadLine();
                    Console.Write("\nSystem Admin PIN: ");
                    string pin = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Wrong Option");
                    break;
            }
        }
    }
}
