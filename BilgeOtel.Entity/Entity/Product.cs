using BilgeOtel.Entity.Base;
using BilgeOtel.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeOtel.Entity.Entity
{
    public class Product:BaseEntity
    {
     
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public string Description { get; set; }
        public Amount? amount { get; set; }
        public Portion? portion { get; set; }
    }
}
