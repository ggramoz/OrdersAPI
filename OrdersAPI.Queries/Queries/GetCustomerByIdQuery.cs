using MediatR;
using OrdersAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Queries.Queries
{
    public class GetCustomerByIdQuery : IRequest<Customer>
    {
        public int Id { get; set; }

        public GetCustomerByIdQuery(int _Id)
        {
            Id = _Id;
        }
    }
}
