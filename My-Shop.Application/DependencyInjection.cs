using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using My_Shop.Application.Core.Behaviors;
using System.Reflection;

namespace My_Shop.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());

            cfg.AddOpenBehavior(typeof(LoggingBehavior<,>));

            cfg.AddOpenBehavior(typeof(TransactionBehavior<,>));

            cfg.AddOpenBehavior(typeof(ValidationBehavior<,>));

            cfg.AddOpenBehavior(typeof(ExceptionHandlingBehavior<,>));
        });

        return services;
    }
}
