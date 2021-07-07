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
    public class GetCustomerByIdHandler : IRequestHandler<GetCustomerByIdQuery, Customer>
    {
        private readonly ICustomersService customersService;

        public GetCustomerByIdHandler(ICustomersService _customersService)
        {
            this.customersService = _customersService;
        }

        public async Task<Customer> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            return await customersService.GetCustomerById(request.Id);
        }
    }
}
