using CourtReservation.Models.test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtReservation.Screens
{
    internal class UpdateScreen
    {
        public static void UpdateScreenView()
        {
            test test = new test();
            Console.WriteLine("Update Court");
            Console.WriteLine("[1] Update ID");
            Console.WriteLine("[2] Update Description");
            Console.WriteLine("[3] Update Type");
            Console.Write("Enter Your Choise: ");
            string UserChoise = Console.ReadLine();
            Console.Write("Enter Court ID: ");
            int CourtId = int.Parse(Console.ReadLine());
            test.UpdateCourt(CourtId,UserChoise);
        }
    }
}
