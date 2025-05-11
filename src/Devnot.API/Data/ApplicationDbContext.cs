using Microsoft.EntityFrameworkCore;
using Devnot.API.Models;

namespace Devnot.API.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("products");

            entity.Property(e => e.ProductName)
                .HasColumnName("product_name");

            entity.Property(e => e.ProductID)
                .HasColumnName("product_id");
        });
    }
}