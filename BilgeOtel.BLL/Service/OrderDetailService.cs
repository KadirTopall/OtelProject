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
    public class OrderDetailService : IOrderDetailService

    {
        private readonly IRepository<OrderDetail> orderDetailRepository;
        public OrderDetailService(IRepository<OrderDetail> orderDetailrepository)
        {
            this.orderDetailRepository = orderDetailrepository;
        }



        public void CreateOrderDetail(OrderDetail orderDetail)
        {
            orderDetailRepository.Insert(orderDetail);
        }

        public OrderDetail Get(int id)
        {
            return orderDetailRepository.Get(id);
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            return orderDetailRepository.GetAll();
        }

        public void RemoveOrderDetail(OrderDetail orderDetail)
        {
            orderDetailRepository.Remove(orderDetail);
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            orderDetailRepository.Update(orderDetail);
        }
    }
}
