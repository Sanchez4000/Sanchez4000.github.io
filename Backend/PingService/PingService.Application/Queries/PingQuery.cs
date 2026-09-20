using Mediator;

namespace PingService.Application.Queries;

public sealed class PingQueryHandler : IQueryHandler<PingQuery, string>
{
    public ValueTask<string> Handle(PingQuery request, CancellationToken cancellationToken)
    {
        return ValueTask.FromResult("pong");
    }
}

public sealed record PingQuery : IQuery<string>;
