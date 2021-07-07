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
    public class CustomersRepository : RepositoryBase<Customer>
        , ICustomersRepository
    {
        public CustomersRepository(EFContext dbContext) : base(dbContext)
        {
        }  
    }
}
