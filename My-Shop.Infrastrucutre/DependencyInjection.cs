using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using My_Shop.Application.Core.Abstractions.Data;
using My_Shop.Domain.Orders;
using My_Shop.Domain.Products;
using My_Shop.Domain.Users;
using My_Shop.Infrastrucutre.Database;
using My_Shop.Infrastrucutre.Repositories;

namespace My_Shop.Infrastrucutre;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        string? connection = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));

        services.AddScoped<IDbContext>(options => options.GetRequiredService<AppDbContext>());

        services.AddScoped<IUnitOfWork>(options => options.GetRequiredService<AppDbContext>());

        services.AddScoped<IUserRepository, UserRepository>();

        services.AddScoped<IProductRepository, ProductRepository>();

        services.AddScoped<IOrderRepository, OrderRepository>();

        return services;
    }
}
