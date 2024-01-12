using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace CourtReservation.Models
{
    internal class Customer : User
    {
        // Attribute
        //[JsonIgnore]
 
        string Resname = "C:\\Users\\Mohamed Ashraf\\Source\\Repos\\CourtReservation\\CourtReservation\\Data\\Reservation.json";

        // Default Constructor
        public Customer()
        {
            //ReservationsList = new List<Reservation>();
        }

        //Parameterized Constructor
        public Customer(int id, string userName) : base(id, userName, "", "customer")
        {
            //Re/*servationsList = new List<Reservation>();*/
        }

        public Customer(string userName, string password) : base(userName, password, "customer") { }


        // Make a reservation
        public void MakeReservation(Reservation reservation)
        {

            List<Reservation> ReservationsList;
        // Loading existing reservations 
            ReservationsList = reservation.LoadReservationData();

            // Creating a new reservation
            Reservation newReservation = new Reservation
            {
                ResrvationId = GenerateUniqueReservationId(),
                Date = reservation.Date, 
                court = reservation.court, 
                customer = reservation.customer, 
                StartTime = reservation.StartTime,
                EndTime = reservation.EndTime
            };

            // Adding the new reservation to the list
            ReservationsList.Add(newReservation);

            // Serializing and writing the updated list to the file
            string updateJson = JsonConvert.SerializeObject(ReservationsList, Formatting.Indented);
            File.WriteAllText(Resname, updateJson);
        }


        private int GenerateUniqueReservationId()
        {
            // Get the current timestamp in milliseconds
            long timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

            // Convert the timestamp to an integer (you can adjust this based on your requirements)
            int uniqueId = (int)timestamp;

            return uniqueId;
        }

        // View reservations
        public void ViewReservations()
        {
            Reservation reservation = new Reservation();
            int userId = 50000; // Replace with the actual user ID

            List<Reservation> reservations = reservation.LoadReservationData();

            bool reservationsFound = false;

            foreach (var item in reservations)
            {
                if (userId == item.customer.Id)
                {
                    Console.WriteLine($"Reservation ID: {item.ResrvationId}");
                    Console.WriteLine($"Date: {item.Date.ToShortDateString()}");
                    Console.WriteLine($"Court: {item.court.CourtId} {item.court.Description} {item.court.Type}");
                    Console.WriteLine($"Customer: {item.customer.UserName}");
                    Console.WriteLine($"Reserved Time Slots: {item.StartTime} - {item.EndTime}");
                    Console.WriteLine();

                    reservationsFound = true;
                }
            }

            if (!reservationsFound)
            {
                Console.WriteLine("No reservations found for the specified user ID.");
            }


        }



    }
}
