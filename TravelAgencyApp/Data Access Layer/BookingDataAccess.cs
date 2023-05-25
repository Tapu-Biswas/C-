using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyApp.Data_Access_Layer
{
    class BookingDataAccess : DataAccess
    {
        public List<Booking> GetAllBookings()
        {
            string sql = "SELECT * FROM Bookings";
            SqlDataReader reader = this.GetData(sql);
            List<Booking> bookings = new List<Booking>();
            while (reader.Read())
            {
                Booking booking = new Booking();
                booking.BookingOrderId = (int)reader["BookingOrderId"];
                booking.CustomerId = (int)reader["CustomerId"];
                booking.Date = reader["Date"].ToString();
                booking.Country = reader["Country"].ToString();
                booking.Flight = reader["Flight"].ToString();
                booking.Hotel = reader["Hotel"].ToString();
                booking.DesirablePlace = reader["DesirablePlace"].ToString();
                booking.TourRide = reader["TourRide"].ToString();
                booking.Person = reader["Person"].ToString();
                booking.TotalCost = reader["TotalCost"].ToString();
                booking.PayOption = reader["PayOption"].ToString();
                booking.Status = reader["Status"].ToString();
                bookings.Add(booking);
            }
            return bookings;
        }

        public List<Booking> GetBookingDetailsById(int bookingId)
        {
            string sql = "SELECT * FROM Bookings WHERE BookingOrderId=" + bookingId;
            SqlDataReader reader = this.GetData(sql);
            List<Booking> bookings = new List<Booking>();
            while (reader.Read())
            {
                Booking booking = new Booking();
                booking.BookingOrderId = (int)reader["BookingOrderId"];
                booking.CustomerId = (int)reader["CustomerId"];
                booking.Date = reader["Date"].ToString();
                booking.Country = reader["Country"].ToString();
                booking.Flight = reader["Flight"].ToString();
                booking.Hotel = reader["Hotel"].ToString();
                booking.DesirablePlace = reader["DesirablePlace"].ToString();
                booking.TourRide = reader["TourRide"].ToString();
                booking.Person = reader["Person"].ToString();
                booking.TotalCost = reader["TotalCost"].ToString();
                booking.PayOption = reader["PayOption"].ToString();
                booking.Status = reader["Status"].ToString();
                bookings.Add(booking);
            }
            return bookings;
        }

        public bool DeleteBooking(int bookingId)
        {
            string sql = "DELETE FROM Bookings WHERE BookingOrderId=" + bookingId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public bool AddBooking(Booking booking)
        {
            string sql = "INSERT INTO Bookings(CustomerId,Date,Country,Flight,Hotel,DesirablePlace,TourRide,Person,TotalCost,PayOption,Status) VALUES(" + booking.CustomerId + ",'" + booking.Date + "','" + booking.Country + "','" + booking.Flight + "','" + booking.Hotel + "','" + booking.DesirablePlace + "','" + booking.TourRide + "','" + booking.Person + "','" + booking.TotalCost + "','" + booking.PayOption + "','" + booking.Status + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateBooking(int bookindId,int customerId, string bookingDate, string bookingCountry, string bookingFlight, string bookingHotel, string bookingDesirablePlace, string bookingTouRide, string bookingPerson, string bookingTotalCost, string bookingPayOption, string bookingStatus)
        {
            string sql = "UPDATE Bookings SET CustomerId=" + customerId + ",Date= '" + bookingDate + "',Country= '" + bookingCountry + "',Flight= '" + bookingFlight + "',Hotel= '" + bookingHotel + "',DesirablePlace= '" + bookingDesirablePlace + "',TourRide= '" + bookingTouRide + "',Person= '" + bookingPerson + "',TotalCost= '" + bookingTotalCost + "',PayOption= '" + bookingPayOption + "',Status= '" + bookingStatus + "' WHERE CustomerId=" + customerId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

    }
}
