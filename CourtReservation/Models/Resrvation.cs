 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

namespace CourtReservation.Models
{
    internal class Reservation /*: User, Court*/
    {


        public int ResrvationId { set; get; }

        public DateOnly Date { set; get; }

        public Court court { set; get; }

        public Customer customer { set; get; }
        public List<TimeSlot> ReservedTimeSlots { get; set; } = new List<TimeSlot>();
        //public TimeSpan StartTime { set; get; }
        //public TimeSpan EndTime { set; get; }



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