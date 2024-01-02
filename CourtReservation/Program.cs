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
                Console.Clear();
                MainScreen.Weclome();
                string userChosie = Console.ReadLine();
                switch (userChosie)
                {
                    case "1":
                        Console.WriteLine("Login Screen");
                        break;
                    case "2":
                        RegisterScreen.Register();
                        break;
                    case "0":
                        exit = true;
                        break;
                }
            }



<<<<<<< HEAD
            //AuthService authService = new AuthService();
            //authService.LoadUsers();





=======
            //User user = new();
            //User.login("Ali", "sdjfoavan");
>>>>>>> f496f77a3a7ba3244d719b21e5a6f5d40389c70a

            //authService.LoadUsers();
            //authService.login("Ali", "sdjfoavan");

        }
        //authService.RegisterUser(4, "Salem", "sdjfoavan", "Customer");
        //authService.LoadUsers();








    }
    }

