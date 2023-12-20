//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TicketBooking.Entity
//{
//    //public abstract class BookingSystem
//    internal class BookingSystem
//    {
//        //protected List<Event> Events = new List<Event>();
//        //public abstract Event CreateEvent(string eventName, DateTime eventDate, TimeSpan eventTime, int totalSeats, decimal ticketPrice, EventType eventType, string venueName);
//        //public abstract void DisplayEventDetails(Event eventObj);
//        //public abstract void BookTickets(Event eventObj, int numTickets);
//        //public abstract void CancelTickets(Event eventObj, int numTickets);
//        //public abstract int GetAvailableNoOfTickets(Event eventObj);
//        private List<Event> events = new List<Event>();
//        private List<Booking> bookings = new List<Booking>();

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
//                        Genre = "Action",
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

//        public void CalculateBookingCost(Booking booking)
//        {
//            booking.TotalCost = booking.Event.TicketPrice * booking.NumTickets;
//        }

//        public void BookTickets(string eventName, int numTickets, Customer[] customers)
//        {
//            Event eventToBook = events.Find(e => e.EventName == eventName);

//            if (eventToBook != null)
//            {
//                eventToBook.BookTickets(numTickets);

//                Booking newBooking = new Booking(customers, eventToBook, numTickets);
//                bookings.Add(newBooking);

//                Console.WriteLine($"Booking successful! Booking ID: {newBooking.BookingId}");
//            }
//            else
//            {
//                Console.WriteLine($"Error: Event '{eventName}' not found.");
//            }
//        }

//        public void CancelBooking(int bookingId)
//        {
//            Booking bookingToCancel = bookings.Find(b => b.BookingId == bookingId);

//            if (bookingToCancel != null)
//            {
//                bookingToCancel.Event.CancelBooking(bookingToCancel.NumTickets);
//                bookings.Remove(bookingToCancel);

//                Console.WriteLine($"Booking canceled successfully. Booking ID: {bookingToCancel.BookingId}");
//            }
//            else
//            {
//                Console.WriteLine($"Error: Booking with ID {bookingId} not found.");
//            }
//        }

//        public int GetAvailableNoOfTickets(string eventName)
//        {
//            Event eventToCheck = events.Find(e => e.EventName == eventName);

//            return eventToCheck != null ? eventToCheck.AvailableSeats : -1;
//        }

//        public Event GetEventDetails(string eventName)
//        {
//            return events.Find(e => e.EventName == eventName);
//        }

//        public void Main()
//        {
//            Console.WriteLine("Welcome to the Ticket Booking System!");

//            while (true)
//            {
//                Console.WriteLine("\nMenu:");
//                Console.WriteLine("1. Create Event");
//                Console.WriteLine("2. Book Tickets");
//                Console.WriteLine("3. Cancel Booking");
//                Console.WriteLine("4. Get Available Seats");
//                Console.WriteLine("5. Get Event Details");
//                Console.WriteLine("6. Exit");

//                Console.Write("Enter your choice: ");
//                string choice = Console.ReadLine();

//                switch (choice)
//                {
//                    case "1":
//                        Console.WriteLine("Enter event details:");
//                        Console.Write("Event Name: ");
//                        string eventName = Console.ReadLine();
//                        Console.Write("Event Date (yyyy-mm-dd): ");
//                        DateTime eventDate = DateTime.Parse(Console.ReadLine());
//                        Console.Write("Event Time (hh:mm): ");
//                        TimeSpan eventTime = TimeSpan.Parse(Console.ReadLine());
//                        Console.Write("Venue Name: ");
//                        string venueName = Console.ReadLine();
//                        Console.Write("Venue Address: ");
//                        string venueAddress = Console.ReadLine();
//                        Venue venue = new Venue(venueName, venueAddress);
//                        Console.Write("Total Seats: ");
//                        int totalSeats = int.Parse(Console.ReadLine());
//                        Console.Write("Ticket Price: ");
//                        decimal ticketPrice = decimal.Parse(Console.ReadLine());
//                        Console.Write("Event Type (Movie/Concert/Sport): ");
//                        EventType eventType = Enum.Parse<EventType>(Console.ReadLine(), true);

//                        CreateEvent(eventName, eventDate, eventTime, totalSeats, ticketPrice, eventType);
//                        break;

//                    case "2":
//                        Console.Write("Enter event name to book tickets: ");
//                        string eventToBook = Console.ReadLine();
//                        Console.Write("Enter number of tickets to book: ");
//                        int numTicketsToBook = int.Parse(Console.ReadLine());

//                        Console.WriteLine("Enter customer details:");
//                        Console.Write("Customer Name: ");
//                        string customerName = Console.ReadLine();
//                        Console.Write("Email: ");
//                        string email = Console.ReadLine();
//                        Console.Write("Phone Number: ");
//                        string phoneNumber = Console.ReadLine();

//                        Customer[] customers = { new Customer(customerName, email, phoneNumber) };

//                        BookTickets(eventToBook, numTicketsToBook, customers);
//                        break;

//                    case "3":
//                        Console.Write("Enter booking ID to cancel: ");
//                        int bookingIdToCancel = int.Parse(Console.ReadLine());
//                        CancelBooking(bookingIdToCancel);
//                        break;

//                    case "4":
//                        Console.Write("Enter event name to get available seats: ");
//                        string eventToCheckSeats = Console.ReadLine();
//                        int availableSeats = GetAvailableNoOfTickets(eventToCheckSeats);

//                        if (availableSeats >= 0)
//                        {
//                            Console.WriteLine($"Available Seats for {eventToCheckSeats}: {availableSeats}");
//                        }
//                        else
//                        {
//                            Console.WriteLine($"Error: Event '{eventToCheckSeats}' not found.");
//                        }
//                        break;

//                    case "5":
//                        Console.Write("Enter event name to get details: ");
//                        string eventToGetDetails = Console.ReadLine();
//                        Event eventDetails = GetEventDetails(eventToGetDetails);

//                        if (eventDetails != null)
//                        {
//                            eventDetails.DisplayEventDetails();
//                        }
//                        else
//                        {
//                            Console.WriteLine($"Error: Event '{eventToGetDetails}' not found.");
//                        }
//                        break;

//                    case "6":
//                        Console.WriteLine("Exiting the Ticket Booking System. Goodbye!");
//                        return;

//                    default:
//                        Console.WriteLine("Invalid choice. Please enter a valid option.");
//                        break;
//                }
//            }


//        }
//    }
//}
