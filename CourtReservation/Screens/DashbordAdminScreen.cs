using CourtReservation.Models;
using System;
using System.Collections.Generic;

namespace CourtReservation.Screens
{
    internal class DashbordAdminScreen
    {
        public static void DashbordAdminView()
        {
            User user = new();
            Admin admin = new();

            bool isLoggedIn = true;

            while (isLoggedIn)
            {
                Console.WriteLine("=================== Welcome To Court Reservation =================== \n");
                Console.WriteLine("[1] Show Courts");
                Console.WriteLine("[2] Add Courts");
                Console.WriteLine("[3] Update Court");
                Console.WriteLine("[4] Delete Courts");
                Console.WriteLine("[0] Logout");

                string UserChoice = Console.ReadLine();

                switch (UserChoice)
                {
                    case "1":
                        List<Court> courts = admin.ShowCourt();
                        foreach (var item in courts)
                        {
                            Console.WriteLine($"Court ID: {item.CourtId}");
                            Console.WriteLine($"Court Description: {item.Description} ");
                            Console.WriteLine($"Court Type: {item.Type}");
                            Console.WriteLine("________________________________________");
                        }
                        Console.WriteLine("Press Enter To Contunie...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine("Add a New Court id");
                        int Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter The Description");
                        string desc = Console.ReadLine();
                        Console.WriteLine("Enter the Court Type");
                        string type = Console.ReadLine();
                        admin.AddCourt(Id, desc, type);
                        Console.WriteLine("Operation Successful");
                        Console.WriteLine("Press Enter To Contunie...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.WriteLine("Add id for a court you want to Edit");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("What do you want to do ?");
                        Console.WriteLine("[1] Update The id ");
                        Console.WriteLine("[2] Update The Description ");
                        Console.WriteLine("[3] Update The Type ");
                        string choice = Console.ReadLine();
                        admin.UpdateCourt(id, choice);
                        Console.WriteLine("Press Enter To Contunie...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        Console.WriteLine("Add id for the court you want to remove");
                        int remid = int.Parse(Console.ReadLine());
                        admin.RemoveCourt(remid);
                        Console.WriteLine("Press Enter To Contunie...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "0":
                        isLoggedIn = false; // Log out
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
    }
}
