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

            string[] User = new string[] { "Customer", "Admin" };
            Customer customer = new Customer(7, "Islam", 1234, "Court4");
            customer.PrintUserData();




        }
    }
}
