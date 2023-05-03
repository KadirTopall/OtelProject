using BilgeOtel.BLL.Abstract;
using BilgeOtel.BLL.AbstractService;
using BilgeOtel.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeOtel.BLL.Service
{
    public class RentUserService : IRentUserService
    {
        private readonly IRepository<RentUser> repository;
        public RentUserService(IRepository<RentUser> repository)
        {
            this.repository = repository;
        }

        public void CreateRentUser(RentUser rentUser)
        {
            repository.Insert(rentUser);
        }

        public void DeleteRentUser(RentUser rentUser)
        {
            repository.Remove(rentUser);
        }

        public RentUser Get(int id)
        {
            return repository.Get(id);
        }

        public IEnumerable<RentUser> GetAll()
        {
            return repository.GetAll();
        }

        public void UpdateRentUser(RentUser rentUser)
        {
            repository.Update(rentUser);
        }
    }
}