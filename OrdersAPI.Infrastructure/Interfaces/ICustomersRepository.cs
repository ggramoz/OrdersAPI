using Domain.Interfaces;
using OrdersAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Infrastructure
{
    public interface ICustomersRepository : IAsyncRepository<Customer>
    {
    }
}
