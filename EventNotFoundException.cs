using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking.Exception
{
    internal class EventNotFoundException:ApplicationException
    {
            public EventNotFoundException(string message) : base(message)
            {
            }
        }
}
