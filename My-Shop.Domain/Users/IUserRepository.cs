namespace My_Shop.Domain.Users;

public interface IUserRepository
{
    // Commands.
    Task AddAsync(User user, CancellationToken cancellationToken);
    void Update(User user);
    void Delete(User user);

    // Queries.
    Task<IQueryable<User>> GetAllAsync(CancellationToken cancellationToken);
    Task<User> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<IQueryable<User>> GetByNameAsync(string name, CancellationToken cancellationToken);
}
