using BilgeOtel.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeOtel.Entity.Entity
{
    public class RentUser : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNumber { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<Rental> Rentals { get; set; }
    }
}
