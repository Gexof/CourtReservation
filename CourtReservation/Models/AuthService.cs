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
        private const string FileName = "admin.json";
        private List<User> users;

        public List<User> LoadUsers()
        {
            if (File.Exists(FileName))
            {
                string json = File.ReadAllText(FileName);
                List<User> loadedUsers = JsonConvert.DeserializeObject<List<User>>(json);

                foreach (var user in loadedUsers)
                {
                    Console.WriteLine($"Username: {user.UserName}, Password: {user.Password}");
                }

                return loadedUsers;
            }
            Console.WriteLine("No user data found.");
            return new List<User>();
        }
    }
}
