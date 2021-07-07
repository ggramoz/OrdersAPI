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
    public class ProductsService : BaseService, IProductsService
    {
        public ProductsService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<Products> AddProduct(Products p)
        {
            var repository = UnitOfWork.AsyncRepository<Products>();

            await repository.AddAsync(p);
            await UnitOfWork.SaveChangesAsync();  

            return p;
        }

        public async Task<bool> DeleteProduct(Products p)
        {
            bool deleted = false;

            var repository = UnitOfWork.AsyncRepository<Products>();

            var product = await repository.GetAsync(_ => _.Id == p.Id);

            if (product != null)
            {
                await repository.DeleteAsync(product);

                await UnitOfWork.SaveChangesAsync();

                deleted = true;
            }

            return deleted;
        }

        public async Task<List<Products>> GetAllProducts()
        {
            var repository = UnitOfWork.AsyncRepository<Products>();

            var res = await repository.ListAsync(x => x != null); 

            return res;
        }

        public async Task<Products> GetProductById(int id)
        {
            var repository = UnitOfWork.AsyncRepository<Products>();

            var res = await repository.GetAsync(x => x.Id == id);

            return res;
        }
    }
}
