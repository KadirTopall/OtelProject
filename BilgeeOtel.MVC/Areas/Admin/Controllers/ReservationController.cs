using BilgeOtel.BLL.AbstractService;
using Microsoft.AspNetCore.Mvc;

namespace BilgeeOtel.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReservationController : Controller
    {
        private readonly IReservationService reservationService;
        public ReservationController(IReservationService reservationService)
        {
            this.reservationService = reservationService;
        }

        public IActionResult Index()
        {
            var reservations = reservationService.GetAll().Where(x => x.ReservationStatus == BilgeOtel.Entity.Enum.ReservationStatus.Made).ToList();
            return View(reservations);
        }
    }
}