using TicketBooking.Entity;
using TicketBooking.Repository;
using TicketBooking.Interface;

#region Task1

////1.write a program that takes the availableticket and noofbookingticket as input.
//int available_Tickets = 100;
//Console.WriteLine("Enter booking tickets::");
//int booking_Tickets = int.Parse(Console.ReadLine());
////2.use conditional statements(if-else) to determine if the ticket is available or not.
////3. display an appropriate message based on ticket availability.
//if(available_Tickets>booking_Tickets)
//{
//    Console.WriteLine($"Tickets are Available, Total Tickets Available are ::{available_Tickets}");
//}
//else
//{
//    Console.WriteLine("Tickets unavailable");
//}
#endregion


#region Task2
//int totalBill = 0;
//string options = @"
//                Press 1::'Silver'
//                Press 2::'Gold'
//                Press 3::'Diamond'";
//Boolean condition = true;
//while (condition)
//{
//    Console.WriteLine(options);
//    Console.WriteLine("Choose ticket type::");
//    int choice = int.Parse(Console.ReadLine());
//    Console.WriteLine("Enter number of tickets::");
//    int numberOfTickets = int.Parse(Console.ReadLine());

//    switch (choice)
//    {
//        case 1:
//            totalBill = totalBill + numberOfTickets * 50;
//            break;
//        case 2:
//            totalBill = totalBill + numberOfTickets * 100;
//            break;
//        case 3:
//            totalBill = totalBill + numberOfTickets * 200;
//            break;
//    }
//    Console.WriteLine("Do you want to continue Y or N?");
//    char c = char.Parse(Console.ReadLine());
//    if (c == 'N' || c=='n')
//    {
//        condition = false;
//    }
//}

//Console.WriteLine($"Total Bill::{totalBill}");
#endregion

#region Task1: Class & Object

//DateTime eventDate = new DateTime(2023, 12, 31);
//TimeSpan eventTime = new TimeSpan(20, 0, 0);

//Event eventObj = new Event("New Year's Eve Party", eventDate, eventTime, "Party Hall", 100, 20.0m, EventType.Concert);

//// Create Venue object
//Venue venue = new Venue("Party Hall", "123 Main Street, Cityville");

//// Create Customer object
//Customer customer = new Customer("John Doe", "john.doe@example.com", "123-456-7890");

//// Display Event details
//eventObj.DisplayEventDetails();

//// Display Venue details
//venue.DisplayVenueDetails();

//// Display Customer details
//customer.DisplayCustomerDetails();

//// Book tickets
//Booking booking = new Booking(eventObj);
//booking.BookTickets(5);

//// Cancel booking
//booking.CancelBooking(2);

//// Display updated Event details
//eventObj.DisplayEventDetails();

//// Display available tickets
//Console.WriteLine($"Available Tickets: {booking.GetAvailableNoOfTickets()}");

//// Display event details from Booking class
//Console.WriteLine(booking.GetEventDetails());

#endregion

#region Task 2: Inheritance and polymorphism

//TicketBookingSystem bookingSystem = new TicketBookingSystem();

//Event movieEvent = bookingSystem.CreateEvent("Movie Night", DateTime.Parse("2023-01-15"), TimeSpan.Parse("19:00"), 100, 10.50m, EventType.Movie, "Cinema Hall");
//bookingSystem.DisplayEventDetails(movieEvent);

//Event concertEvent = bookingSystem.CreateEvent("Rock Concert", DateTime.Parse("2023-02-20"), TimeSpan.Parse("20:00"), 200, 20.00m, EventType.Concert, "Music Arena");
//bookingSystem.DisplayEventDetails(concertEvent);

//Event sportsEvent = bookingSystem.CreateEvent("Football Match", DateTime.Parse("2023-03-10"), TimeSpan.Parse("15:30"), 150, 15.00m, EventType.Sports, "Stadium");
//bookingSystem.DisplayEventDetails(sportsEvent);

//bookingSystem.BookTickets(movieEvent, 5);
//bookingSystem.CancelTickets(concertEvent, 2);

//Console.WriteLine($"Available Tickets for Concert: {bookingSystem.GetAvailableNoOfTickets(concertEvent)}");


#endregion

#region  Task 3: Abstraction
//TicketBookingSystemImpl ticketBookingSystem = new TicketBookingSystemImpl();
//ticketBookingSystem.Main();
#endregion

#region Task 4: Has A Relation / Association

//BookingSystem ticketBookingSystem = new BookingSystem();
//ticketBookingSystem.Main();
#endregion

#region Task 5: Interface, and Single Inheritance, static variable
//IBookingSystemServiceProvider bookingSystemServiceProvider = new BookingSystemServiceProviderRepository();
//TicketBookingSystem ticketBookingSystem = new TicketBookingSystem(bookingSystemServiceProvider);
//ticketBookingSystem.Main();
#endregion

#region Task 6: Exception Handling

//Created 3 exceptions and handled it
#endregion

#region Task 7: Collection
//created List<T>,HashSet<T>,Dictionary<K, V>

#endregion

#region Task 8: JDBC
Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("                                                  WELCOME TO                                                          ");
Console.WriteLine("                                        SWATHI's Ticket Booking System                                    ");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
Console.ReadKey();
Console.Clear();
Label:
string menu = @"
               Press1::'create_event' 
               Press2::'get_event_details'
               Press3::'cancel_tickets'
               Press4::'get_available_seats'
               Press5::'Exit'";
Console.WriteLine(menu);
Console.WriteLine("Enter Your Choice::");
int choice = int.Parse(Console.ReadLine());
Console.Clear();
switch (choice)
{
    case 1://Create_Event
        IBookingSystemServiceProvider bookingSystemServiceProviderRepository = new BookingSystemServiceProviderRepository();
        Console.WriteLine("To Register Customer");
        Console.WriteLine("Enter the EventID:");
        int ei = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Event Name:");
        string FN = Console.ReadLine();
        Console.WriteLine("Enter the VenueID:");
        int vi = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Total Seats:");
        int ts = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the ticketprice:");
        decimal tp = decimal.Parse(Console.ReadLine());
        Event events = new Event
        {
            event_id = ei,
            EventName = FN,
            VenueID = vi,
            TotalSeats=ts,
            TicketPrice=tp
        };
        bookingSystemServiceProviderRepository.CreateEvent(events);
        Console.ReadKey();
        Console.Clear();
        goto Label;

    case 2: //GetAllEvent
        IBookingSystemServiceProvider bookingSystemServiceProviderRepository1 = new BookingSystemServiceProviderRepository();
        List<Event> allevents = bookingSystemServiceProviderRepository1.getEventDetails();
        foreach (var item in allevents)
        {
            Console.WriteLine(item);
            Console.ReadKey();
            Console.Clear();
            goto Label;
        }
        break;

    case 3:
        IBookingSystemServiceProvider bookingSystemServiceProviderRepository3 = new BookingSystemServiceProviderRepository();
        Console.WriteLine("Enter Event ID to be deleted:");
        int event_id = int.Parse(Console.ReadLine());
        bookingSystemServiceProviderRepository3.cancel_tickets(event_id);
        Console.ReadKey();
        Console.Clear();
        goto Label;
        break;

    case 4:
        IBookingSystemServiceProvider bookingSystemServiceProviderRepository2 = new BookingSystemServiceProviderRepository();
        List<Event> availableEvents = bookingSystemServiceProviderRepository2.get_available_seats();
        foreach (var item in availableEvents)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
        Console.Clear();
        goto Label;
    case 5:
        Environment.Exit(0);
        break;

    default:
        Console.ReadKey();
        Console.Clear();
        goto Label;
}   


#endregion