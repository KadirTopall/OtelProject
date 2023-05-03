using BilgeOtel.BLL.AbstractService;
using BilgeOtel.Entity.Entity;
using BilgeeOtel.MVC.Models;
using BilgeeOtel.MVC.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BilgeotelMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRoomService roomService;
        private readonly IReservationService reservationService;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
       
        public HomeController(ILogger<HomeController> logger, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IRoomService roomService, IReservationService reservationService)
        {
            _logger = logger;
            this.signInManager = signInManager;
            this.roomService = roomService;
            this.reservationService = reservationService;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CreateReservation()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateReservation(ReservationVM reservation, Reservation reservation2)
        {
            short Ok = 0;
            Room room1 = null;
            List<Reservation> reservations = reservationService.GetAll().ToList();
            var oneperson = roomService.GetAll().Where(x => x.UserQuantity == BilgeOtel.Entity.Enum.UserQuantity.One);
            var twoperson = roomService.GetAll().Where(x => x.UserQuantity == BilgeOtel.Entity.Enum.UserQuantity.Two);
            var threeperson = roomService.GetAll().Where(x => x.UserQuantity == BilgeOtel.Entity.Enum.UserQuantity.Three);
            var fourperson = roomService.GetAll().Where(x => x.UserQuantity == BilgeOtel.Entity.Enum.UserQuantity.Four);

            while (Ok == 0)
            {
                foreach (Reservation reservation1 in reservations)
                {
                    switch (reservation.UserQuantity)
                    {
                        case BilgeOtel.Entity.Enum.UserQuantity.One:
                            {
                                foreach (var room in oneperson)
                                {
                                    if (reservation.StartDate >= reservation1.StartDate && reservation.StartDate < reservation1.EndDate)
                                    {
                                        if (reservation1.Room == room)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Ok = 1;
                                            room1 = room;
                                            break;
                                        }
                                    }
                                    else if (reservation1.Room != room)
                                    {
                                        Ok = 1;
                                        room1 = room;
                                        break;
                                    }
                                }
                            }
                            break;
                        case BilgeOtel.Entity.Enum.UserQuantity.Two:
                            {
                                foreach (var room in twoperson)
                                {
                                    if (reservation.StartDate >= reservation1.StartDate && reservation.StartDate < reservation1.EndDate)
                                    {
                                        if (reservation1.Room == room)
                                        {
                                            continue;
                                        }
                                        else if (reservation1.Room == room)
                                        {
                                            Ok = 1;
                                            room1 = room;
                                            break;
                                        }
                                    }
                                    else if (reservation1.Room != room)
                                    {
                                        Ok = 1;
                                        room1 = room;
                                        break;
                                    }
                                }
                            }
                            break;
                        case BilgeOtel.Entity.Enum.UserQuantity.Three:
                            {
                                foreach (var room in threeperson)
                                {
                                    if (reservation.StartDate >= reservation1.StartDate && reservation.StartDate < reservation1.EndDate)
                                    {
                                        if (reservation1.Room == room)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Ok = 1;
                                            room1 = room;
                                            break;
                                        }
                                    }
                                    else if (reservation1.Room != room)
                                    {
                                        Ok = 1;
                                        room1 = room;
                                        break;
                                    }
                                }
                            }
                            break;
                        case BilgeOtel.Entity.Enum.UserQuantity.Four:
                            {
                                foreach (var room in fourperson)
                                {
                                    if (reservation.StartDate >= reservation1.StartDate && reservation.StartDate < reservation1.EndDate)
                                    {
                                        if (reservation1.Room == room)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Ok = 1;
                                            room1 = room;
                                            break;
                                        }
                                    }
                                    else if (reservation1.Room != room)
                                    {
                                        Ok = 1;
                                        room1 = room;
                                        break;
                                    }
                                }
                            }
                            break;
                    }
                }
                TempData["info"] = "Aradığınız Şartlarda Oda Bulunamadı";
            }
            reservation.StartDate = reservation2.StartDate;
            reservation.EndDate = reservation2.EndDate;
            reservation.UserQuantity = reservation2.UserQuantity;
            reservation2.Room = room1;
            var user = await userManager.GetUserAsync(User);
            reservation2.ReservationOwner = user;
            reservationService.CreateReservation(reservation2);
            TempData["info"] = "Rezervasyon Oluşturuldu !";
            return View();
        }
    }


}
