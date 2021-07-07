using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersAPI.Domain.ViewModels
{
    public class OrderVM
    {
        public int CustomerId { get; set; } 
        public List<ItemsVM> Items { get; set; } = new List<ItemsVM>(); 
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
    }
}
