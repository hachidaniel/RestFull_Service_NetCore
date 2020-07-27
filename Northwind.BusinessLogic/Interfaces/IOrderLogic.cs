using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.BusinessLogic.Interfaces
{
   public interface IOrderLogic
    {
        IEnumerable<OrderList> GetPaginatedOrders(int page, int rows);
        OrderList GetOrderById(int id);
        bool Delete(Order order);
        Order GetById(int orderId);
        string GetOrderNumber(int orderId);

    }
}
