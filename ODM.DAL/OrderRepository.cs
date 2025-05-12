using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODM.DAL
{
    public class OrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Order> GetOrders()
        {
            return _context.Orders
                .Include(o => o.Agent)
                .Include(o => o.OrderDetails.Select(od => od.Item))
                .ToList();
        }

        public List<Order> GetOrdersByAgent(int agentId)
        {
            return _context.Orders
                .Include(o => o.Agent)
                .Include(o => o.OrderDetails.Select(od => od.Item))
                .Where(o => o.AgentID == agentId)
                .ToList();
        }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders
                .Include(o => o.Agent)
                .Include(o => o.OrderDetails.Select(od => od.Item))
                .FirstOrDefault(o => o.OrderID == orderId);
        }

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            var existingOrder = _context.Orders
                .Include(o => o.OrderDetails)
                .FirstOrDefault(o => o.OrderID == order.OrderID);
            if (existingOrder != null)
            {
                existingOrder.OrderDate = order.OrderDate;
                existingOrder.AgentID = order.AgentID;

                // Update OrderDetails
                _context.OrderDetails.RemoveRange(existingOrder.OrderDetails);
                existingOrder.OrderDetails = order.OrderDetails;

                _context.SaveChanges();
            }
        }

        public void DeleteOrder(int orderId)
        {
            var order = _context.Orders
                .Include(o => o.OrderDetails)
                .FirstOrDefault(o => o.OrderID == orderId);
            if (order != null)
            {
                _context.OrderDetails.RemoveRange(order.OrderDetails);
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }

        public List<(Item Item, int TotalQuantity)> GetBestItems()
        {
            var bestItems = _context.OrderDetails
                .GroupBy(od => od.ItemID)
                .Select(g => new
                {
                    Item = g.FirstOrDefault().Item,
                    TotalQuantity = g.Sum(od => od.Quantity)
                })
                .OrderByDescending(x => x.TotalQuantity)
                .Take(5)
                .ToList();

            return bestItems.Select(x => (x.Item, x.TotalQuantity)).ToList();
        }
    }
}
