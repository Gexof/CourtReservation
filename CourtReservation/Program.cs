using CourtReservation.Models;
using CourtReservation.Screens;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace CourtReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Admin admin = new Admin();

            ////Show all courts
            //admin.ShowCourt();
            //Console.ReadKey();

            ///////////

            // Add a new court with an integer CourtId
            Console.WriteLine("Enter Court ID to add:");
            if (int.TryParse(Console.ReadLine(), out int courtId))
            {
                Console.WriteLine("Enter Court Description:");
                string description = Console.ReadLine();

                Console.WriteLine("Enter Court Type:");
                string type = Console.ReadLine();

                admin.AddCourt(courtId, description, type);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer Court ID.");
            }

            ///////////////

            //// Assuming you have an instance of Admin class, you would call UpdateCourt like this:
            //int oldId = 101; // Replace this with the actual old court ID
            //int newId = 102; // Replace this with the new court ID
            //admin.UpdateCourt(oldId, newId);

            ////////////////
         

            //int courtIdToRemove = 5; // Replace 5 with the actual ID you want to remove
            //admin.RemoveCourt(courtIdToRemove);

            //Console.ReadKey();

            //bool exit = false;
            //while (!exit)
            //{
            //    Console.Clear();
            //    MainScreen.Weclome();
            //    string userChosie = Console.ReadLine();
            //    switch (userChosie)
            //    {
            //        case "1":
            //            LoginScreen.LoginView();
            //            break;
            //        case "2":
            //            RegisterScreen.Register();
            //            break;
            //        case "0":
            //            exit = true;
            //            break;
            //    }
            //}


        }
        
        
    }







    
}

