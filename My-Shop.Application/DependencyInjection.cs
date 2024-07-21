using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace My_Shop.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());

            cfg.AddOpenBehavior(Type())
        });

        return services;
    }
}
