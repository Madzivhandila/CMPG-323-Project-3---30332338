using System;
using System.Collections.Generic;
using System.Linq;

namespace EcoPower_Logistics.Repository.Models
{
    public class OrderDetails
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
        private List<OrderDetails> orders;

        public OrderRepository()
        {
            orders = new List<OrderDetails>();
        }

        public void AddOrder(OrderDetails order)
        {
            orders.Add(order);
        }

        public OrderDetails GetOrderById(int orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
            {
                throw new InvalidOperationException("Order not found");
            }
            return order;
        }

        public List<OrderDetails> GetAllOrders()
        {
            return orders;
        }

        public void UpdateOrder(OrderDetails order)
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
