namespace My_Shop.Domain.Users;

public interface IUserRepository
{
    // Commands.
    Task AddAsync(User user, CancellationToken cancellationToken);
    void Update(User user);
    void Delete(User user);

    // Queries.
    Task<List<User>?> GetAllAsync(CancellationToken cancellationToken);
    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<List<User>?> GetByNameAsync(string name, CancellationToken cancellationToken);
}
