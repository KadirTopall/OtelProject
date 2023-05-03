using BilgeOtel.BLL.AbstractService;
using BilgeOtel.Entity.Entity;
using Microsoft.AspNetCore.Mvc;

namespace BilgeeOtel.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RentUserController : Controller
    {

        private readonly IRentUserService rentUserService;
        public RentUserController(IRentUserService rentUserService)
        {
            this.rentUserService = rentUserService;
        }

        public IActionResult Index()
        {
            TempData["Title"] = "Müşteriler";
            var rentUsers = rentUserService.GetAll().ToList();
            return View(rentUsers);
        }
        public IActionResult CreateUser()
        {
            TempData["Title"] = "Müşteri Oluştur";
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(RentUser rentUser)
        {

            rentUserService.CreateRentUser(rentUser);
            return RedirectToAction("Index");
        }

    }
}
