using BilgeOtel.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeOtel.BLL.AbstractService
{
    public interface IRentalService
    {
        //Create
        void CreateRental(Rental rental);
        //Delete
        void RemoveRental(Rental rental);
        //Update
        void UpdateRental(Rental rental);
        //Get
        Rental Get(int id);
        IEnumerable<Rental> GetAllRentals();
    }
}

