using Microsoft.EntityFrameworkCore;
using RestCoreApi.Configuration;
using RestCoreApi.Models;

namespace RestCoreApi.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relationships
            modelBuilder.Entity<OrderItem>().HasKey(p => new { p.OrderID, p.ProductID });

            // Database Seeding
            modelBuilder.ApplyConfiguration(new CustomerConfiguration()); //Customer Migrations
            modelBuilder.ApplyConfiguration(new ProductConfiguration()); // Product Migrations
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
