using MediatR;
using OrdersAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Queries.Commands
{
    public class GetOrderByIdQuery : IRequest<Order>
    {
        public int Id { get; set; }

        public GetOrderByIdQuery(int id)
        {
            this.Id = id;
        }
    }
}
