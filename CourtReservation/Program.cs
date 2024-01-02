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



            //AuthService authService = new AuthService();
            //authService.LoadUsers();







        }
    }
}
