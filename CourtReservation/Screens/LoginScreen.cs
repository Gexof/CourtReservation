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
            bool isLogin = false;
            string username;
            string password;

            switch (UserChoice)
            {
                case "1":
                    Customer customerLog = new();
                    Console.Write("Username: ");
                    username = Console.ReadLine();
                    Console.Write("\nPassword: ");
                    password = Console.ReadLine();

                    while (!isLogin)
                    {
                        isLogin = customerLog.login(username, password);

                        if (!isLogin)
                        {
                            Console.Write("Username: ");
                            username = Console.ReadLine();
                            Console.Write("\nPassword: ");
                            password = Console.ReadLine();
                        }
                    }

                    DashbordCustomerScreen.DashbordCustomerView(username);
                    break;

                case "2":
                    Admin admin = new();
                    Console.Write("Username: ");
                    username = Console.ReadLine();
                    Console.Write("\nPassword: ");
                    password = Console.ReadLine();

                    while (!isLogin)
                    {
                        isLogin = admin.login(username, password);

                        if (!isLogin)
                        {
                            Console.Write("Username: ");
                            username = Console.ReadLine();
                            Console.Write("\nPassword: ");
                            password = Console.ReadLine();
                        }
                    }

                    DashbordAdminScreen.DashbordAdminView();
                    break;
                default:
                    Console.WriteLine("Wrong Option");
                    break;
            };
        }
    }
}
