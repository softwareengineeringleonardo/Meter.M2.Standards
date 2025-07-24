using MediatR;
using Meter.M2.Domain;

namespace Meter.M2.Application.CommandHandler;

public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, string>
{
    private readonly ICustomerRepository _repo;
    private readonly IMediator         _mediator;

    public CreateCustomerHandler(ICustomerRepository repo, IMediator mediator)
    {
        _repo     = repo;
        _mediator = mediator;
    }

    public async System.Threading.Tasks.Task<string> Handle(CreateCustomerCommand req, System.Threading.CancellationToken ct)
    {
        var parts    = req.Name.Split(" ", 2);
        var customer = new Customer(
            new Name(parts[0], parts.Length > 1 ? parts[1] : string.Empty),
            new Email(req.Email));

        await _repo.AddAsync(customer, ct);
        await _repo.SaveChangesAsync(ct);

        await _mediator.Publish(new CustomerCreatedEvent(customer.Id, req.Name, req.Email), ct);
        return customer.Id;
    }
}
