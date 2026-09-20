using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlocks.ExceptionHandling;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSharedExceptionHandling(this IServiceCollection services)
    {
        services.AddExceptionHandler<GlobalExceptionHandler>();
        services.AddProblemDetails();

        return services;
    }
}
