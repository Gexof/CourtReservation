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
            Console.WriteLine("[1] Show Courts");
            Console.WriteLine("[2] Add Courts");
            Console.WriteLine("[3] Update Court");
            Console.WriteLine("[4] Delete Courts");

            string UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case "1":
                    List<Court> courts = adimn.ShowCourt();
                    foreach (var item in courts)
                    {
                        Console.WriteLine(item.CourtId);
                        Console.WriteLine(item.Description);
                        Console.WriteLine(item.Type);
                        Console.WriteLine("**********************");
                    }
                    Console.ReadKey();
                    break;

                    case "2":
                    Console.WriteLine("Add a New Court id");
                    int Id= int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter The Description");
                    string desc = Console.ReadLine();
                    Console.WriteLine("Enter the Court Type");
                    string type= Console.ReadLine();
                    adimn.AddCourt(Id, desc, type);
                    Console.ReadKey();
                    break;

                    case"3":
                    Console.WriteLine("Add id for a court you want to Edit");
                    int id= int.Parse(Console.ReadLine());
                    Console.WriteLine("What do you wnat to do ?");
                    Console.WriteLine("[1] Update The id ");
                    Console.WriteLine("[2] Update The Description ");
                    Console.WriteLine("[3] Update The Type ");
                    string choice= Console.ReadLine();
                    adimn.UpdateCourt(id, choice);
                    Console.ReadKey();
                    break;

                    case "4":
                    Console.WriteLine("Add id for the court you want to remove");
                    int remid= int.Parse(Console.ReadLine());
                    adimn.RemoveCourt(remid);
                    Console.ReadKey();
                    break;
            }
        }
    }
}
