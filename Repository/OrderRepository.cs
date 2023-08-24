using BussinessObject2;
using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetOrders() => OrderDAO.GetOrders();

        public void AddOrder(Order order) => OrderDAO.AddOrder(order);
        public  Order getOrderById(int id) => OrderDAO.getOrderById(id);
        public  void UpdateOrder(Order Order) => OrderDAO.UpdateOrder(Order);
    }
}
