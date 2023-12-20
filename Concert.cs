//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TicketBooking.Entity
//{
//    internal class Concert : Event
//    {
//        public string Artist { get; set; }
//        public ConcertType Type { get; set; }

//        public Concert()
//        {
//            EventType = EventType.Concert;
//        }
//        //public Concert(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName, int totalSeats, decimal ticketPrice,
//        //               string artist, ConcertType type)
//        //    : base(eventName, eventDate, eventTime, venueName, totalSeats, ticketPrice, EventType.Concert)
//        //{
//        //    Artist = artist;
//        //    Type = type;
//        //}

//        public override void DisplayEventDetails()
//        {
//            //base.DisplayEventDetails();
//            Console.WriteLine($"Artist: {Artist},Type: {Type}");
//        }

//        public void DisplayConcertDetails()
//        {
//            DisplayEventDetails();
//            Console.WriteLine($"Artist: {Artist},Type: {Type}");
//        }
//    }
//}
