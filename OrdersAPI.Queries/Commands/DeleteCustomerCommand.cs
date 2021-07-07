using MediatR;
using OrdersAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Queries.Commands
{
    public class DeleteCustomerCommand : IRequest<bool>
    {
        public Customer Customer { get; set; }

        public DeleteCustomerCommand(Customer _Customer)
        {
            Customer = _Customer;
        }
    }
}
