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

        public List<Reservation> ResList { get; set; }
        public TimeSpan StartTime { set; get; }
        public TimeSpan EndTime { set; get; }



        public Reservation(int ResrvationId, Court court, Customer customer, TimeSpan StartTime, TimeSpan EndTime, DateOnly Date)
        {
            this.ResrvationId = ResrvationId;
            this.Date = Date;
            this.customer = customer;
            this.court = court;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
        }
        public Reservation (DateOnly date,TimeSpan StartTime,TimeSpan EndTime)
        {
        }
        public  static void ReservationProcess(DateOnly date, TimeSpan StartTime, TimeSpan EndTime, Court court,Customer customer)
        {
            Reservation newreservation = new Reservation(date, StartTime, EndTime);

            //Console.WriteLine("Add The Date");
            //date = DateOnly.Parse(Console.ReadLine());
            //Console.WriteLine($"Date: {date}");
            //Console.WriteLine("Add The Start Time");
            //StartTime = TimeSpan.Parse(Console.ReadLine());
            //Console.WriteLine($"Start time: {StartTime}");
            //Console.WriteLine("Add The End Time");
            //EndTime = TimeSpan.Parse(Console.ReadLine());
            //Console.WriteLine($"End time: {EndTime}");
        }


    }
    }