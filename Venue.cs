using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking.Entity
{
    internal class Venue
    {
        public string VenueName { get; set; }
        public string Address { get; set; }

        public Venue(string venueName, string address)
        {
            VenueName = venueName;
            Address = address;
        }

        public void DisplayVenueDetails()
        {
            Console.WriteLine($"Venue Name: {VenueName},Address: {Address}");
          
        }
    }
}
