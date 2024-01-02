using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Models
{
    internal class User /*: AuthService*/
    {

        private const string FileName = "C:/Users/Mohamed Ashraf/Desktop/New folder/CourtReservation/CourtReservation/Data/Users.json";

        //Attribute
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }


        public User()

        {
            
        }


        //Parametarized Constructor
        public User(string userName, string password, string userType)

        {

        }
        //Parametarized Constructor
        public User(int id,string userName, string password, string userType)
        {
            Id = id;
            UserName = userName;
            Password = password;
            UserType = userType;
        }

        public User(string userName, string password) : this( 0,userName, password, "") { }







        public List<User> LoadUsers()
        {
            if (File.Exists(FileName))
            {
                string jsonText = File.ReadAllText(FileName);
                List<User> loadedUsers = JsonConvert.DeserializeObject<List<User>>(jsonText);

                foreach (var user in loadedUsers)
                {
                    Console.WriteLine($"ID: {user.Id}, Username: {user.UserName}, Type: {user.UserType}");
                }

                //foreach (var user in loadedUsers)
                //{
                //    Console.WriteLine($"Username: {user.UserName}, Password: {user.Password}");
                //}


                return loadedUsers;
            }
            Console.WriteLine("No user data found.");
            return new List<User>();
        }

        public void RegisterUser(int id, string username, string password, string type)
        {
            User newuser = new(id, username, password, type);
            List<User> users = LoadUsers(); // Loading The List os user from Json File
            users.Add(newuser); // Add New user To the users List That Retrived from Json file
            string updateJson = JsonConvert.SerializeObject(users, Formatting.Indented); // Covert From List To Json Format
            File.WriteAllText(FileName, updateJson); // Write All Text Files to Json File 
        }

        public void login(string userName, string password)
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






