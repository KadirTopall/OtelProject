using BilgeOtel.Entity.Entity;
using BilgeOtel.Entity.Enum;

namespace BilgeeOtel.MVC.Models.ViewModels
{
    public class ReservationVM
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public UserQuantity UserQuantity { get; set; }
        public Room Room { get; set; }
    }
}
