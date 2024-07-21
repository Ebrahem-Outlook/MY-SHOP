using Microsoft.EntityFrameworkCore;
using My_Shop.Application.Core.Abstractions.Data;
using My_Shop.Domain.Users;

namespace My_Shop.Infrastrucutre.Repositories;

internal sealed class UserRepository(IDbContext dbContext) : IUserRepository
{
    public async Task AddAsync(User user, CancellationToken cancellationToken)
    {
        await dbContext.Set<User>().AddAsync(user, cancellationToken);
    }

    public void Update(User user)
    {
        dbContext.Set<User>().Update(user);
    }

    public void Delete(User user)
    {
        dbContext.Set<User>().Remove(user);
    }

    public async Task<List<User>?> GetAllAsync(CancellationToken cancellationToken)
    {
        return await dbContext.Set<User>().ToListAsync(cancellationToken);
    }

    public async Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await dbContext.Set<User>().FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
    }

    public async Task<List<User>?> GetByNameAsync(string name, CancellationToken cancellationToken)
    {
        return await dbContext.Set<User>().Where(u => u.FirstName == name).ToListAsync(cancellationToken);
    }
}
