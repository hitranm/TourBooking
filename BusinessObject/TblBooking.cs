using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.DataAccess
{
    public partial class TblBooking
    {
        public int BookingId { get; set; }
        public int TripId { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public int NoOfPeople { get; set; }
        public decimal TotalPrice { get; set; }
        public bool Status { get; set; }
        public DateTime BookingDate { get; set; }

        public virtual TblCustomer Customer { get; set; }
        public virtual TblTrip Trip { get; set; }
        public virtual TblUser User { get; set; }
    }
}
