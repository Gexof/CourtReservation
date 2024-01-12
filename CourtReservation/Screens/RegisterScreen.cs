using CourtReservation.Models;
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
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=================== Register New Account =================== \n");
                Console.WriteLine("Please Select Account Type:");
                Console.WriteLine("[1] Customer");
                Console.WriteLine("[2] Admin");
                Console.WriteLine("[0] Back To Main Menu");

                string UserChoice = Console.ReadLine();
                User user = new();

                switch (UserChoice)
                {
                    case "1":
                        bool customernameExists = true;

                        while (customernameExists)
                        {
                            Console.Write("Enter 0 to exit or Customer Name: ");
                            string input = Console.ReadLine();

                            if (input == "0")
                            {
                                Console.WriteLine("Registration canceled. Press Enter to go back to the main menu.");
                                Console.ReadLine();
                                break;
                            }

                            string customername = input;

                            // Check if the customer name already exists
                            List<User> existingCustomer = user.LoadUsers();
                            bool customernameAlreadyExists = false;

                            foreach (User existingUser in existingCustomer)
                            {
                                if (existingUser.UserName == customername)
                                {
                                    customernameAlreadyExists = true;
                                    break;
                                }
                            }

                            if (customernameAlreadyExists)
                            {
                                Console.WriteLine("The Customer Name you Entered Is Already Exist. Please Choose Another Customer Name. Press Enter To Continue");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Write("\nPassword: ");
                                string CuPassword = Console.ReadLine();

                                int id = existingCustomer.Count + 1;
                                user.RegisterUser(id, customername, CuPassword, "customer");
                                Console.WriteLine("Registration Success. Press Enter To Continue");
                                Console.ReadLine();
                                customernameExists = false;
                            }
                        }

                        break;


                    case "2":
                        Console.Clear();
                        Console.Write("Enter 0 to exit or Admin Name:");
                        string AdminName = Console.ReadLine();

                        // Check if the admin name is "0" to exit
                        if (AdminName == "0")
                        {
                            Console.WriteLine("Registration canceled. Press Enter to go back to the main menu.");
                            Console.ReadLine();
                            break;
                        }

                        Console.Write("\nPassword: ");
                        string password = Console.ReadLine();

                        bool correctPin = false;
                        bool AdminNameExists = false;

                        List<User> existingUsers = user.LoadUsers();

                        // Check if the admin name already exists
                        foreach (User existingUser in existingUsers)
                        {
                            if (existingUser.UserName == AdminName)
                            {
                                AdminNameExists = true;
                                break;
                            }
                        }

                        while (!correctPin)
                        {
                            Console.Write("\nSystem Admin PIN (Enter 0 to go back to the main screen): ");
                            string pin = Console.ReadLine();

                            if (pin == "5555")
                            {
                                if (!AdminNameExists)
                                {
                                    int id = existingUsers.Count + 1;
                                    user.RegisterUser(id, AdminName, password, "admin");
                                    Console.WriteLine("Admin Registration Success. Press Enter To Continue");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Admin Name already exists. Please choose another Admin Name. Press Enter To Continue");
                                    Console.ReadLine();
                                }

                                correctPin = true; // Exit the loop when the PIN is correct
                            }
                            else if (pin == "0")
                            {
                                break; // Exit the loop and go back to the main screen
                            }
                            else
                            {
                                Console.WriteLine("Wrong Pin. Try again.");
                            }
                        }

                        break;

                    case "0":
                        return; // Exit the Register function and go back to the main menu

                    default:
                        Console.WriteLine("Wrong Option");
                        break;
                }
            }
        }

    }
}

