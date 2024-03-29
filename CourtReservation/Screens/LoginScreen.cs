﻿using CourtReservation.Models;
using System;

namespace CourtReservation.Screens
{
    internal class LoginScreen
    {
        public static void LoginView()
        {
            Console.Clear();
            Console.WriteLine("=================== Login =================== \n");
            Console.WriteLine("Please Select Account Type:");
            Console.WriteLine("[1] Customer");
            Console.WriteLine("[2] Admin");
            Console.WriteLine("[0] Back");

            User user = new();

            string UserChoice;
            bool isLogin = false;
            string username;
            string password;

            while (!isLogin)
            {
                UserChoice = Console.ReadLine();

                switch (UserChoice)
                {
                    case "1":
                        Customer customerLog = new();
                        Console.Write("Username: ");
                        username = Console.ReadLine();
                        Console.Write("Password: ");
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
                        Console.Clear();
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
                        Console.Clear();
                        DashbordAdminScreen.DashbordAdminView();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Wrong Option");
                        break;
                }
            }

        }
    }
}
