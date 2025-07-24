using MediatR;
using Google.Protobuf.WellKnownTypes;
using Meter.M2.Application;

namespace Meter.M2.Api.Services;

public class SubscribeCustomerCreatedService
{
    private readonly IMediator _mediator;
    public SubscribeCustomerCreatedService(IMediator mediator) => _mediator = mediator;

    // Este mÃ©todo ainda precisa de implementaÃ§Ã£o real de stream
    public async IAsyncEnumerable<CustomerCreatedEvent> ExecuteAsync(Empty req, CancellationToken ct)
    {
        // placeholder: repasse directly do domÃ­nio
        throw new NotImplementedException();
    }
}
