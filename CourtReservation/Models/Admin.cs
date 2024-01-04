using CourtReservation.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Models
{
    internal class Admin : User
    {
        private const string CourtPath = "C:\\Users\\Alex\\Source\\Repos\\CourtReservation\\CourtReservation\\Data\\Court.json";
        private List<Court> courts;

        public Admin()
        {
            courts = new List<Court>();
        }


        public Admin(int id, string userName, string password) : base(id, userName, password, "admin") { }


        // Add a new court with an integer CourtId
        public void AddCourt(int courtId)
        {
            Court newCourt = new Court(courtId);
            courts.Add(newCourt);
            Console.WriteLine($"Added Court ID: {courtId}");
        }


        //Remove a court by ID
        public void RemoveCourt(int courtIdToRemove)
        {
            Court courtToRemove = courts.Find(court => court.CourtId == courtIdToRemove);
            if (courtToRemove != null)
            {
                courts.Remove(courtToRemove);
                Console.WriteLine($"Removed Court ID: {courtIdToRemove}");
            }
            else
            {
                Console.WriteLine($"Court ID {courtIdToRemove} not found");
            }
        }

        // Update a court's ID
        public void UpdateCourt(int oldCourtId, int newCourtId)
        {
            Court courtToUpdate = courts.Find(court => court.CourtId == oldCourtId);
            if (courtToUpdate != null)
            {
                courtToUpdate.CourtId = newCourtId;
                Console.WriteLine($"Updated Court ID from '{oldCourtId}' to '{newCourtId}'");
            }
            else
            {
                Console.WriteLine($"Court ID {oldCourtId} not found");
            }
        }

        //Show all courts
        public void ShowCourt()
        {
            Console.WriteLine("Available Courts:");
            foreach (var court in courts)
            {
                Console.WriteLine(court);

            }
        }

        // Method to accept a court (just as an example)
        public void AcceptRes()
        {
            Console.WriteLine("Court accepted");
            // Additional logic for accepting a court can be added here

        }

    }
}
