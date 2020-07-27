using Northwind.BusinessLogic.Interfaces;
using Northwind.Models;
using Northwind.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.BusinessLogic.Implemetations
{
    public class OrderLogic : IOrderLogic
    {
        public readonly IUnitOfWork _unitOfWork;
        public OrderLogic(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

        public bool Delete(Order entity) => _unitOfWork.Order.Delete(entity);

        public Order GetById(int orderId) => _unitOfWork.Order.GetById(orderId);

        public OrderList GetOrderById(int id) => _unitOfWork.Order.GetOrderById(id);

        public IEnumerable<OrderList> GetPaginatedOrders(int page, int rows) => _unitOfWork.Order.getPaginatedOrder(page, rows);

        public string GetOrderNumber(int orderId)
        {
            var list = _unitOfWork.Order.GetList();
            var record = list.First(x => x.Id == orderId);
            return record.OrderNumber;

        }
    }
}
