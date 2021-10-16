using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BookingDAO
    {
        private static BookingDAO instance = null;
        private static readonly object instanceLock = new object();
        private BookingDAO() { }
        public static BookingDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BookingDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<TblBooking> GetBookingList()
        {
            var bookings = new List<TblBooking>();
            try
            {
                using var context = new TourContext();
                bookings = context.TblBookings.ToList();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            return bookings;
        }
        public TblBooking GetBookingByID(int bookingID)
        {
            TblBooking booking = null;
            try
            {
                using var context = new TourContext();
                booking = context.TblBookings.SingleOrDefault(c => c.BookingId == bookingID);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return booking;
        }

        public IEnumerable<TblBooking> GetBookingByCustomerID(int customerID)
        {
            var bookings = new List<TblBooking>();
            try
            {
                using var context = new TourContext();
                bookings = context.TblBookings.Where(c => c.CustomerId == customerID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bookings;
        }
        public IEnumerable<TblBooking> GetBookingByTripID(int tripId)
        {
            var bookings = new List<TblBooking>();
            try
            {
                using var context = new TourContext();
                bookings = context.TblBookings.Where(c => c.TripId == tripId).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bookings;
        }

        public void AddNew(TblBooking booking)
        {
            try
            {
                using var context = new TourContext();
                context.TblBookings.Add(booking);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(TblBooking booking)
        {
            try
            {
                TblBooking book = GetBookingByID(booking.BookingId);
                if (book != null)
                {
                    using var context = new TourContext();
                    context.TblBookings.Update(booking);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("This booking does not exist.");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Remove(int bookingID)
        {
            try
            {
                TblBooking booking = GetBookingByID(bookingID);
                if (booking != null)
                {
                    using var context = new TourContext();
                    context.TblBookings.Remove(booking);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("This booking does not exist.");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
