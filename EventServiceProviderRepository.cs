//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TicketBooking.Entity;
//using TicketBooking.Interface;

//namespace TicketBooking.Repository
//{
//    internal class EventServiceProviderImpl : IEventServiceProvider
//    {
//        private List<Event> events = new List<Event>();

//        public Event CreateEvent(string eventName, DateTime eventDate, TimeSpan eventTime, int totalSeats, decimal ticketPrice, EventType eventType)
//        {
//            Event newEvent;

//            switch (eventType)
//            {
//                case EventType.Movie:
//                    newEvent = new Movie()
//                    {
//                        EventName = eventName,
//                        EventDate = eventDate,
//                        EventTime = eventTime,
//                        TotalSeats = totalSeats,
//                        TicketPrice = ticketPrice,
//                        EventType = eventType,
//                        Genre = MovieGenre.Action,
//                        ActorName = "John Doe",
//                        ActressName = "Jane Doe"
//                    };
//                    break;
//                case EventType.Concert:
//                    newEvent = new Concert()
//                    {
//                        EventName = eventName,
//                        EventDate = eventDate,
//                        EventTime = eventTime,
//                        TotalSeats = totalSeats,
//                        TicketPrice = ticketPrice,
//                        EventType = eventType,
//                        Artist = "Artist Name",
//                        Type = ConcertType.Rock
//                    };
//                    break;
//                case EventType.Sports:
//                    newEvent = new Sports()
//                    {
//                        EventName = eventName,
//                        EventDate = eventDate,
//                        EventTime = eventTime,
//                        TotalSeats = totalSeats,
//                        TicketPrice = ticketPrice,
//                        EventType = eventType,
//                        SportName = "Football",
//                        TeamsName = "TeamA vs TeamB"
//                    };
//                    break;
//                default:
//                    throw new ArgumentException("Invalid event type");
//            }

//            events.Add(newEvent);
//            return newEvent;
//        }

//        public Event[] GetEventDetails()
//        {
//            return events.ToArray();
//        }

//        public int GetAvailableNoOfTickets(string eventName)
//        {
//            Event eventToCheck = events.Find(e => e.EventName == eventName);
//            return eventToCheck != null ? eventToCheck.AvailableSeats : -1;
//        }
//    }

//}
