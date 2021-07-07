using MediatR;
using OrdersAPI.Domain.Models;
using OrdersAPI.Queries.Commands;
using OrdersAPI.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrdersAPI.Queries.Handlers
{
    public class AddOrderHandler : IRequestHandler<AddOrderCommand, Order>
    {
        private readonly IOrdersService ordersService;

        public AddOrderHandler(IOrdersService _ordersService)
        {
            this.ordersService = _ordersService;
        }

        public async Task<Order> Handle(AddOrderCommand request, CancellationToken cancellationToken)
        {
            return await ordersService.AddOrder(request.Order);
        }
    }
}
