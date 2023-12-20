using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Entity;

namespace TicketBooking.Interface
{
    internal interface IBookingSystemServiceProvider
    {
        //void CalculateBookingCost(Booking booking);
        //void BookTickets(string eventName, int numTickets, Customer[] customers);
        //Booking GetBookingDetails(int bookingId);
        List<Event> getEventDetails();
        //Event CreateEvent(string eventName, string date, string time, int totalSeats, float ticketPrice, string eventType, Venue venue);
        void CreateEvent(Event events);
        List<Event> get_available_seats();
        int cancel_tickets(int e_id);
    }
}
