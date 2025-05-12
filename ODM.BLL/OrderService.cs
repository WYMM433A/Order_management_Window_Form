using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODM.DAL;

namespace ODM.BLL
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepository;
        private readonly AgentRepository _agentRepository;
        private readonly ItemRepository _itemRepository;

        public OrderService(OrderRepository orderRepository, AgentRepository agentRepository, ItemRepository itemRepository)
        {
            _orderRepository = orderRepository;
            _agentRepository = agentRepository;
            _itemRepository = itemRepository;
        }

        public List<Order> GetOrders()
        {
            return _orderRepository.GetOrders();
        }

        public List<Order> GetOrdersByAgent(int agentId)
        {
            return _orderRepository.GetOrdersByAgent(agentId);
        }

        public Order GetOrderById(int orderId)
        {
            return _orderRepository.GetOrderById(orderId);
        }

        public void AddOrder(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));
            if (order.OrderDate == default)
                throw new ArgumentException("Order date cannot be empty.", nameof(order.OrderDate));
            if (_agentRepository.GetAgentById(order.AgentID) == null)
                throw new ArgumentException("Agent does not exist.", nameof(order.AgentID));
            if (order.OrderDetails == null || order.OrderDetails.Count == 0)
                throw new ArgumentException("Order must have at least one order detail.", nameof(order.OrderDetails));

            foreach (var detail in order.OrderDetails)
            {
                if (_itemRepository.GetItemById(detail.ItemID) == null)
                    throw new ArgumentException($"Item with ID {detail.ItemID} does not exist.", nameof(detail.ItemID));
                if (detail.Quantity <= 0)
                    throw new ArgumentException("Quantity must be greater than zero.", nameof(detail.Quantity));
               
            }

            _orderRepository.AddOrder(order);
        }

        public void UpdateOrder(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));
            if (order.OrderDate == default)
                throw new ArgumentException("Order date cannot be empty.", nameof(order.OrderDate));
            if (_agentRepository.GetAgentById(order.AgentID) == null)
                throw new ArgumentException("Agent does not exist.", nameof(order.AgentID));
            if (_orderRepository.GetOrderById(order.OrderID) == null)
                throw new ArgumentException("Order does not exist.", nameof(order.OrderID));
            if (order.OrderDetails == null || order.OrderDetails.Count == 0)
                throw new ArgumentException("Order must have at least one order detail.", nameof(order.OrderDetails));

            foreach (var detail in order.OrderDetails)
            {
                if (_itemRepository.GetItemById(detail.ItemID) == null)
                    throw new ArgumentException($"Item with ID {detail.ItemID} does not exist.", nameof(detail.ItemID));
                if (detail.Quantity <= 0)
                    throw new ArgumentException("Quantity must be greater than zero.", nameof(detail.Quantity));
             
            }

            _orderRepository.UpdateOrder(order);
        }

        public void DeleteOrder(int orderId)
        {
            if (_orderRepository.GetOrderById(orderId) == null)
                throw new ArgumentException("Order does not exist.", nameof(orderId));

            _orderRepository.DeleteOrder(orderId);
        }

        public List<(Item Item, int TotalQuantity)> GetBestItems()
        {
            return _orderRepository.GetBestItems();
        }
    }
}
