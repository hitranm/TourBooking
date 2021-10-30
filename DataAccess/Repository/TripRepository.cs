using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataAccess;
namespace DataAccess.Repository
{
    public class TripRepository:ITripRepository
    {
        public List<TblTrip> GetTripByTourID(int TourID) => TripDAO.Instance.GetTripByTourID(TourID);
        public IEnumerable<TblTrip> GetTrips() => TripDAO.Instance.GetTripList();
        public TblTrip GetTripByID(int TripID) => TripDAO.Instance.GetTripByID(TripID);
        public void InsertTrip(TblTrip trip) => TripDAO.Instance.AddNew(trip);
        public void DeleteTrip(int TripId) => TripDAO.Instance.Remove(TripId);
        public void UpdateTrip(TblTrip trip) => TripDAO.Instance.Update(trip);

    }
}
