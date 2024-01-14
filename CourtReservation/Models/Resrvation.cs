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

        private const string ResPath = "C:\\Users\\Mohamed Ashraf\\source\\repos\\CourtReservation\\CourtReservation\\Data\\Reservation.json";
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



    }
    }