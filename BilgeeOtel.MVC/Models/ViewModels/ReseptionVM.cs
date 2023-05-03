using BilgeOtel.Entity.Entity;

namespace BilgeeOtel.MVC.Models.ViewModels
{
    public class ReseptionVM
    {
        public IEnumerable<Rental> Rentals { get; set; }
        public IEnumerable<RentUser> Users { get; set; }

    }
}
