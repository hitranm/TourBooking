using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class BookingRepository:IBookingRepository
    {
        public IEnumerable<TblBooking> GetBookings() => BookingDAO.Instance.GetBookingList();
        public TblBooking GetBookingByID(int bookingID) => BookingDAO.Instance.GetBookingByID(bookingID);
        public void InsertBooking(TblBooking booking) => BookingDAO.Instance.AddNew(booking);
        public void UpdateBooking(TblBooking booking) => BookingDAO.Instance.Update(booking);
        public void DeleteBooking(int bookingID) => BookingDAO.Instance.Remove(bookingID);
        public IEnumerable<TblBooking> GetBookingsByCustomerId(int customerId) => BookingDAO.Instance.GetBookingByCustomerID(customerId);
        public IEnumerable<TblBooking> GetBookingsByTripId(int tripId) => BookingDAO.Instance.GetBookingByTripID(tripId);
    }
}
