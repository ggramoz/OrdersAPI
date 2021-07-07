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
    public class GetOrderByIdHandler : IRequestHandler<GetOrderByIdQuery, Order>
    {
        private readonly IOrdersService orderService;

        public GetOrderByIdHandler(IOrdersService _orderService)
        {
            this.orderService = _orderService;
        }

        public async Task<Order> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            return await orderService.GetOrderById(request.Id);
        }
    }
}
