using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Entity;

namespace TicketBooking.Interface
{ 
        internal interface IEventServiceProvider
        {
            Event CreateEvent(string eventName, DateTime eventDate, TimeSpan eventTime, int totalSeats, decimal ticketPrice, EventType eventType, Venue venue);
            Event[] GetEventDetails();
            int GetAvailableNoOfTickets(string eventName);
        }
}
