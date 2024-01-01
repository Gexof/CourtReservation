namespace CourtReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = ("Court Reservation");

            Console.WriteLine("=============================");
            Console.WriteLine("Welcome To Court Reservation");
            Console.WriteLine("============================= \n");

            Console.WriteLine("Please Select an Option Register or Login");
            Console.WriteLine("[1] Register");
            Console.WriteLine("[2] Login");


            User user = new User("Mohamed",156456); 
            user.PrintUserData();


        }
    }
}
