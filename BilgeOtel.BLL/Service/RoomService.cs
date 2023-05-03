using BilgeOtel.BLL.Abstract;
using BilgeOtel.BLL.AbstractService;
using BilgeOtel.DAL.Context;
using BilgeOtel.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeOtel.BLL.Service
{
    public class RoomService : IRoomService
    {
        private readonly IRepository<Room> repository;
        private readonly ProjectContext projectContext;
        public RoomService(IRepository<Room> repository, ProjectContext projectContext)
        {
            this.repository = repository;
            this.projectContext = projectContext;
        }

        public IEnumerable<Room> GetAll()
        {
            return repository.GetAll();

        }

        public Room GetRoom(int id)
        {
            return repository.Get(id);
        }

        public void UpdateRoom(Room room)
        {
            repository.Update(room);
        }


    }
}
