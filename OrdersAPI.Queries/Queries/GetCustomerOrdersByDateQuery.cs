using MediatR;
using OrdersAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Queries.Queries
{
    public class GetCustomerOrdersByDateQuery : IRequest<List<Order>>
    {
        public int customerId { get; set; }
        public int order { get; set; }

        public GetCustomerOrdersByDateQuery(int _customerId, int _order)
        {
            customerId = _customerId;
            order = _order;
        }
    }
}
