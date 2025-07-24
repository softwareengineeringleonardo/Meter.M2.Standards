using Microsoft.AspNetCore.Mvc;
using MediatR;
using Meter.M2.Application;

namespace Meter.M2.GetCustomerService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly IMediator _mediator;
    public CustomersController(IMediator mediator) => _mediator = mediator;

    [HttpGet("{id}")]
    public async Task<ActionResult<CustomerDto>> Get(string id)
    {
        var dto = await _mediator.Send(new GetCustomerByIdQuery(id));
        return dto is not null ? Ok(dto) : NotFound();
    }
}
