using MediatR;
using Meter.M2.Domain;

namespace Meter.M2.Application\QueryHandler;

public class GetCustomerByIdHandler : IRequestHandler<GetCustomerByIdQuery, CustomerDto>
{
    private readonly ICustomerRepository _repo;
    public GetCustomerByIdHandler(ICustomerRepository repo) => _repo = repo;

    public async System.Threading.Tasks.Task<CustomerDto> Handle(GetCustomerByIdQuery req, System.Threading.CancellationToken ct)
    {
        var cust = await _repo.GetByIdAsync(req.Id, ct)
                   ?? throw new System.Collections.Generic.KeyNotFoundException("Customer not found");
        return new CustomerDto(cust.Id, $"{cust.Name.First} {cust.Name.Last}", cust.Email.Address);
    }
}
