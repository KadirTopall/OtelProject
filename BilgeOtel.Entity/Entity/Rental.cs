using BilgeOtel.Entity.Base;
using BilgeOtel.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeOtel.Entity.Entity
{
    public class Rental : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double TotalRentPrice { get; set; }
        public Package package { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int RoomId1 { get; set; }

        public virtual Room Room { get; set; }
        public int ReservationId { get; set; }

        public virtual Reservation Reservation { get; set; }
        public List<RentUser> RentUsers { get; set; }
    }
}
