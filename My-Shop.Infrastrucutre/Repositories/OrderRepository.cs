using Microsoft.EntityFrameworkCore;
using My_Shop.Application.Core.Abstractions.Data;
using My_Shop.Domain.Orders;

namespace My_Shop.Infrastrucutre.Repositories;

internal sealed class OrderRepository(IDbContext dbContext) : IOrderRepository
{
    public async Task AddAsync(Order order, CancellationToken cancellationToken = default)
    {
        await dbContext.Set<Order>().AddAsync(order, cancellationToken);
    }

    public void Update(Order order)
    {
        dbContext.Set<Order>().Update(order);
    }

    public void Delete(Order order)
    {
        dbContext.Set<Order>().Remove(order);
    }

    public async Task<List<Order>?> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<Order>().ToListAsync(cancellationToken);
    }

    public async Task<Order?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<Order>().FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
    }
}
