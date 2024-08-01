using Microsoft.EntityFrameworkCore;
using MyBackendApi.Models;

namespace MyBackendApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Dilevery> Deliveries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Shop> Shops { get; set; }
    }
}
