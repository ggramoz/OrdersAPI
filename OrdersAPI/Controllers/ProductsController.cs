using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrdersAPI.Domain.Models;
using OrdersAPI.Queries.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    { 
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("AddProduct")]
        public async Task<IActionResult> AddProduct(Products product)
        {
            var query = new AddProductCommand(product);

            var result = _mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("GetAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            var query = new GetAllProductsQuery();

            var result = _mediator.Send(query);

            return Ok(result);
        }

        [HttpPost("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct(Products product)
        {
            var query = new DeleteProductCommand(product);

            var result = _mediator.Send(query);

            return Ok(result);
        }
    }
}
