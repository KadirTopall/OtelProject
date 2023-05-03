using BilgeOtel.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeOtel.Entity.Entity
{
    public class Order : BaseEntity
    {
  
        public List<OrderDetail> OrderDetail { get; set; }
        public double TotalPrice { get; set; }
    }
}
