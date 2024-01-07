using CourtReservation.Models.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Models.test
{
    internal class test
    {

        private const string CourtPath = "C:\\Users\\Mohamed Ashraf\\source\\repos\\CourtReservation\\CourtReservation\\Data\\Court.json";




        //public void swFunc()
        //{
        //    Console.Write("Enter ID of Court You Want to Update: ");
        //    int CourtId = 104;
        //    Console.WriteLine("[1] Update ID");
        //    Console.WriteLine("[2] Update Description");
        //    Console.WriteLine("[3] Update Type");
        //    Console.Write("Chosse What Update You Want: ");
        //    string userInput = "2";
        //    switch (userInput)
        //    {
        //        case "1":

        //            break;
        //        case "2":
        //            Console.Write("Enter New Description: ");
        //            string NewDesc = "I'm New Desc";
        //            UpdateDesc(CourtId, NewDesc);
        //            break;
        //    }
        //}






        /* 
         update : id
        int id = 109;
            ask for what do you want to do 
            1 - update ID 
            2 - update Description
            3 - update Type
            you chosse 2
            Enter Desc : string desc = "I'm new desc" 
                updateDesc(string desc, Court courtToUpdate) {
                     courtToUpdate.Description = desc;
        }


        updatecourt(CourtId) {
            Court courtToUpdate = courts.Find(court => court.CourtId == CourtId);
            switch (input = 2)
            {
                 case "2":
                Enter Desc : desc = zobr
                 updateDesc(desc , courtToUpdate);
                 break;
            }

        }
         */

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



        public void UpdateCourt(int id,string choise )
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
                            UpdateId(NewId,courtToUpdate);
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









        }
    }
