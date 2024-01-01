using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation
{
    internal class RegisterScreen
    {
        public static void Register () {
            Console.WriteLine("=================== Register =================== \n");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("\nPassowrd: ");
            string password = Console.ReadLine();
        }
    }
}
