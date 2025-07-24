using Grpc.Core;
using Google.Protobuf.WellKnownTypes;
using Meter.M2.Api.Services;

namespace Meter.M2.Api.Controllers;

public class CustomerController : CustomerService.CustomerServiceBase
{
    private readonly CreateCustomerService             _createSvc;
    private readonly GetCustomerByIdService            _getByIdSvc;
    private readonly SubscribeCustomerCreatedService   _subSvc;

    public CustomerController(
        CreateCustomerService createSvc,
        GetCustomerByIdService getByIdSvc,
        SubscribeCustomerCreatedService subSvc)
    {
        _createSvc  = createSvc;
        _getByIdSvc = getByIdSvc;
        _subSvc     = subSvc;
    }

    public override Task<CreateCustomerResponse> CreateCustomer(CreateCustomerRequest request, ServerCallContext context)
    {
        return _createSvc.ExecuteAsync(request.Name, request.Email, context.CancellationToken)
                         .ContinueWith(t => new CreateCustomerResponse { Id = t.Result }, context.CancellationToken);
    }

    public override Task<CustomerDto> GetCustomerById(GetCustomerRequest request, ServerCallContext context)
    {
        return _getByIdSvc.ExecuteAsync(request.Id, context.CancellationToken);
    }

    public override async Task SubscribeCustomerCreated(Empty request, IServerStreamWriter<CustomerCreatedEvent> responseStream, ServerCallContext context)
    {
        await foreach (var evt in _subSvc.ExecuteAsync(request, context.CancellationToken))
        {
            await responseStream.WriteAsync(evt);
        }
    }
}
