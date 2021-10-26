using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public string TourName { get; set; }
        [Required]
        public string Departure { get; set; }
        [Required]
        public string Destination { get; set; }
        [Required]
        public string Description { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<TblTrip> TblTrips { get; set; }
    }
}
