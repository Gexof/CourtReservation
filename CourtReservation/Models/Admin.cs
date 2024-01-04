using CourtReservation.Models.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Models
{
    internal class Admin : User
    {
        private const string CourtPath = "C:\\Users\\thepe\\source\\repos\\CourtReservation\\CourtReservation\\Data\\Court.json";
        private List<Court> courts;

        public Admin()
        {
            courts = new List<Court>();
        }


        public Admin(int id, string userName, string password) : base(id, userName, password, "admin") { }


        //Show all courts
        public List<Court> ShowCourt()
        {

            if (File.Exists(CourtPath))
            {
                string jsonText = File.ReadAllText(CourtPath);
                List<Court> ShowCourt = JsonConvert.DeserializeObject<List<Court>>(jsonText);

                foreach (var court in ShowCourt)
                {
                    Console.WriteLine($"CourtID: {court.CourtId}, Description: {court.Description}, Type: {court.Type}");
                }

                return ShowCourt;
            }
            Console.WriteLine("No user data found.");
            return new List<Court>();


        }


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
            if (File.Exists(CourtPath))
            {
                string jsonText = File.ReadAllText(CourtPath);
                List<Court> courts = JsonConvert.DeserializeObject<List<Court>>(jsonText);

                Court courtToUpdate = courts.Find(court => court.CourtId == oldCourtId);
                if (courtToUpdate != null)
                {
                    courtToUpdate.CourtId = newCourtId;

                    // Serialize the updated data and write it back to the JSON file
                    string updatedJson = JsonConvert.SerializeObject(courts, Formatting.Indented);
                    File.WriteAllText(CourtPath, updatedJson);

                    Console.WriteLine($"Updated Court ID from '{oldCourtId}' to '{newCourtId}' in Court.json");
                }
                else
                {
                    Console.WriteLine($"Court ID {oldCourtId} not found");
                }
            }
            else
            {
                Console.WriteLine("Court.json not found");
            }
        }
    }



               // Method to accept a court (just as an example)

               //public void AcceptRes()
                //{
                //  Console.WriteLine("Court accepted");
                // Additional logic for accepting a court can be added here
     
               //}

    
}
