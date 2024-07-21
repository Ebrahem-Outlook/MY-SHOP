using My_Shop.Domain.Products;

namespace My_Shop.Domain.Orders;

public interface IOrderRepository
{
    // Commands.
    Task AddAsync(Order product, CancellationToken cancellationToken = default);
    void Update(Order product);
    void Delete(Order product);

    // Queries.
    Task<IQueryable<Order>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Order> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IQueryable<Order>> GetByNameAsync(string name, CancellationToken cancellationToken = default);
}
