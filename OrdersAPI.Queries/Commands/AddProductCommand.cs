using MediatR;
using OrdersAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Queries.Commands
{
    public class AddProductCommand : IRequest<Products>
    {
        public Products Product { get; set; }

        public AddProductCommand(Products _Product)
        {
            Product = _Product;
        }
    }
}
