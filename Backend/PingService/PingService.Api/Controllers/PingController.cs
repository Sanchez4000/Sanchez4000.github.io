using Mediator;
using Microsoft.AspNetCore.Mvc;
using PingService.Application.Queries;

namespace PingService.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public sealed class PingController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<string> Get(CancellationToken cancellationToken)
    {
        return await mediator.Send(new PingQuery(), cancellationToken);
    }
}
