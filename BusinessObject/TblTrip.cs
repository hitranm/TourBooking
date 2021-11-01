using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Max Length of Accommodation is 50 characters")]
        public string Accommodation { get; set; }
        [Required]
        public string Description { get; set; }
        public bool Status { get; set; }
        public int TourId { get; set; }
        public virtual TblTour Tour { get; set; }
        public virtual ICollection<TblBooking> TblBookings { get; set; }
    }
}
