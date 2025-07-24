using Microsoft.EntityFrameworkCore;
using Meter.M2.Domain;

namespace Meter.M2.Infrastructure;

public class CustomerRepository : ICustomerRepository
{
    private readonly AppDbContext _db;
    public CustomerRepository(AppDbContext db) => _db = db;

    public Task AddAsync(Customer customer, CancellationToken ct) => _db.Customers.AddAsync(customer, ct).AsTask();
    public Task<Customer?> GetByIdAsync(string id, CancellationToken ct) => _db.Customers.FindAsync(new object[]{id}, ct).AsTask();
    public Task SaveChangesAsync(CancellationToken ct) => _db.SaveChangesAsync(ct);
}
