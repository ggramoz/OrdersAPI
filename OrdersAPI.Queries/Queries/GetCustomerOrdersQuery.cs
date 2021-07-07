using MediatR;
using OrdersAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Queries.Queries
{
    public class GetCustomerOrdersQuery : IRequest<List<Order>>
    {
        public int customerId { get; set; }

        public GetCustomerOrdersQuery(int _customerId)
        {
            customerId = _customerId;
        }
    }
}
