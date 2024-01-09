using CourtReservation.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Models
{
    internal class Customer : User
    {
        //Attribute
        public List<Reservation> Reservations { get; set; }
        //Default Constructor
        public Customer()
        {
            Reservations = new List<Reservation>();

        }
        public Customer(int id, string userName, string password, string reservedList) :base (id,userName, password, "Customer") {
            Reservations = new List<Reservation>();
        }

        public Customer(int id, string userName) : base(id, userName,"","Customer") {
            Reservations = new List<Reservation>();
        }
        public void MakeReservation(Reservation reservation)
        {
            Reservations = reservation.LoadReservationData();

            

            reservation = new Reservation(reservation.ResrvationId, , );

            Reservations.Add(reservation);


        }
        //Parametarized Constructor

        public void ViewReservations()
        {
            foreach (var reservation in Reservations)
            {
                reservation.DisplayReservationDetails();
                Console.WriteLine();
            }
        }


    }
}
