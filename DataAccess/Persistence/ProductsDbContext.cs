using Entity.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Persistence;

public class ProductsDbContext : DbContext
{
    public DbSet<Account> Accounts { get; set; }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Item> Items { get; set; }
    
    public DbSet<Address> Addresses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source = Products.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>()
            .HasKey(i => new {i.OrderId, i.ProductId});
        
        modelBuilder.Entity<Account>()
            .HasKey(a => a.Username);
        
        modelBuilder.Entity<Customer>()
            .HasKey(c => c.PhoneNo);
        
    }
}