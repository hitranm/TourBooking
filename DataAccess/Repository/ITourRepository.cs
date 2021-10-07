using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataAccess;
namespace DataAccess.Repository
{
    public interface ITourRepository
    {
        IEnumerable<TblTour> GetTours();
        TblTour GetTourByID(int TourID);
        void InsertTour(TblTour tour);
        void DeleteTour(int TourID);
        void UpdateTour(TblTour tour);
       
    }
}
