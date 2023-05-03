using BilgeOtel.BLL.AbstractService;
using BilgeOtel.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace BilgeeOtel.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoomController : Controller
    {
        private readonly IRoomService roomService;
        private readonly ProjectContext projectContext;

        public RoomController(IRoomService roomService, ProjectContext projectContext)
        {
            this.roomService = roomService;
            this.projectContext = projectContext;
        }

        public IActionResult Index()
        {
            TempData["Title"] = "Odalar";
            var rooms = roomService.GetAll().ToList();
            return View(rooms);
        }
    }
}
