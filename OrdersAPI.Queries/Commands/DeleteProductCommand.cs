using MediatR;
using OrdersAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Queries.Commands
{
    public class DeleteProductCommand : IRequest<bool>
    {
        public Products Product { get; set; }

        public DeleteProductCommand(Products Product)
        {
            this.Product = Product;
        }
    }
}
