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
        [MaxLength(50,ErrorMessage = "Max Length of Tour Name is 50")]
        [MinLength(5,ErrorMessage = " Min Length of Tour Name is 5")]
        public string TourName { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage = "Max Length of Departure Name is 50")]
        [MinLength(5, ErrorMessage = " Min Length of Departure Name is 5")]
        public string Departure { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Max Length of Destination Name is 50")]
        [MinLength(5, ErrorMessage = " Min Length of Destination Name is 5")]
        public string Destination { get; set; }
        [Required]
        //[MaxLength(100, ErrorMessage = "Max Length of Description is 100")]
        public string Description { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<TblTrip> TblTrips { get; set; }
    }
}
