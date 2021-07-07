using Infrastructure.Data;
using Infrastructure.Data.Repositories;
using OrdersAPI.Domain.Models; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Infrastructure
{
    public class ProductsRepository : RepositoryBase<Products>
        , IProductsRepository
    {
        public ProductsRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }

}
