using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrdersAPI.Domain.Models;
using OrdersAPI.Queries.Commands;
using OrdersAPI.Queries.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("AddCustomer")]
        public async Task<IActionResult> AddCustomer(Customer customer)
        {
            var query = new AddCustomerCommand(customer);

            var result = _mediator.Send(query);

            return Ok(result);
        }

        [HttpPost("DeleteCustomer")]
        public async Task<IActionResult> DeleteCustomer(Customer customer)
        {
            var query = new DeleteCustomerCommand(customer);

            var result = _mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("GetAllCustomers")]
        public async Task<IActionResult> GetAllCustomers()
        {
            var query = new GetAllCustomersQuery();

            var result = _mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("GetCustomerById")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var query = new GetCustomerByIdQuery(id);

            var result = _mediator.Send(query);

            return Ok(result);
        }

    }
}
