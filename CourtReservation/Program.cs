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
            bool exit = false;
            while (!exit)
            {
                Admin admin = new Admin();

                admin.AddCourt(1);

                admin.ShowCourt();

                admin.AcceptRes();

                // Assuming you have an instance of Admin class, you would call UpdateCourt like this:
                int oldId = 1; // Replace this with the actual old court ID
                int newId = 2; // Replace this with the new court ID
                admin.UpdateCourt(oldId, newId);

                int courtIdToRemove = 5; // Replace 5 with the actual ID you want to remove
                admin.RemoveCourt(courtIdToRemove);

                Console.ReadKey();

                Console.Clear();
                MainScreen.Weclome();
                string userChosie = Console.ReadLine();
                switch (userChosie)
                {
                    case "1":
                        LoginScreen.LoginView();
                        break;
                    case "2":
                        RegisterScreen.Register();
                        break;
                    case "0":
                        exit = true;
                        break;
                }
            }
        }







    }
    }

