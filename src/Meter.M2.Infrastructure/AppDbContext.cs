using Microsoft.EntityFrameworkCore;
using Meter.M2.Domain;

namespace Meter.M2.Infrastructure;

public class AppDbContext : DbContext
{
    public DbSet<Customer> Customers => Set<Customer>();

    public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }

    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<Customer>(cfg =>
        {
            cfg.HasKey(c => c.Id);
            cfg.OwnsOne(c => c.Name, n =>
            {
                n.Property(p => p.First).HasColumnName("FirstName");
                n.Property(p => p.Last).HasColumnName("LastName");
            });
            cfg.OwnsOne(c => c.Email);
        });
    }
}
