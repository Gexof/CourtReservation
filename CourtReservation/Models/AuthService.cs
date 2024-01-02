using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using CourtReservation.Models.Interfaces;
using System.Text.Encodings.Web;

namespace CourtReservation.Models
{
    internal class AuthService
    {
        private const string FileName = "C:\\Users\\Mohamed Alaa\\Source\\Repos\\CourtReservation\\CourtReservation\\Data\\Users.json";
        
        private List<User> users = new();
        // List of user in Json file



        public List<User> LoadUsers()
        {
            if (File.Exists(FileName))
            {
                string jsonText = File.ReadAllText(FileName);
                List<User> loadedUsers = JsonConvert.DeserializeObject<List<User>>(jsonText);

                //foreach (var user in loadedUsers)
                //{
                //    Console.WriteLine($"Username: {user.UserName}, Password: {user.Password}");
                //}

                return loadedUsers;
            }
            Console.WriteLine("No user data found.");
            return new List<User>();
        }



        public void RegisterUser(int id ,string username, string password,string type)
        {
            User newuser = new(id, username, password, type);
            List<User> users = LoadUsers(); // Loading The List os user from Json File
            users.Add(newuser); // Add New user To the users List That Retrived from Json file
            string updateJson = JsonConvert.SerializeObject(users, Formatting.Indented); // Covert From List To Json Format
            File.WriteAllText(FileName, updateJson); // Write All Text Files to Json File 
        }

        public void login (string userName, string password)
        {
            List<User> users = LoadUsers();

            for (int i = 0; i < 3; i++)
            {
                foreach (var user in users)
                {
                if (user.UserName == userName && user.Password == password)
                {
                        Console.WriteLine("Login successful");
                         return; // Login successful, exit the method
                }
                }
                    // If no matching user is found
                 Console.WriteLine("Sorry, try again");
            }
                 Console.WriteLine("Sorry, You can't login again");

        }

    }
}
