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
    public class GetAllCustomersHandler : IRequestHandler<GetAllCustomersQuery, List<Customer>>
    {
        private readonly ICustomersService customersService;

        public GetAllCustomersHandler(ICustomersService _customersService)
        {
            this.customersService = _customersService;
        }

        public async Task<List<Customer>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            return await customersService.GetAllCustomers();
        }
    }
}
