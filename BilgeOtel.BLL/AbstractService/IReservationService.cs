using BilgeOtel.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeOtel.BLL.AbstractService
{
    public interface IReservationService
    {
        //Create
        void CreateReservation(Reservation reservation);
        //Delete
        void RemoveReservation(Reservation reservation);
        //Update
        void UpdateReservation(Reservation reservation);
        //Get

        Reservation Get(int id);
        IEnumerable<Reservation> GetAll();
    }
}