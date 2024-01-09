using Newtonsoft.Json;
using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

namespace CourtReservation.Models
{
    internal class Reservation /*: User, Court*/
    {

        private const string ResPath = "C:\\Users\\Mohamed Ashraf\\Source\\Repos\\CourtReservation\\CourtReservation\\Data\\Reservation.json";
        public int ResrvationId { set; get; }

        public DateOnly Date { set; get; }

        public Court court { set; get; }

        public Customer customer { set; get; }
        public List<TimeSlot> ReservedTimeSlots { get; set; } = new List<TimeSlot>();
        public TimeSpan StartTime { set; get; }
        public TimeSpan EndTime { set; get; }

        public Reservation() { }

        public Reservation(int ResrvationId, Court court, Customer customer, /*TimeSpan StartTime, TimeSpan EndTime,*/ DateOnly Date)
        {
            this.ResrvationId = ResrvationId;
            this.Date = Date;
            this.customer = customer;
            this.court = court;
            //this.StartTime = StartTime;
            //this.EndTime = EndTime;
        }
        public bool IsTimeAvilable(TimeSlot NewRes)
        {
            foreach (var slot in ReservedTimeSlots)
            {
                if(NewRes.OverlapsWith(slot)) return false;
            }
            return true;
        }

        public void ReserveTime (TimeSpan StartTime, TimeSpan EndTime)
        {
            TimeSlot NewRes = new TimeSlot(StartTime, EndTime);
            if (IsTimeAvilable(NewRes))
            {
                ReservedTimeSlots.Add(NewRes);
                Console.WriteLine("Reservation successful!");
            }
            else
            {
                Console.WriteLine("Time slot is already reserved. Please choose another time.");
            }
        }


        public List<Reservation> LoadReservationData()
        {
            if (File.Exists(ResPath))
            {
                string jsonText = File.ReadAllText(ResPath);
                List<Reservation> reservations = JsonConvert.DeserializeObject<List<Reservation>>(jsonText);

                foreach (var reservation in reservations)
                {
                    Console.WriteLine($"Reservation ID: {reservation.ResrvationId}");
                    Console.WriteLine($"Date: {reservation.Date}");
                    Console.WriteLine($"Time: {reservation.StartTime} - {reservation.EndTime}");

                    // Display court details
                    Console.WriteLine($"Court ID: {reservation.court.CourtId}");
                    Console.WriteLine($"Court Description: {reservation.court.Description}");
                    Console.WriteLine($"Court Type: {reservation.court.Type}");

                    // Display customer details
                    Console.WriteLine($"Customer ID: {reservation.customer.Id}");
                    Console.WriteLine($"Customer UserName: {reservation.customer.UserName}");

                    Console.WriteLine(); // Add a line break between reservations
                }

                return reservations;
            }

            Console.WriteLine("No reservation data found.");
            return new List<Reservation>();
        }


        public void DisplayReservationDetails()
        {
            Console.WriteLine($"Customer: {customer.UserName}");
            Console.WriteLine($"Court: {court.CourtId} {court.Description} {court.Type}");
            Console.WriteLine($"Reservation ID: {ResrvationId}");
            Console.WriteLine($"Reservation Date: {Date.ToShortDateString()}");
            Console.WriteLine("Reserved Time Slots:");
            foreach (var timeSlot in ReservedTimeSlots)
            {
                Console.WriteLine($"- {timeSlot.StartTime} to {timeSlot.EndTime}");
            }
        }

    }
    }