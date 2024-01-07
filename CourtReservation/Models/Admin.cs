﻿using CourtReservation.Models.Interfaces;
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
        private const string CourtPath = "C:\\Users\\Mohamed Ashraf\\source\\repos\\CourtReservation\\CourtReservation\\Data\\Court.json";
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
        public void AddCourt(int courtId, string Description, string Type)
        {
            List<Court> existingCourts = ShowCourt(); // Read existing data

            // Create a new court
            Court newCourt = new Court { CourtId = courtId, Description = Description, Type = Type };

            // Add the new court to the existing list
            existingCourts.Add(newCourt);

            // Save the updated list back to the file
            string updatedJson = JsonConvert.SerializeObject(existingCourts, Formatting.Indented);
            File.WriteAllText(CourtPath, updatedJson);

            Console.WriteLine($"Added Court ID: {courtId}");


        }


        // Update a court's ID
        public void UpdateId(int NewId, Court CourtToUpdate)
        {
            CourtToUpdate.CourtId = NewId;
        }

        public void UpdateDesc(string NewDesc, Court CourtToUpdate)
        {
            CourtToUpdate.Description = NewDesc;
        }


        public void UpdateType(string NewType, Court CourtToUpdate)
        {
            CourtToUpdate.Type = NewType;
        }



        public void UpdateCourt(int id, string choise)
        {
            string jsonText = File.ReadAllText(CourtPath);
            List<Court> courts = JsonConvert.DeserializeObject<List<Court>>(jsonText);
            Court courtToUpdate = courts.Find(court => court.CourtId == id);

            if (File.Exists(CourtPath))
            {

                if (courtToUpdate != null)
                {
                    switch (choise)
                    {
                        // ID
                        case "1":
                            Console.Write("Enter New ID: ");
                            int NewId = int.Parse(Console.ReadLine());
                            UpdateId(NewId, courtToUpdate);
                            break;
                        case "2":
                            Console.Write("Enter New Description: ");
                            string NewDesc = Console.ReadLine();
                            UpdateDesc(NewDesc, courtToUpdate);
                            break;
                        case "3":
                            Console.Write("Enter New Type: ");
                            string NewType = Console.ReadLine();
                            UpdateType(NewType, courtToUpdate);
                            break;
                    }
                    // Serialize the updated data and write it back to the JSON file
                    string updatedJson = JsonConvert.SerializeObject(courts, Formatting.Indented);
                    File.WriteAllText(CourtPath, updatedJson);

                    //Console.WriteLine($"Updated Court ID from '{oldCourtId}' to '{newCourtId}' in Court.json");
                }
                else
                {
                    Console.WriteLine($"Court ID {id} not found");
                }
            }
            else
            {
                Console.WriteLine("Court.json not found");
            }
        }



        //Remove a court by ID
        public void RemoveCourt(int courtId)
        {
            List<Court> existingCourts = ShowCourt(); // Get the list of courts

            Court courtToRemove = existingCourts.Find(Court => Court.CourtId == courtId); 

            if (courtToRemove != null)
            {
                existingCourts.Remove(courtToRemove);

                // Save the updated list back to the file
                string updatedJson = JsonConvert.SerializeObject(existingCourts, Formatting.Indented);
                File.WriteAllText(CourtPath, updatedJson);

                Console.WriteLine($"Removed Court ID: {courtId}");
            }
            else
            {
                Console.WriteLine($"Court ID {courtId} not found.");
            }
        }


        // Method to accept a court (just as an example)
        //public void AcceptRes()
        //{
        //  Console.WriteLine("Court accepted");
        // Additional logic for accepting a court can be added here

        //}

    }


}
