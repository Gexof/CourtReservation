using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace CourtReservation.Models
{
    internal class Customer : User
    {

 
        string Resname = "C:\\Users\\Mohamed Ashraf\\source\\repos\\CourtReservation\\CourtReservation\\Data\\Reservation.json";

        public Customer()
        {
        }

        //Parameterized Constructor
        public Customer(int id, string userName) : base(id, userName, "", "customer")
        {
        }

        public Customer(string userName, string password) : base(userName, password, "customer") { }


        // Make a reservation
        public void MakeReservation(Reservation reservation)
        {

            List<Reservation> ReservationsList;
            ReservationsList = reservation.LoadReservationData();

            Reservation newReservation = new Reservation
            {
                ResrvationId = GenerateUniqueReservationId(),
                Date = reservation.Date, 
                court = reservation.court, 
                customer = reservation.customer, 
                StartTime = reservation.StartTime,
                EndTime = reservation.EndTime
            };

            ReservationsList.Add(newReservation);

            string updateJson = JsonConvert.SerializeObject(ReservationsList, Formatting.Indented);
            File.WriteAllText(Resname, updateJson);
        }


        private int GenerateUniqueReservationId()
        {
            long timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

            int uniqueId = (int)timestamp;

            return uniqueId;
        }

    }
}
