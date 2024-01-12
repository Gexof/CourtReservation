using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace CourtReservation.Models
{
    internal class Customer : User
    {

 
        string Resname = "C:/Users/Mohamed Alaa/Source/Repos/CourtReservation/CourtReservation/Data/Reservation.json";

        public Customer()
        {
        }

        //Parameterized Constructor
        public Customer(int id, string userName) : base(id, userName, "", "Customer")
        {
        }

        // Make a reservation
        public void MakeReservation(Reservation reservation)
        {

            List<Reservation> ReservationsList;
        // Loading existing reservations (optional, depending on your requirements)
            ReservationsList = reservation.LoadReservationData();

            // Creating a new reservation
            Reservation newReservation = new Reservation
            {
                ResrvationId = GenerateUniqueReservationId(), // Use the method to generate a unique ID
                Date = reservation.Date, // Set the date to the current date, adjust as needed
                court = reservation.court, // Initialize court with an instance of the Court class (adjust as needed)
                customer = reservation.customer, // Initialize customer with an instance of the Customer class (adjust as needed)
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
            long timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

            int uniqueId = (int)timestamp;

            return uniqueId;
        }

        // View reservations
        public void ViewReservations()
        {
            Reservation reservation = new Reservation();
            int userId = 50000; 

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
