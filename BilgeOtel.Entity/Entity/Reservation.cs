using BilgeOtel.Entity.Base;
using BilgeOtel.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeOtel.Entity.Entity
{
    public class Reservation : BaseEntity
    {
        public DateTime ReservationDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public UserQuantity UserQuantity { get; set; }
        public int ReservationOwnerId { get; set; }
        public AppUser ReservationOwner { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }

    }
}
