namespace My_Shop.Domain.Products;

public interface IProductRepository
{
    // Commands.
    Task AddAsync(Product product, CancellationToken cancellationToken = default);
    void Update(Product product);
    void Delete(Product product);

    // Queries.
    Task<IQueryable<Product>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Product> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IQueryable<Product>> GetByNameAsync(string name, CancellationToken cancellationToken = default);
}
