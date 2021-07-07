using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Domain.Models
{
    public class Products : BaseEntity<int>
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
