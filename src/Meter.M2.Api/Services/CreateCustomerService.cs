using MediatR;
using Meter.M2.Application;

namespace Meter.M2.Api.Services;

public class CreateCustomerService
{
    private readonly IMediator _mediator;
    public CreateCustomerService(IMediator mediator) => _mediator = mediator;
    public Task<string> ExecuteAsync(string name, string email, CancellationToken ct) 
        => _mediator.Send(new CreateCustomerCommand(name, email), ct);
}
