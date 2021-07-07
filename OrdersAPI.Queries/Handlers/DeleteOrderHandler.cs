using MediatR;
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
    public class DeleteOrderHandler : IRequestHandler<DeleteOrderCommand, bool>
    {
        private readonly IOrdersService orderService;

        public DeleteOrderHandler(IOrdersService _orderService)
        {
            this.orderService = _orderService;
        }

        public async Task<bool> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            return await orderService.DeleteOrder(request.Order);
        }
    }
}
