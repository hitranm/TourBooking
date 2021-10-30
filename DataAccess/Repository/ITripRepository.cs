using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataAccess;
namespace DataAccess.Repository
{
    public interface ITripRepository
    {
        IEnumerable<TblTrip> GetTrips();
        TblTrip GetTripByID(int TripID);
        List<TblTrip> GetTripByTourID(int TourID);
        void InsertTrip(TblTrip trip);
        void DeleteTrip(int TripID);
        void UpdateTrip(TblTrip trip);
    }
}