using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking.Entity
{
    internal class Booking
    {
        //private Event _event;
        private static int nextBookingId = 1;

        public int BookingId { get; }
        //public Customer[] Customers { get; set; }

        //List<T>
        //public List<Customer> customers { get; set; }

        //HashSet<T>
        //public HashSet<Customer> customers { get; set; }

        //Dictionary<K, V>
        //public Dictionary<int, Customer> customers { get; set; } 

        public Event Event { get; set; }
        public int NumTickets { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime BookingDate { get; }
        public Booking()
        {
            BookingId = nextBookingId++;
            BookingDate = DateTime.Now;
        }
        // public Booking(Customer[] customers, Event @event, int numTickets)
        //: this()
        // {
        //     Customers = customers;
        //     Event = @event;
        //     NumTickets = numTickets;
        //     TotalCost = Event.TicketPrice * numTickets;
        // }

        //    public Booking(List<Customer> customers, Event @event, int numTickets)
        //  : this()
        //    {
        //        this.customers = customers;
        //        Event = @event;
        //        NumTickets = numTickets;
        //        TotalCost = Event.TicketPrice * numTickets;
        //    }

        //    public void DisplayBookingDetails()
        //    {
        //        Console.WriteLine($"Booking ID: {BookingId}");
        //        Console.WriteLine("Customers:");
        //        foreach (var customer in customers)
        //        {
        //            customer.DisplayCustomerDetails();
        //        }
        //        Console.WriteLine("Event Details:");
        //        Event.DisplayEventDetails();
        //        Console.WriteLine($"Number of Tickets: {NumTickets}");
        //        Console.WriteLine($"Total Cost: {TotalCost:C}");
        //        Console.WriteLine($"Booking Date: {BookingDate}");
        //    }
        //}


        //public Booking(Event ev)
        //{
        //    _event = ev;
        //    TotalCost = 0;
        //}

        //public decimal TotalCost { get; private set; }

        //public void CalculateBookingCost(int numTickets)
        //{
        //    TotalCost = numTickets * _event.TicketPrice;
        //}

        //public bool BookTickets(int numTickets)
        //{
        //    if (_event.BookTickets(numTickets))
        //    {
        //        CalculateBookingCost(numTickets);
        //        Console.WriteLine($"Tickets booked successfully. Total Cost: {TotalCost}");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ticket booking failed.");
        //        return false;
        //    }
        //}

        //public bool CancelBooking(int numTickets)
        //{
        //    if (_event.CancelBooking(numTickets))
        //    {
        //        Console.WriteLine($"Tickets canceled successfully. Available seats: {_event.AvailableSeats}");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ticket cancellation failed.");
        //        return false;
        //    }
        //}

        //public int GetAvailableNoOfTickets()
        //{
        //    return _event.AvailableSeats;
        //}

        //public string GetEventDetails()
        //{
        //    return $"Event Name: {_event.EventName}, Date: {_event.EventDate}, Time: {_event.EventTime}";
        //}
    }
}

