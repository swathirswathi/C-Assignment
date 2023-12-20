//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TicketBooking.Interface;

//namespace TicketBooking.Entity
//{
//    //    public class TicketBookingSystemImpl : BookingSystem
//    //    {
//    //        public override Event CreateEvent(string eventName, DateTime eventDate, TimeSpan eventTime, int totalSeats, decimal ticketPrice, EventType eventType, string venueName)
//    //        {
//    //            Event newEvent;

//    //            switch (eventType)
//    //            {
//    //                case EventType.Movie:
//    //                    newEvent = new Movie()
//    //                    {
//    //                        EventName = eventName,
//    //                        EventDate = eventDate,
//    //                        EventTime = eventTime,
//    //                        VenueName = venueName,
//    //                        TotalSeats = totalSeats,
//    //                        TicketPrice = ticketPrice,
//    //                        EventType = eventType,
//    //                        Genre = "Comedy",
//    //                        ActorName = "John Doe",
//    //                        ActressName = "Jane Doe"
//    //                    };
//    //                    break;
//    //                case EventType.Concert:
//    //                    newEvent = new Concert()
//    //                    {
//    //                        EventName = eventName,
//    //                        EventDate = eventDate,
//    //                        EventTime = eventTime,
//    //                        VenueName = venueName,
//    //                        TotalSeats = totalSeats,
//    //                        TicketPrice = ticketPrice,
//    //                        EventType = eventType,
//    //                        Artist = "Artist Name",
//    //                        Type = ConcertType.Rock
//    //                    };
//    //                    break;
//    //                case EventType.Sports:
//    //                    newEvent = new Sports()
//    //                    {
//    //                        EventName = eventName,
//    //                        EventDate = eventDate,
//    //                        EventTime = eventTime,
//    //                        VenueName = venueName,
//    //                        TotalSeats = totalSeats,
//    //                        TicketPrice = ticketPrice,
//    //                        EventType = eventType,
//    //                        SportName = "Football",
//    //                        TeamsName = "TeamA vs TeamB"
//    //                    };
//    //                    break;
//    //                default:
//    //                    throw new ArgumentException("Invalid event type");
//    //            }

//    //            Events.Add(newEvent);
//    //            return newEvent;
//    //        }

//    //        public override void DisplayEventDetails(Event eventObj)
//    //        {
//    //            eventObj.DisplayEventDetails();
//    //        }

//    //        public override void BookTickets(Event eventObj, int numTickets)
//    //        {
//    //            eventObj.BookTickets(numTickets);
//    //        }

//    //        public override void CancelTickets(Event eventObj, int numTickets)
//    //        {
//    //            eventObj.CancelBooking(numTickets);
//    //        }

//    //        public override int GetAvailableNoOfTickets(Event eventObj)
//    //        {
//    //            return eventObj.AvailableSeats;
//    //        }


//    //        public void Main()
//    //        {
//    //            Console.WriteLine("Welcome to the Ticket Booking System!");

//    //            while (true)
//    //            {
//    //                Console.WriteLine("\nMenu:");
//    //                Console.WriteLine("1. Create Event");
//    //                Console.WriteLine("2. Display Event Details");
//    //                Console.WriteLine("3. Book Tickets");
//    //                Console.WriteLine("4. Cancel Tickets");
//    //                Console.WriteLine("5. Get Available Seats");
//    //                Console.WriteLine("6. Exit");

//    //                Console.Write("Enter your choice: ");
//    //                string choice = Console.ReadLine();

//    //                switch (choice)
//    //                {
//    //                    case "1":
//    //                        Console.WriteLine("Enter event details:");
//    //                        Console.Write("Event Name: ");
//    //                        string eventName = Console.ReadLine();
//    //                        Console.Write("Event Date (yyyy-mm-dd): ");
//    //                        DateTime eventDate = DateTime.Parse(Console.ReadLine());
//    //                        Console.Write("Event Time (hh:mm): ");
//    //                        TimeSpan eventTime = TimeSpan.Parse(Console.ReadLine());
//    //                        Console.Write("Venue Name: ");
//    //                        string venueName = Console.ReadLine();
//    //                        Console.Write("Total Seats: ");
//    //                        int totalSeats = int.Parse(Console.ReadLine());
//    //                        Console.Write("Ticket Price: ");
//    //                        decimal ticketPrice = decimal.Parse(Console.ReadLine());
//    //                        Console.Write("Event Type (Movie/Concert/Sport): ");
//    //                        EventType eventType = Enum.Parse<EventType>(Console.ReadLine(), true);

//    //                        CreateEvent(eventName, eventDate, eventTime, totalSeats, ticketPrice, eventType, venueName);
//    //                        break;

//    //                    case "2":
//    //                        Console.WriteLine("Enter the index of the event:");
//    //                        int eventIndex = int.Parse(Console.ReadLine());

//    //                        if (eventIndex >= 0 && eventIndex < Events.Count)
//    //                        {
//    //                            DisplayEventDetails(Events[eventIndex]);
//    //                        }
//    //                        else
//    //                        {
//    //                            Console.WriteLine("Invalid index.");
//    //                        }
//    //                        break;

//    //                    case "3":
//    //                        Console.WriteLine("Enter the index of the event to book tickets:");
//    //                        int bookIndex = int.Parse(Console.ReadLine());

//    //                        if (bookIndex >= 0 && bookIndex < Events.Count)
//    //                        {
//    //                            Console.Write("Enter the number of tickets to book: ");
//    //                            int numTicketsToBook = int.Parse(Console.ReadLine());
//    //                            BookTickets(Events[bookIndex], numTicketsToBook);
//    //                        }
//    //                        else
//    //                        {
//    //                            Console.WriteLine("Invalid index.");
//    //                        }
//    //                        break;

//    //                    case "4":
//    //                        Console.WriteLine("Enter the index of the event to cancel tickets:");
//    //                        int cancelIndex = int.Parse(Console.ReadLine());

//    //                        if (cancelIndex >= 0 && cancelIndex < Events.Count)
//    //                        {
//    //                            Console.Write("Enter the number of tickets to cancel: ");
//    //                            int numTicketsToCancel = int.Parse(Console.ReadLine());
//    //                            CancelTickets(Events[cancelIndex], numTicketsToCancel);
//    //                        }
//    //                        else
//    //                        {
//    //                            Console.WriteLine("Invalid index.");
//    //                        }
//    //                        break;

//    //                    case "5":
//    //                        Console.WriteLine("Enter the index of the event to get available seats:");
//    //                        int seatsIndex = int.Parse(Console.ReadLine());

//    //                        if (seatsIndex >= 0 && seatsIndex < Events.Count)
//    //                        {
//    //                            Console.WriteLine($"Available Seats: {GetAvailableNoOfTickets(Events[seatsIndex])}");
//    //                        }
//    //                        else
//    //                        {
//    //                            Console.WriteLine("Invalid index.");
//    //                        }
//    //                        break;

//    //                    case "6":
//    //                        Console.WriteLine("Exiting the Ticket Booking System. Goodbye!");
//    //                        return;

//    //                    default:
//    //                        Console.WriteLine("Invalid choice. Please enter a valid option.");
//    //                        break;
//    //                }
//    //            }
//    //        }
//    //    }
//    internal class TicketBookingSystem
//    {
//        private IBookingSystemServiceProvider bookingSystemServiceProvider;

//        public TicketBookingSystem(IBookingSystemServiceProvider bookingSystemServiceProvider)
//        {
//            this.bookingSystemServiceProvider = bookingSystemServiceProvider;
//        }

//        public void Main()
//        {
//            while (true)
//            {
//                try {
//                    Console.WriteLine("Enter a command: create_event, book_tickets, cancel_tickets, get_available_seats, get_event_details, exit");
//                    string command = Console.ReadLine().ToLower();

//                    switch (command)
//                    {
//                        case "create_event":
//                            Console.WriteLine("Enter event details:");

//                            Console.Write("Event Name: ");
//                            string eventName = Console.ReadLine();

//                            Console.Write("Date (yyyy-MM-dd): ");
//                            string date = Console.ReadLine();

//                            Console.Write("Time (HH:mm:ss): ");
//                            string time = Console.ReadLine();

//                            Console.Write("Total Seats: ");
//                            int totalSeats = int.Parse(Console.ReadLine());

//                            Console.Write("Ticket Price: ");
//                            decimal ticketPrice = decimal.Parse(Console.ReadLine());

//                            Console.Write("Event Type (Movie, Concert, Sport): ");
//                            string eventType = Console.ReadLine();

//                            Console.Write("Venue Name: ");
//                            string venueName = Console.ReadLine();

//                            Console.Write("Venue Address: ");
//                            string venueAddress = Console.ReadLine();



//                            Event createdEvent = bookingSystemServiceProvider.create_event(eventName, date, time, totalSeats, ticketPrice, eventType);
//                            Console.WriteLine($"Event '{createdEvent.event_name}' created successfully.");
//                            break;



//                        case "exit":
//                            Environment.Exit(0);
//                            break;
//                        default:
//                            Console.WriteLine("Invalid command. Please try again.");
//                            break;
//                    }
//                }
//                catch(NullPointerException ex)
//                {
//                    throw new NullPointerException($"NullPointerException: {ex.Message}");
//                }
//             }
            
//        }
//    }
//}
