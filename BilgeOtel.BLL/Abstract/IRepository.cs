using BilgeOtel.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeOtel.BLL.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        //Create
        void Insert(T entity);
        //Delete
        void Remove(T entity);
        //Update
        void Update(T entity);
        //Get
        T Get(int id);
        string SaveChanges();
    }
}
