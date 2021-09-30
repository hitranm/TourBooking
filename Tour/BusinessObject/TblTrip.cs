using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.DataAccess
{
    public partial class TblTrip
    {
        public TblTrip()
        {
            TblBookings = new HashSet<TblBooking>();
        }

        public int TripId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime Endtime { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
        public string Accommodation { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public int TourId { get; set; }

        public virtual TblTour Tour { get; set; }
        public virtual ICollection<TblBooking> TblBookings { get; set; }
    }
}
