﻿using BilgeOtel.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeOtel.BLL.AbstractService
{
    public interface IOrderDetailService
    {

        //Create
        void CreateOrderDetail(OrderDetail orderDetail);
        //Delete
        void RemoveOrderDetail(OrderDetail orderDetail);
        //Update
        void UpdateOrderDetail(OrderDetail orderDetail);
        //Get
        OrderDetail Get(int id);
        IEnumerable<OrderDetail> GetAllOrderDetails();
    }
}