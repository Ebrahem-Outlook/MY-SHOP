using Microsoft.Extensions.DependencyInjection;

namespace My_Shop.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}
