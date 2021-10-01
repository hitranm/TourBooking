using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.DataAccess
{
    public partial class TblCustomer
    {
        public TblCustomer()
        {
            TblBookings = new HashSet<TblBooking>();
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public DateTime Dob { get; set; }
        public bool Sex { get; set; }

        public virtual ICollection<TblBooking> TblBookings { get; set; }
    }
}
