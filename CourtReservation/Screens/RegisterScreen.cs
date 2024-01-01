using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Screens
{
    internal class RegisterScreen
    {
        public static void Register()
        {
            Console.WriteLine("=================== Register New Account =================== \n");
            Console.WriteLine("Please Select Account Type:");
            Console.WriteLine("[1] Customer");
            Console.WriteLine("[2] Admin");
            int AccType = int.Parse(Console.ReadLine());

            if (AccType == 1 )
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("\nPassowrd: ");
                string password = Console.ReadLine();

            } else if (AccType == 2 )
            {

                Console.Clear();
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("\nPassowrd: ");
                string password = Console.ReadLine();
                Console.Write("\nSystem Admin PIN: ");
                string pin = Console.ReadLine();
            } else
            {
                Console.WriteLine("Wrong Option");
            }



          

        }
    }
}
