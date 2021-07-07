using MediatR;
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
    public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand, bool>
    {
        private readonly ICustomersService customersService;

        public DeleteCustomerHandler(ICustomersService _customersService)
        {
            this.customersService = _customersService;
        }

        public async Task<bool> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            return await customersService.DeleteCustomer(request.Customer);
        }
    }
}
