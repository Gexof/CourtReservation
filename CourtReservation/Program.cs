﻿using CourtReservation.Models;
using CourtReservation.Screens;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace CourtReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Admin admin = new Admin();

            //admin.ShowCourt();
            //admin.AddCourt();


            //////Show all courts
            //admin.ShowCourt();
            //Console.ReadKey();

            /////////////

            // Add a new court with an integer CourtId
            //Console.WriteLine("Enter Court ID to add:");
            //if (int.TryParse(Console.ReadLine(), out int courtId))
            //{
            //    Console.WriteLine("Enter Court Description:");
            //    string description = Console.ReadLine();

            //    Console.WriteLine("Enter Court Type:");
            //    string type = Console.ReadLine();

            //    admin.AddCourt(courtId, description, type);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer Court ID.");
            //}

            ///////////////

            // Update a court by CourtId

            //Console.WriteLine("Enter the old Court ID to update:");
            //if (int.TryParse(Console.ReadLine(), out int oldId))
            //{
            //    Console.WriteLine("Enter the new Court ID:");
            //    if (int.TryParse(Console.ReadLine(), out int newId))
            //    {
            //        admin.UpdateCourt(oldId, newId);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input for new Court ID. Please enter a valid integer.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for old Court ID. Please enter a valid integer.");
            //}

            ////////////////

            // Remove a court by CourtId
            //Console.WriteLine("Enter Court ID to remove:");
            //if (int.TryParse(Console.ReadLine(), out int courtIdToRemove))
            //{
            //    admin.RemoveCourt(courtIdToRemove);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer Court ID.");
            //}






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


            Court court = new Court(5, "Sdv", "football");
            Customer customer = new Customer(3, "mohamed");

            Reservation reservation = new Reservation(
                 1,
                court: court,
                customer: customer,
                 new DateOnly(2024, 1, 7)
            );
            reservation.ReserveTime(new TimeSpan(10, 0, 0), new TimeSpan(12, 0, 0));
            //Customer customer = new Customer();
            customer.MakeReservation(reservation);
            customer.ViewReservations();
            UpdateScreen.UpdateScreenView();


            //Reservation reservation = new();
            //reservation. LoadReservationData();


        }


    }







    
}

