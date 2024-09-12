using System.Reflection;
using BookMyShow_Clone.Endpoints;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace BookMyShow_Clone;

public static class ProgramConfiguration
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        services.AddScoped<CityEndpoints>();
        services.AddMediatR(assembly);
        services.AddAutoMapper(assembly);
        return services;
    }
}
