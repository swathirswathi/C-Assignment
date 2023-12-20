using CarConnect.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Entity;
using TicketBooking.Exception;
using TicketBooking.Interface;


namespace TicketBooking.Repository
{
    internal class BookingSystemServiceProviderRepository : IBookingSystemServiceProvider
    {
        #region othercodes
        //private List<Booking> bookings = new List<Booking>();
        //private object events;

        //public void CalculateBookingCost(Booking booking)
        //{
        //    booking.TotalCost = booking.Event.TicketPrice * booking.NumTickets;
        //}

        //public void BookTickets(string eventName, int numTickets, Customer[] customers)
        //{
        //    Event eventToBook = events.Find(e => e.EventName == eventName);
        //    try
        //    {
        //        if (eventToBook != null)
        //        {
        //            eventToBook.BookTickets(numTickets);

        //            Booking newBooking = new Booking(customers, eventToBook, numTickets);
        //            bookings.Add(newBooking);

        //            Console.WriteLine($"Booking successful! Booking ID: {newBooking.BookingId}");
        //        }

        //    }
        //    catch(EventNotFoundException ex)
        //    {
        //        throw new EventNotFoundException($"Error: Event: {eventName} not found.");
        //    }
        //}

        //public void CancelBooking(int bookingId)
        //{
        //    Booking bookingToCancel = bookings.Find(b => b.BookingId == bookingId);
        //    try
        //    {

        //        if (bookingToCancel != null)
        //        {
        //            bookingToCancel.Event.CancelBooking(bookingToCancel.NumTickets);
        //            bookings.Remove(bookingToCancel);

        //            Console.WriteLine($"Booking canceled successfully. Booking ID: {bookingToCancel.BookingId}");
        //        }

        //    }
        //    catch(InvalidBookingIDException)
        //    {
        //        throw new InvalidBookingIDException($"Error: Booking with ID {bookingId} not found.");
        //    }
        //}

        //public Booking GetBookingDetails(int bookingId)
        //{
        //    return bookings.Find(b => b.BookingId == bookingId);
        //}
        #endregion

        public string connectionString;
        SqlCommand cmd = null;
        public BookingSystemServiceProviderRepository()
        {
            connectionString = DbConnUtil.GetConnectionString();
            cmd = new SqlCommand();
        }
        public void CreateEvent(Event events)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                cmd.CommandText = "INSERT INTO Events (event_id,event_name,event_date, event_time,venue_id,total_seats, ticket_price, event_type) " +
                           "VALUES (@id,@EventName, @Date, @Time,@venue_id, @TotalSeats, @TicketPrice, @EventType);";
                cmd.Parameters.AddWithValue("@id", events.event_id);
                cmd.Parameters.AddWithValue("@EventName", events.EventName);
                cmd.Parameters.AddWithValue("@Date", events.EventDate);
                cmd.Parameters.AddWithValue("@Time", events.EventTime);
                cmd.Parameters.AddWithValue("@venue_id", events.VenueID);
                cmd.Parameters.AddWithValue("@TotalSeats", events.TotalSeats);
                cmd.Parameters.AddWithValue("@TicketPrice", events.TicketPrice);
                cmd.Parameters.AddWithValue("@EventType", events.EventType);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                int createEventStatus;
                try
                {
                    createEventStatus = cmd.ExecuteNonQuery();
                    Console.WriteLine(createEventStatus);
                    Console.WriteLine("Event Added Successfully");
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("duplicate key value"))
                    {
                        Console.WriteLine($"Username already exists");
                    }

                }
            }
        }

        public List<Event> getEventDetails()
           {
               List<Event> events = new List<Event>();
               try
               {
                   using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                   {
                       cmd.CommandText = "select * from Event";
                       cmd.Connection = sqlConnection;
                       sqlConnection.Open();
                       SqlDataReader reader = cmd.ExecuteReader();
                       while (reader.Read())
                       {
                           Event eventss = new Event();
                           eventss.event_id = (int) reader["event_id"];
                           eventss.EventName = (string) reader["Event_name"];
                           eventss.EventDate = (DateTime) reader["Event_Date"];
                           eventss.EventTime = (TimeSpan) reader["Event_Time"];
                           eventss.VenueID = (int) reader["Venue_ID"];
                           eventss.TotalSeats = (int) reader["total_seats"];
                           eventss.TicketPrice = (decimal) reader["Ticket_Price"];
                           events.Add(eventss);
                       }
                   }
               }
               catch (EventNotFoundException nodataex)
               {
                   Console.WriteLine("No data found");
               }
               return events;
           }
        public List<Event> get_available_seats()
        {
            List<Event> events = new List<Event>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    cmd.CommandText = "select * from Event WHERE available_seats>0";
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Event eventss = new Event();
                        eventss.event_id = (int)reader["event_id"];
                        eventss.EventName = (string)reader["Event_name"];
                        eventss.EventDate = (DateTime)reader["Event_Date"];
                        eventss.EventTime = (TimeSpan)reader["Event_Time"];
                        eventss.VenueID = (int)reader["Venue_ID"];
                        eventss.TotalSeats = (int)reader["total_seats"];
                        eventss.TicketPrice = (decimal)reader["Ticket_Price"];
                        events.Add(eventss);
                    }
                }
            }
            catch (EventNotFoundException nodataex)
            {
                Console.WriteLine("No data found");
            }

            return events;
        }
        public int cancel_tickets(int e_id)
        {
            try
            {
                cmd.Parameters.Clear();
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    cmd.CommandText = "delete from Booking where Event_ID=@event_id";
                    cmd.Parameters.AddWithValue("@event_id", e_id);
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    int deleteCustomerStatus = cmd.ExecuteNonQuery();
                    cmd.CommandText = "delete from Event where Event_ID=@eventt_id";
                    cmd.Parameters.AddWithValue("@eventt_id", e_id);
                    int deleteCustomeStatus = cmd.ExecuteNonQuery(); 
                    return deleteCustomeStatus;
                }
            }
            catch (EventNotFoundException e)
            {
                Console.WriteLine($"Error :{e.Message}");
                return -1;
            }
        }


    }
}