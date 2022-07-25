using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using OneMoreHomework.Entities;

namespace OneMoreHomework
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        
        public DbSet<Delivery> Deliveryes { get; set; }
        public DbSet<ProductCategorycs> ProductCategorycs { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Worker> Workers { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> option) : base(option)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }


    }
}
