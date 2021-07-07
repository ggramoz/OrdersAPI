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
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, List<Products>>
    {
        private readonly IProductsService productsService;

        public GetAllProductsHandler(IProductsService _productsService)
        {
            this.productsService = _productsService;
        }

        public async Task<List<Products>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await productsService.GetAllProducts();
        }
    }
}
