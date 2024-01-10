using CourtReservation.Models.Interfaces;
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
 
        string Resname = @"C:\Users\Mohamed Alaa\source\repos\CourtReservation\CourtReservation\Data\Reservation.json";

        // Default Constructor
        public Customer()
        {
            //ReservationsList = new List<Reservation>();
        }

        //Parameterized Constructor
        public Customer(int id, string userName) : base(id, userName, "", "Customer")
        {
            //Re/*servationsList = new List<Reservation>();*/
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
            // Get the current timestamp in milliseconds
            long timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

            // Convert the timestamp to an integer (you can adjust this based on your requirements)
            int uniqueId = (int)timestamp;

            return uniqueId;
        }

        // View reservations
        //public void ViewReservations()
        //{
        //    foreach (var reservation in ReservationsList)
        //    {
        //        Console.WriteLine($"Reservation ID: {reservation.ResrvationId}");
        //        Console.WriteLine($"Date: {reservation.Date.ToShortDateString()}");
        //        Console.WriteLine($"Court: {reservation.court.CourtId} {reservation.court.Description} {reservation.court.Type}");
        //        Console.WriteLine($"Customer: {reservation.customer.UserName}");
        //        Console.WriteLine("Reserved Time Slots:");
        //        foreach (var timeSlot in reservation.ReservedTimeSlots)
        //        {
        //            Console.WriteLine($"- {timeSlot.StartTime} to {timeSlot.EndTime}");
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
