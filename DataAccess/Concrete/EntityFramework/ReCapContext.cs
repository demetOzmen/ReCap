using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework;

public class ReCapContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReCap;Integrated Security=True;Encrypt=true;TrustServerCertificate=true;");
    }

    public DbSet<Car> Cars { get; set; }

    public DbSet<Brand> Brands { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Rental> Rentals { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Car entity'si için DailyPrice özelliğini yapılandırma
        modelBuilder.Entity<Car>()
            .Property(c => c.DailyPrice)
            .HasColumnType("decimal(18, 2)"); // Ya da HasPrecision(18, 2) kullanabilirsiniz.
    }
}
