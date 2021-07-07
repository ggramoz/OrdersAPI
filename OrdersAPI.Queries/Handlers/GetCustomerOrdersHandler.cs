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
    public class GetCustomerOrdersHandler : IRequestHandler<GetCustomerOrdersQuery, List<Order>>
    {
        private readonly IOrdersService orderService;

        public GetCustomerOrdersHandler(IOrdersService _orderService)
        {
            this.orderService = _orderService;
        }

        public async Task<List<Order>> Handle(GetCustomerOrdersQuery request, CancellationToken cancellationToken)
        {
            return await orderService.GetCustomerOrders(request.customerId);
        }
    }
}
