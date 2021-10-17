using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataAccess;
namespace DataAccess
{
   public class TourDAO
    {
        //Using Singleton Pattern
        private static TourDAO instance = null;
        private static readonly object instanceLock = new object();
        private TourDAO() { }
        public static TourDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new TourDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<TblTour> GetTourList()
        {
            var tours = new List<TblTour>();
            try
            {
                using var context = new TourContext();
                tours = context.TblTours.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return tours;

        }

        public TblTour GetTourByID(int TourID)
        {
            TblTour tour = null;
            try
            {
                using var context = new TourContext();
                tour = context.TblTours.SingleOrDefault(c => c.TourId == TourID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return tour;
        }

        //-----------------------------------------------------------------
        //Add a new tour
        public void AddNew(TblTour tour)
        {
            try
            {
                TblTour tou = GetTourByID(tour.TourId);
                if (tou == null)
                {
                    using var context = new TourContext();
                    context.TblTours.Add(tour);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The tour is already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //-----------------------------------------------------------------
        //Update a new tour
        public void Update(TblTour tour)
        {
            try
            {
                TblTour tou = GetTourByID(tour.TourId);
                if (tou != null)
                {
                    using var context = new TourContext();
                    context.TblTours.Update(tour);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The tour does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //-----------------------------------------------------------------
        //Delete a tour
        public void Remove(int TourID)
        {
            try
            {
                TblTour tou = GetTourByID(TourID);
                if (tou != null)
                {
                    using var context = new TourContext();
                    context.TblTours.Remove(tou);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The tour does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
