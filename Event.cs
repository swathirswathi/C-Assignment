using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking.Entity
{
   // public abstract class Event
    public class Event
    {
        internal object event_name;
        public int event_id{ get; set; }
        public int VenueID{ get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public TimeSpan EventTime { get; set; }
        public string VenueName { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public decimal TicketPrice { get; set; }
        public EventType EventType { get; set; }
        public int BookedTickets { get; set; }
        //public abstract void DisplayEventDetails();
        //public Event(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName,
        //        int totalSeats, decimal ticketPrice, EventType eventType)
        //{
        //    EventName = eventName;
        //    EventDate = eventDate;
        //    EventTime = eventTime;
        //    VenueName = venueName;
        //    TotalSeats = totalSeats;
        //    AvailableSeats = totalSeats;
        //    TicketPrice = ticketPrice;
        //    EventType = eventType;
        //    BookedTickets = 0;
        //}

        //public decimal CalculateTotalRevenue()
        //{
        //    return (TotalSeats - AvailableSeats) * TicketPrice;
        //}

        //public int GetBookedNoOfTickets()
        //{
        //    return TotalSeats - AvailableSeats;
        //}

        //public bool BookTickets(int numTickets)
        //{
        //    if (numTickets > 0 && numTickets <= AvailableSeats)
        //    {
        //        BookedTickets += numTickets;
        //        AvailableSeats -= numTickets;
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid number of tickets or not enough available seats.");
        //        return false;
        //    }
        //}

        //public bool CancelBooking(int numTickets)
        //{
        //    if (numTickets > 0 && numTickets <= BookedTickets)
        //    {
        //        BookedTickets -= numTickets;
        //        AvailableSeats += numTickets;
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid number of tickets to cancel or no booking available.");
        //        return false;
        //    }
        //}

        //public static implicit operator Event(Event v)
        //{
        //    throw new NotImplementedException();
        //}

        //public void DisplayEventDetails()
        //{
        //    Console.WriteLine($"Event Name: {EventName},Date: {EventDate.ToShortDateString()},Time: {EventTime.ToString(@"hh\:mm")},Venue: {VenueName},Total Seats: {TotalSeats},Available Seats: {AvailableSeats},Ticket Price: {TicketPrice},Event Type: {EventType}");

        //}
    }
}

