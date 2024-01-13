using Newtonsoft.Json;
using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

namespace CourtReservation.Models
{
    internal class Reservation 
    {

        private const string ResPath = "C:\\Users\\Administrator\\source\\repos\\CourtReservation\\CourtReservation\\Data\\Reservation.json";
        public int ResrvationId { set; get; }

        public DateOnly Date { set; get; }

        public Court court { set; get; }

        public Customer customer { set; get; }

        //public List<(TimeSpan StartTime, TimeSpan EndTime)> ReservedTimeSlots { get; set; } = new List<(TimeSpan StartTime, TimeSpan EndTime)>();
        public TimeSpan StartTime { set; get; }
        public TimeSpan EndTime { set; get; }

        public Reservation() { }
        public Reservation(int ResrvationId,Court court , Customer customer, DateOnly Date) { }
        public Reservation(TimeSpan StartTime, TimeSpan EndTime)
        {

        }



        public Reservation( Court court, Customer customer, TimeSpan StartTime, TimeSpan EndTime, DateOnly Date)
        {
            //this.ResrvationId = ResrvationId;
            this.Date = Date;
            this.customer = customer;
            this.court = court;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
        }

        //public bool OverlapsWith(TimeSpan startTime1, TimeSpan endTime1, TimeSpan startTime2, TimeSpan endTime2)
        //{
        //    return startTime1 < endTime2 && endTime1 > startTime2;
        //}

        //public bool IsTimeAvilable(TimeSpan StartTime, TimeSpan EndTime)
        //{
        //    foreach (var slot in ReservedTimeSlots)
        //    {
        //        if (OverlapsWith(StartTime, EndTime, slot.StartTime, slot.EndTime))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //public bool ReserveTime(TimeSpan StartTime, TimeSpan EndTime)
        //{
        //    Reservation NewRes = new Reservation(StartTime, EndTime);

        //    if (IsTimeAvilable(NewRes.StartTime, NewRes.EndTime))
        //    {
        //        ReservedTimeSlots.Add((NewRes.StartTime, NewRes.EndTime));
        //        Console.WriteLine("Reservation successful!");
        //        return true; // Return true if the reservation is successful
        //    }
        //    else
        //    {
        //        Console.WriteLine("Time slot is already reserved. Please choose another time.");
        //        return false; // Return false if the time slot is not available
        //    }
        //}



        public List<Reservation> LoadReservationData()
        {
            if (File.Exists(ResPath))
            {
                string jsonText = File.ReadAllText(ResPath);
                List<Reservation> reservations = JsonConvert.DeserializeObject<List<Reservation>>(jsonText);

                return reservations;
            }

            Console.WriteLine("No reservation data found.");
            return new List<Reservation>();
        }


        //public void DisplayReservationDetails()
        //{
        //    Console.WriteLine($"Customer: {customer.UserName}");
        //    Console.WriteLine($"Court: {court.CourtId} {court.Description} {court.Type}");
        //    Console.WriteLine($"Reservation ID: {ResrvationId}");
        //    Console.WriteLine($"Reservation Date: {Date.ToShortDateString()}");
        //    Console.WriteLine("Reserved Time Slots:");
        //    foreach (var timeSlot in ReservedTimeSlots)
        //    {
        //        Console.WriteLine($"- {timeSlot.StartTime} to {timeSlot.EndTime}");
        //    }
        //}



    }
    }