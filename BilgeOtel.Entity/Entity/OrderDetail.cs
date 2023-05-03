using BilgeOtel.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeOtel.Entity.Entity
{
    public class OrderDetail : BaseEntity
    {
        public OrderDetail()
        {
            Quantity = 1;
        }
        public Order Order { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public Product product { get; set; }
    }
}
