﻿using Microsoft.Win32;

namespace CourtReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppScreen.Weclome();
            int userChosie = int.Parse(Console.ReadLine());
            if (userChosie == 1)
            {
                Console.Clear();
                RegisterScreen.Register();
            }
        }
    }
}
