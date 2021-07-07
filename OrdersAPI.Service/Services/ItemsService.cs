using API.Services;
using Domain.Interfaces;
using OrdersAPI.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Service.Services
{
    public class ItemsService : BaseService, IItemsService
    {
        public ItemsService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
