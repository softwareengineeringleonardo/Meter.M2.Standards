namespace Meter.M2.Domain;

public class Customer
{
    public string Id    { get; private init; }
    public Name   Name  { get; private init; }
    public Email  Email { get; private init; }

    public Customer(Name name, Email email)
    {
        Id    = System.Guid.NewGuid().ToString();
        Name  = name;
        Email = email;
    }
}

public record Name(string First, string Last);
public record Email(string Address);

public interface IEntity { string Id { get; } }

public interface ICustomerRepository
{
    System.Threading.Tasks.Task AddAsync(Customer customer, System.Threading.CancellationToken ct);
    System.Threading.Tasks.Task<Customer?> GetByIdAsync(string id, System.Threading.CancellationToken ct);
    System.Threading.Tasks.Task SaveChangesAsync(System.Threading.CancellationToken ct);
}
