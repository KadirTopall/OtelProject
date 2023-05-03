using BilgeOtel.Entity.Entity;

namespace BilgeeOtel.MVC.Areas.Admin.Models
{
    public class RentalVM
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Room room { get; set; }
    }
}
