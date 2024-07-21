using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using My_Shop.Application.Core.Abstractions.Data;
using My_Shop.Domain.Products;
using My_Shop.Domain.Users;
using My_Shop.Infrastrucutre.Caching;
using My_Shop.Infrastrucutre.Database;
using My_Shop.Infrastrucutre.Repositories;

namespace My_Shop.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            string? connection = configuration.GetConnectionString("Local-SqlServer");

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));

            services.AddScoped<IDbContext>(sp => sp.GetRequiredService<AppDbContext>());

            services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<AppDbContext>());

            services.AddMemoryCache();

            services.AddScoped<UserRepository>();

            services.AddScoped<IUserRepository>(sp =>
            {
                var dbContext = sp.GetRequiredService<UserRepository>();
                var memoryCache = sp.GetRequiredService<IMemoryCache>();
                return new CachedUserRepository(dbContext, memoryCache);
            });

            services.AddScoped<IProductRepository>(sp =>
            {
                var dbContext = sp.GetRequiredService<ProductRepository>();
                var memoryCache = sp.GetRequiredService<IMemoryCache>();
                return new CachedProductRepository(dbContext, memoryCache);
            });

            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
