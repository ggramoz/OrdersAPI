using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Domain.Models
{
    public class Items : BaseEntity<int>
    {
        public virtual Products Product { get; set; }
        public int Quantity { get; set; }
    }
}
