using BilgeOtel.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeOtel.BLL.AbstractService
{
    public interface IProductService
    {
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        Product GetProduct(int id);
        IEnumerable<Product> GetAll();
    }
}
