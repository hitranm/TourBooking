using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataAccess;
namespace DataAccess
{
    public class TripDAO
    {
        //Using Singleton Pattern
        private static TripDAO instance = null;
        private static readonly object instanceLock = new object();
        private TripDAO() { }
        public static TripDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new TripDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<TblTrip> GetTripList()
        {
            var trips = new List<TblTrip>();
            try
            {
                using var context = new TourContext();
                trips = context.TblTrips.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return trips;

        }

        public TblTrip GetTripByID(int TripID)
        {
            var trips = GetTripList();
            TblTrip trip = null;
            try
            {
                using var context = new TourContext();
                foreach (var c in trips)
                {
                    
                    trip = context.TblTrips.SingleOrDefault(c => c.TripId == TripID);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return trip;
        }
        public List<TblTrip> GetTripByTourID(int TourID)
        {
            var trip = new List<TblTrip>();
            var trips = GetTripList();
            try
            {
                foreach (var c in trips)
                {
                    if (c.TourId == TourID)
                    {
                        trip.Add(c);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return trip;
        }
        //-----------------------------------------------------------------
        //Add a new trip
        public void AddNew(TblTrip trip)
        {
            try
            {
                TblTrip tri = GetTripByID(trip.TripId);
                if (tri == null)
                {
                    using var context = new TourContext();
                    context.TblTrips.Add(trip);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The trip is already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //-----------------------------------------------------------------
        //Update a new trip
        public void Update(TblTrip trip)
        {
            try
            {
                TblTrip tri = GetTripByID(trip.TripId);
                if (tri != null)
                {
                    using var context = new TourContext();
                    context.TblTrips.Update(trip);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The trip does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //-----------------------------------------------------------------
        //Delete a trip
        public void Remove(int TripID)
        {
            try
            {
                TblTrip tri = GetTripByID(TripID);
                if (tri != null)
                {
                    using var context = new TourContext();                    
                    context.TblTrips.Remove(tri);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The trip does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
