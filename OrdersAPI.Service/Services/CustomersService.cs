using API.Services;
using Domain.Interfaces;
using OrdersAPI.Domain.Models;
using OrdersAPI.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Service.Services
{
    public class CustomersService : BaseService, ICustomersService
    {
        public CustomersService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<Customer> AddCustomer(Customer c)
        {
            var repository = UnitOfWork.AsyncRepository<Customer>();

            await repository.AddAsync(c);
            await UnitOfWork.SaveChangesAsync();

            return c;
        }

        public async Task<bool> DeleteCustomer(Customer c)
        {
            bool deleted = false;

            var repository = UnitOfWork.AsyncRepository<Customer>();

            var customer = await repository.GetAsync(_ => _.Id == c.Id);

            if (customer != null)
            {
                await repository.DeleteAsync(customer);

                await UnitOfWork.SaveChangesAsync();

                deleted = true;
            }

            return deleted;
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            var repository = UnitOfWork.AsyncRepository<Customer>();

            var res = await repository.ListAsync(_ => _ != null);

            return res;
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            var repository = UnitOfWork.AsyncRepository<Customer>();

            var res = await repository.GetAsync(_ => _.Id == id);

            return res;
        }
    }
}
