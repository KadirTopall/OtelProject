using BilgeOtel.Entity.Base;
using BilgeOtel.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeOtel.Entity.Entity
{
    public class Room : BaseEntity
    {
        public int RoomNumber { get; set; }
        public bool EmptyOrNot { get; set; }
        public Floor Floor { get; set; }
        public UserQuantity UserQuantity { get; set; }
        public BedType BedType { get; set; }
        public double Price { get; set; }
        public List<Reservation> Reservation { get; set; }
        public List<Rental> Rentals { get; set; }
    }
}
