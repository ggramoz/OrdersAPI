using MediatR;
using OrdersAPI.Domain.Models;
using OrdersAPI.Queries.Queries;
using OrdersAPI.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrdersAPI.Queries.Handlers
{
    public class GetCustomerOrdersByDateHandler : IRequestHandler<GetCustomerOrdersByDateQuery, List<Order>>
    {
        private readonly IOrdersService orderService;

        public GetCustomerOrdersByDateHandler(IOrdersService _orderService)
        {
            this.orderService = _orderService;
        }

        public async Task<List<Order>> Handle(GetCustomerOrdersByDateQuery request, CancellationToken cancellationToken)
        {
            return await orderService.GetCustomerOrdersByDate(request.customerId, request.order);
        }
    }
}
