using Microsoft.Extensions.Caching.Memory;
using My_Shop.Domain.Users;
using My_Shop.Infrastrucutre.Repositories;

namespace My_Shop.Infrastrucutre.Caching;

internal sealed class CachedUserRepository(UserRepository decorated, IMemoryCache memoryCache) : IUserRepository
{
    public async Task AddAsync(User user, CancellationToken cancellationToken)
    {
        await decorated.AddAsync(user, cancellationToken);
        string key = $"Key-{user.Id}";
        memoryCache.Remove(key);
    }

    public void Update(User user)
    {
        decorated.Update(user);
        string key = $"Key-{user.Id}";
        memoryCache.Remove(key);
    }
    public void Delete(User user)
    {
        decorated.Delete(user);
        string key = $"Key-{user.Id}";
        memoryCache.Remove(key);
    }

    public async Task<List<User>?> GetAllAsync(CancellationToken cancellationToken)
    {
        string key = $"Key-AllUsers";
        return await memoryCache.GetOrCreateAsync(key, Entry =>
        {
            Entry.SetAbsoluteExpiration(TimeSpan.FromMinutes(1));

            return decorated.GetAllAsync(cancellationToken);
        });
    }

    public async Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        string key = $"Key-{id}";
        return await memoryCache.GetOrCreateAsync(key, Entry =>
        {
            Entry.SetAbsoluteExpiration(TimeSpan.FromMinutes(4));

            return decorated.GetByIdAsync(id, cancellationToken);
        });
    }

    public async Task<List<User>?> GetByNameAsync(string name, CancellationToken cancellationToken)
    {
        string key = $"Key-{name}";
        return await memoryCache.GetOrCreateAsync(key, Entry =>
        {
            Entry.SetAbsoluteExpiration(TimeSpan.FromMinutes(1));

            return decorated.GetByNameAsync(name, cancellationToken);
        });
    }
}
