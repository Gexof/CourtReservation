 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

namespace CourtReservation.Models
{
    internal class Reservation:User,Court
    {


        public int ResrvationId { set; get; }

        public DateOnly Date { set; get; }

        public string CourtType { set; get; }

        public string UserName { set; get; }
        


       
        
        public Reservation(int ResrvationId, string UserName, string CourtType, DateOnly Date)
            : base(username, type) 
        {
            this.ResrvationId = ResrvationId;
            this.Date = Date;
            this.UserName = UserName;
            this.CourtType = CourtType;
        }
        public void Show_Reservation_Details()
        {
            Console.WriteLine(ResrvationId);
            Console.WriteLine(UserName);
            Console.WriteLine(CourtType);
            Console.WriteLine(Date);
        }
        public void Cancel_Reservation()
        {

        }