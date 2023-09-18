using System;
using System.Collections.Generic;
using System.Linq;

namespace EcoPower_Logistics.Repository.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string DeliveryAddress { get; set; } = null!;
        public DateTime OrderDate { get; set; }
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = null!;
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
    }

    public class OrderRepository
    {
        private List<Order> orders;

        public OrderRepository()
        {
            orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public Order GetOrderById(int orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
            {
                throw new InvalidOperationException("Order not found");
            }
            return order;
        }

        public List<Order> GetAllOrders()
        {
            return orders;
        }

        public void UpdateOrder(Order order)
        {
            var existingOrder = orders.FirstOrDefault(o => o.OrderId == order.OrderId);
            if (existingOrder != null)
            {
                // Update individual properties of the existing order
                existingOrder.DeliveryAddress = order.DeliveryAddress;
                existingOrder.OrderDate = order.OrderDate;
            }
        }
    }
}
