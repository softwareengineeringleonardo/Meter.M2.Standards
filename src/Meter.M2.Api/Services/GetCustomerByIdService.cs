using MediatR;
using Meter.M2.Application;

namespace Meter.M2.Api\Services;

public class GetCustomerByIdService
{
    private readonly IMediator _mediator;
    public GetCustomerByIdService(IMediator mediator) => _mediator = mediator;
    public Task<CustomerDto> ExecuteAsync(string id, CancellationToken ct) 
        => _mediator.Send(new GetCustomerByIdQuery(id), ct);
}
