using API.Services;
using Domain.Interfaces;
using OrdersAPI.Domain.Models;
using OrdersAPI.Domain.ViewModels;
using OrdersAPI.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Service.Services
{
    public class OrdersService : BaseService, IOrdersService
    {
        private readonly ICustomersService customersService;
        private readonly IProductsService productsService;

        public OrdersService(IUnitOfWork unitOfWork, ICustomersService _customersService, IProductsService _productsService) : base(unitOfWork)
        {
            customersService = _customersService;
            productsService = _productsService;
        }

        public async Task<Order> AddOrder(OrderVM order)
        {
            Order _order = new Order();
            _order.OrderDate = order.OrderDate; 

            var repository = UnitOfWork.AsyncRepository<Order>();

            var customer = await customersService.GetCustomerById(order.CustomerId);

            //await repository.AddAsync(_order);

            _order.Customer = customer;

            foreach (var item in order.Items)
            {
                var product = await productsService.GetProductById(item.ProductId);

                _order.Items.Add(new Items()
                {
                    Product = product,
                    Quantity = item.Quantity
                });
            }

            foreach (var item in _order.Items)
            {
                _order.TotalPrice += (item.Product.Price * item.Quantity);
            }

            await repository.AddAsync(_order);
            await UnitOfWork.SaveChangesAsync();

            return _order;
        }

        public async Task<bool> DeleteOrder(Order o)
        {
            bool deleted = false;

            var repository = UnitOfWork.AsyncRepository<Order>();

            var order = await repository.GetAsync(_ => _.Id == o.Id);

            if (order != null)
            {
                await repository.DeleteAsync(order);

                await UnitOfWork.SaveChangesAsync();

                deleted = true;
            }

            return deleted;
        }

        public async Task<List<Order>> GetCustomerOrders(int customerId)
        {
            var repository = UnitOfWork.AsyncRepository<Order>();

            var order = await repository.ListAsync(_ => _.Customer.Id == customerId); 

            return order;
        }

        public async Task<List<Order>> GetCustomerOrdersByDate(int customerId, int order)
        {
            var repository = UnitOfWork.AsyncRepository<Order>();
              
            if (order == 1)
            {
                var orderList = await repository.ListAsync(_ => _.Customer.Id == customerId);
                return orderList.OrderBy(x=>x.OrderDate).ToList();
            }
            else
            {
                var orderList = await repository.ListAsync(_ => _.Customer.Id == customerId);
                return orderList.OrderByDescending(x => x.OrderDate).ToList();
            } 
        }

        public async Task<Order> GetOrderById(int id)
        {
            var repository = UnitOfWork.AsyncRepository<Order>();

            //var order = await repository.GetAsync(_ => _.Id == id);

            var order = await repository.GetAsync(_ => _.Id == id);

            return order;
        }



    }
}
