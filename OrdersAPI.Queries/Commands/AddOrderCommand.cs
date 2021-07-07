using MediatR;
using OrdersAPI.Domain.Models;
using OrdersAPI.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Queries.Commands
{
    public class AddOrderCommand : IRequest<Order>
    {
        public OrderVM Order { get; set; }

        public AddOrderCommand(OrderVM _Order)
        { 
            Order = _Order;
        }
    }
}
