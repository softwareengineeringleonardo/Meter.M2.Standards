using Microsoft.AspNetCore.Mvc;
using MediatR;
using Meter.M2.Application;
using Meter.M2.CreateCustomerService.Models;

namespace Meter.M2.CreateCustomerService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CreateCustomerController : ControllerBase
{
    private readonly IMediator _mediator;
    public CreateCustomerController(IMediator mediator) => _mediator = mediator;

    [HttpPost]
    public async Task<ActionResult<string>> Post([FromBody] CreateCustomerRequest req)
    {
        var id = await _mediator.Send(new CreateCustomerCommand(req.Name, req.Email));
        return CreatedAtAction(null, id);
    }
}
