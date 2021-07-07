using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrdersAPI.Domain.Models;
using OrdersAPI.Domain.ViewModels;
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
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("OrderById")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var query = new GetOrderByIdQuery(id);
              
            var result = _mediator.Send(query); 

            return Ok(result);
        }

        [HttpPost("AddOrder")]
        public async Task<IActionResult> AddOrder(OrderVM o)
        {
            var query = new AddOrderCommand(o);

            var result = _mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("GetCustomerOrders")]
        public async Task<IActionResult> GetCustomerOrders(int customerId)
        {
            var query = new GetCustomerOrdersQuery(customerId);

            var result = _mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("GetCustomerOrdersByDate")]
        public async Task<IActionResult> GetCustomerOrdersByDate(int customerId, int order)
        {
            var query = new GetCustomerOrdersByDateQuery(customerId, order);

            var result = _mediator.Send(query);

            return Ok(result);
        }

        [HttpPost("DeleteOrder")]
        public async Task<IActionResult> DeleteOrder(Order order)
        {
            var query = new DeleteOrderCommand(order);

            var result = _mediator.Send(query);

            return Ok(result); 
        }
        /*  

        Task<bool> DeleteOrder(Order o);*/


    }
}
