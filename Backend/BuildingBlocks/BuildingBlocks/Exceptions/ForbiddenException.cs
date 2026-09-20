using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.Exceptions;

public sealed class ForbiddenException(string message) : AppException(message)
{
    public override int StatusCode => StatusCodes.Status403Forbidden;
    public override string Title => "Доступ запрещён";
}
