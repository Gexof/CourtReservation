using CourtReservation.Models;
using System;
using System.Collections.Generic;

namespace CourtReservation.Screens
{
    internal class DashbordCustomerScreen
    {
        public static void DashbordCustomerView(string username)
        {
            User user = new();
            Admin admin = new();

            bool isLoggedIn = true;

            while (isLoggedIn)
            {
                Console.WriteLine("=================== Welcome To Court Reservation =================== \n");
                Console.WriteLine("[1] Reserve Court");
                Console.WriteLine("[2] Show Reservations");
                Console.WriteLine("[0] Logout");

                string UserChoice = Console.ReadLine();

                switch (UserChoice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("[1] Football Court");
                        Console.WriteLine("[2] Paddel");
                        Console.WriteLine("[0] Back");
                        string CourtType = Console.ReadLine();
                        switch (CourtType)
                        {
                            case "1":
                                Console.Clear();
                                ReserveFootball(username);
                                break;
                            case "2":
                                Console.Clear();
                                ReservePaddel(username);
                                break;
                            case "0":
                                return;
                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        showRes(username);
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

        static void showRes(string username)
        {
            Reservation res = new Reservation();
            List<Reservation> Reslist = res.LoadReservationData();
            foreach (var item in Reslist)
            {
                if (item.customer.UserName == username)
                {
                    Console.WriteLine($"Reservation ID: {item.ResrvationId}");
                    Console.WriteLine($"Court: Court ID: {item.court.CourtId}");
                    Console.WriteLine($"Court Description: {item.court.Description}");
                    Console.WriteLine($"Court Type: {item.court.Type}");
                    Console.WriteLine($"Customer: {item.customer.UserName}");
                    Console.WriteLine($"Date: {item.Date}");
                    Console.WriteLine($"Reserved Time Slots: {item.StartTime} - {item.EndTime}");
                    Console.WriteLine("*****************************");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Press Enter To Contunie...");
            Console.ReadKey();
            Console.Clear();
        }

        static void ReserveFootball(string username)
        {
            Admin admin = new Admin();
            List<Court> Courtlist = admin.ShowCourt();

            bool FootballCourtAvailable = false;

            foreach (var item in Courtlist)
            {
                if (item.Type == "Football")
                {
                    Console.WriteLine(item.CourtId);
                    Console.WriteLine(item.Description);
                    Console.WriteLine(item.Type);
                    Console.WriteLine("*****************************");
                    FootballCourtAvailable = true;
                }
            }

            if (!FootballCourtAvailable)
            {
                Console.WriteLine("No Football court available.");
            }

            Console.WriteLine("Add a Court ID ");
            int id = int.Parse(Console.ReadLine());
            Court court0 = new Court();
            foreach (var item in Courtlist)
            {
                if (item.CourtId == id)
                {
                    court0 = new Court(item.CourtId, item.Description, item.Type);
                }
            }
            Customer customer = new Customer();
            User user = new User();
            List<User> users = user.LoadUsers();
            foreach (var usser in users)
            {
                if (usser.UserName == username)
                {
                    customer = new Customer(usser.Id, usser.UserName);
                }
            }
            Console.WriteLine("Add Date as Following Year/Month/Day ");
            DateOnly date = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Add start Time as Following 10:00");

            TimeSpan startTime = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("Add End Time as Following 12:00");
            TimeSpan EndTime = TimeSpan.Parse(Console.ReadLine());

            Reservation r = new();
            List<Reservation> ReservationsList = r.LoadReservationData();

            r = ReservationsList.Find(Reservation => Reservation.StartTime == startTime && Reservation.EndTime == EndTime && Reservation.Date == date && Reservation.court.CourtId == id);

            if (r != null)
            {
                Console.WriteLine("The Time is not Available");
            }
            else
            {
                Reservation NewRes = new Reservation(court0, customer, startTime, EndTime, date);
                customer.MakeReservation(NewRes);
                Console.WriteLine("Reservation successful! Press Enter To Contunie ....");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void ReservePaddel(string username)
        {
            Admin admin = new Admin();
            Court court = new Court();
            List<Court> Courtlist = admin.ShowCourt();

            bool PaddelCourtAvailable = false;

            foreach (var item in Courtlist)
            {
                if (item.Type == "Paddel")
                {
                    Console.WriteLine(item.CourtId);
                    Console.WriteLine(item.Description);
                    Console.WriteLine(item.Type);
                    Console.WriteLine("*****************************");
                    PaddelCourtAvailable = true;
                }
            }

            if (!PaddelCourtAvailable)
            {
                Console.WriteLine("No Paddel court available.");
            }
            Console.WriteLine("Add a Court ID ");
            int id = int.Parse(Console.ReadLine());
            Court court0 = new Court();
            foreach (var item in Courtlist)
            {
                if (item.CourtId == id)
                {
                    court0 = new Court(item.CourtId, item.Description, item.Type);
                }
            }
            Customer customer = new Customer();
            User user = new User();
            List<User> users = user.LoadUsers();
            foreach (var usser in users)
            {
                if (usser.UserName == username)
                {
                    customer = new Customer(usser.Id, usser.UserName);
                }
            }
            Console.WriteLine("Add Date");
            DateOnly date = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Add start Time");

            TimeSpan startTime = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("Add End Time");
            TimeSpan EndTime = TimeSpan.Parse(Console.ReadLine());

            Reservation r = new();
            List<Reservation> ReservationsList = r.LoadReservationData();

            r = ReservationsList.Find(Reservation => Reservation.StartTime == startTime && Reservation.EndTime == EndTime && Reservation.Date == date && Reservation.court.CourtId == id);

            if (r != null)
            {
                Console.WriteLine("The Time is not Available");
            }
            else
            {
                Reservation NewRes = new Reservation(court0, customer, startTime, EndTime, date);
                customer.MakeReservation(NewRes);
                Console.WriteLine("Reservation successful!");
                Console.WriteLine("Reservation successful! Press Enter To Contunie ....");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
