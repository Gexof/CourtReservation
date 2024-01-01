using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace CourtReservation.Models
{
    internal class AuthService
    {
        private const string FileName = "C://Users//Mohamed Ashraf//Desktop//New folder//CourtReservation//CourtReservation//Data//admin.json";

        public List<Admin> LoadUsers()
        {
            if (File.Exists(FileName))
            {

                string jsonText = File.ReadAllText(FileName);
                List<Admin> loadedUsers = JsonConvert.DeserializeObject<List<Admin>>(jsonText);

                foreach (var user in loadedUsers)
                {
                    Console.WriteLine($"Username: {user.UserName}, Password: {user.Password}");
                }

                return loadedUsers;
            }
            Console.WriteLine("No user data found.");
            return new List<Admin>();
        }



        public void RegisterUser(string username, string password)
        {
            User newuser = new User(username,password);

        }
    }
}
