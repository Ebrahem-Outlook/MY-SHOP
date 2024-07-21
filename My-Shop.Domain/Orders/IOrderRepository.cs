using My_Shop.Domain.Products;

namespace My_Shop.Domain.Orders;

public interface IOrderRepository
{
    // Commands.
    Task AddAsync(Order order, CancellationToken cancellationToken = default);
    void Update(Order order);
    void Delete(Order order);

    // Queries.
    Task<List<Order>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Order> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
