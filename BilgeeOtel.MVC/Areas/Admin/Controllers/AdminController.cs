using Microsoft.AspNetCore.Mvc;

namespace Project.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
