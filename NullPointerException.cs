using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking.Exception
{
    internal class NullPointerException:ApplicationException
    {
        public NullPointerException(string message) : base(message)
        {
        }
    }
}
