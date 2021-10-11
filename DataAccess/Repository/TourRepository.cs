using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataAccess;
namespace DataAccess.Repository
{
     public  class TourRepository: ITourRepository
    {
        public IEnumerable<TblTour> GetTours() => TourDAO.Instance.GetTourList();
        public TblTour GetTourByID(int TourID) => TourDAO.Instance.GetTourByID(TourID);
        public void InsertTour(TblTour tour) => TourDAO.Instance.AddNew(tour);
        public void DeleteTour(int TourId) => TourDAO.Instance.Remove(TourId);
        public void UpdateTour(TblTour tour) => TourDAO.Instance.Update(tour);
      

    }
}
