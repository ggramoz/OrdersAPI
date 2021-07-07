using OrdersAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Service.Interfaces
{
    public interface ICustomersService
    {
        Task<Customer> AddCustomer(Customer c);

        Task<List<Customer>> GetAllCustomers();

        Task<Customer> GetCustomerById(int id);

        Task<bool> DeleteCustomer(Customer c);
    }
}
