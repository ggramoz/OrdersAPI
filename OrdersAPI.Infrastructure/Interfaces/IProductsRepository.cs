using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdersAPI.Domain.Models;

namespace OrdersAPI.Infrastructure
{
    public interface IProductsRepository : IAsyncRepository<Products>
    {
    }
}
