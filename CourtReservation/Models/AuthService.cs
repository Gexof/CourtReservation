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

namespace CourtReservation.Models
{
    internal class AuthService
    {
        private const string FileName = "C:/Users/Mohamed Alaa/Source/Repos/CourtReservation/CourtReservation/Data/admin.json";
        private List<User> loadedUsers = new List<User>();


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



        public void RegisterUser(int id ,string username, string password,string type)
        {

            User newuser = new User ( username ,password);


             List<User> zm = LoadUsers();
            User newuser = new User(id, username, password, type);
            loadedUsers.Add(newuser);
            string json = JsonConvert.SerializeObject(loadedUsers, Formatting.Indented);
            File.WriteAllText(FileName, json);

        }
    }
}
