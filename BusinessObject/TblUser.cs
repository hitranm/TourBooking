using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.DataAccess
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblBookings = new HashSet<TblBooking>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNo { get; set; }
        public DateTime Dob { get; set; }
        public bool Sex { get; set; }
        public bool Status { get; set; }
        public int RoleId { get; set; }

        public virtual TblRole Role { get; set; }
        public virtual ICollection<TblBooking> TblBookings { get; set; }
    }
}
