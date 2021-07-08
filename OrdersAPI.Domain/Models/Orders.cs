using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Domain.Models
{
    public class Order : BaseEntity<int>
    {
        public virtual Customer Customer { get; set; }
        public virtual List<Items> Items { get; set; } = new List<Items>();
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
    }
}
