using OrdersAPI.Domain.Models;
using OrdersAPI.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Service.Interfaces
{
    public interface IOrdersService
    {
        Task<Order> GetOrderById(int id);

        Task<Order> AddOrder(OrderVM order);

        Task<List<Order>> GetCustomerOrders(int customerId);

        Task<List<Order>> GetCustomerOrdersByDate(int customerId, int order);

        Task<bool> DeleteOrder(Order o);
    }
}
