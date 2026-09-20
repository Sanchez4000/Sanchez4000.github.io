using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.Exceptions;

public sealed class ValidationException(string message) : AppException(message)
{
    public override int StatusCode => StatusCodes.Status400BadRequest;
    public override string Title => "Некорректный запрос";
}
