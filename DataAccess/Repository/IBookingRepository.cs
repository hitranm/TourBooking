using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IBookingRepository
    {
        IEnumerable<TblBooking> GetBookings();
        TblBooking GetBookingByID(int BookingID);
        void InsertBooking(TblBooking booking);
        void UpdateBooking(TblBooking booking);
        void DeleteBooking(int BookingID);
        IEnumerable<TblBooking> GetBookingsByCustomerId(int customerId);
        IEnumerable<TblBooking> GetBookingsByTripId(int tripId);
    }
}
