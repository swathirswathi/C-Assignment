//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TicketBooking.Interface;

//namespace TicketBooking.Entity
//{
//    //    internal class TicketBookingSystem
//    //    {
//    //        private List<Event> events = new List<Event>();

//    //    public Event CreateEvent(string eventName, DateTime eventDate, TimeSpan eventTime, int totalSeats, decimal ticketPrice, EventType eventType, string venueName)
//    //    {
//    //        Event newEvent;

//    //        switch (eventType)
//    //        {
//    //            case EventType.Movie:
//    //                newEvent = new Movie(eventName, eventDate, eventTime, venueName, totalSeats, ticketPrice, MovieGenre.Action, "John Doe", "Jane Doe");
//    //                break;
//    //            case EventType.Concert:
//    //                newEvent = new Concert(eventName, eventDate, eventTime, venueName, totalSeats, ticketPrice, "Artist Name", ConcertType.Rock);
//    //                break;
//    //            case EventType.Sports:
//    //                newEvent = new Sports(eventName, eventDate, eventTime, venueName, totalSeats, ticketPrice, "Football", "TeamA vs TeamB");
//    //                break;
//    //            default:
//    //                throw new ArgumentException("Invalid event type");
//    //        }

//    //        events.Add(newEvent);
//    //        return newEvent;
//    //    }

//    //    public void DisplayEventDetails(Event eventObj)
//    //    {
//    //        eventObj.DisplayEventDetails();
//    //    }

//    //        public decimal BookTickets(Event eventObj, int numTickets)
//    //        {
//    //            return (decimal)eventObj.BookTickets(numTickets);
//    //        }

//    //        public void CancelTickets(Event eventObj, int numTickets)
//    //    {
//    //        eventObj.CancelBooking(numTickets);
//    //    }
//    //        public int GetAvailableNoOfTickets(Event eventObj)
//    //        {
//    //            return eventObj.AvailableSeats;
//    //        }
//    //    }


//    //Collection
//    public class TicketBookingSystem
//    {
//        //List<T>
//        private IBookingSystemServiceProvider bookingSystemServiceProvider;
//        //private List<Event> events; // Change to List
       
//        //HashSet<T>
//        //private HashSet<Event> events;

//        //Dictionary<K, V>
//        //private Dictionary<int, Event> events;

//        public TicketBookingSystem(IBookingSystemServiceProvider bookingSystemServiceProvider)
//        {
//            this.bookingSystemServiceProvider = bookingSystemServiceProvider;
//            this.events = new List<Event>(); // Change to List
//        }

        
//    }

//}
