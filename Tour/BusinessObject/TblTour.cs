using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.DataAccess
{
    public partial class TblTour
    {
        public TblTour()
        {
            TblTrips = new HashSet<TblTrip>();
        }

        public int TourId { get; set; }
        public string TourName { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<TblTrip> TblTrips { get; set; }
    }
}
