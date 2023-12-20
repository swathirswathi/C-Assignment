//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TicketBooking.Entity
//{
//    internal class Sports:Event
//    {
//        public string SportName { get; set; }
//        public string TeamsName { get; set; }

//        public Sports()
//        {
//            EventType = EventType.Sports;
//        }

       
//        //public Sports(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName, int totalSeats, decimal ticketPrice,
//        //              string sportName, string teamsName)
//        //    : base(eventName, eventDate, eventTime, venueName, totalSeats, ticketPrice, EventType.Sports)
//        //{
//        //    SportName = sportName;
//        //    TeamsName = teamsName;
//        //}

//        public override void DisplayEventDetails()
//        {
//           // base.DisplayEventDetails();
//            Console.WriteLine($"Sport: {SportName},Teams: {TeamsName}");
//        }

//        public void DisplaySportDetails()
//        {
//            DisplayEventDetails();
//            Console.WriteLine($"Sport: {SportName},Teams: {TeamsName}");
//        }
//    }
//}

