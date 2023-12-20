using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking.Exception
{
    internal class InvalidBookingIDException:ApplicationException
    {
        public InvalidBookingIDException(string message) : base(message)
        {
        }
    }
}
