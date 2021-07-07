using OrdersAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Service.Interfaces
{
    public interface IProductsService
    {
        Task<Products> AddProduct(Products p);

        Task<Products> GetProductById(int id);

        Task<List<Products>> GetAllProducts();

        Task<bool> DeleteProduct(Products p);
    }
}
