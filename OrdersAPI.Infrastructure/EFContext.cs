using Microsoft.EntityFrameworkCore;
using OrdersAPI.Domain.Models;

namespace Infrastructure.Data
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        { 
        }

        DbSet<Customer> Customers { get; set; }
        DbSet<Items> Items { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
             
        }
    }
}