using MediatR;
using OrdersAPI.Domain.Models;
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
    public class AddCustomerHandler : IRequestHandler<AddCustomerCommand, Customer>
    { 
        private readonly ICustomersService customersService;

        public AddCustomerHandler(ICustomersService _customersService)
        {
            this.customersService = _customersService;
        }

        public async Task<Customer> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            return await customersService.AddCustomer(request.Customer);
        }
    }
}
