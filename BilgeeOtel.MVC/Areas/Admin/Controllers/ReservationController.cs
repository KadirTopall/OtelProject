using BilgeeOtel.MVC.Models.ViewModels;
using BilgeOtel.BLL.AbstractService;
using BilgeOtel.BLL.Service;
using BilgeOtel.Entity.Entity;
using Microsoft.AspNetCore.Mvc;

namespace BilgeeOtel.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReservationController : Controller
    {
        private readonly IReservationService reservationService;
        private readonly IRoomService roomService;

        public ReservationController(IReservationService reservationService, IRoomService roomService)
        {
            this.reservationService = reservationService;
            this.roomService = roomService;
        }

        public IActionResult Index()
        {
            var reservations = reservationService.GetAll().Where(x => x.ReservationStatus == BilgeOtel.Entity.Enum.ReservationStatus.Made).ToList();
            return View(reservations);
        }

        public IActionResult ReservationbyPhone()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ReservationbyPhone(ReservationVM reservation, Reservation reservation2)
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
            reservation2.Room = room1;
            reservationService.CreateReservation(reservation2);
            TempData["info"] = "Rezervasyon Oluşturuldu !";
            return View();
        }
    }


}
