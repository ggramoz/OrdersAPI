using MediatR;
using OrdersAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Queries.Commands
{
    public class DeleteOrderCommand : IRequest<bool>
    {
        public Order Order { get; set; }

        public DeleteOrderCommand(Order _Order)
        {
            Order = _Order;
        }
    }
}
