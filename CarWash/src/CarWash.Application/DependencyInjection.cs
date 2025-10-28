using Microsoft.Extensions.DependencyInjection;

namespace CarWash.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Здесь позже можно добавить MediatR, AutoMapper и т.д.
        return services;
    }
}