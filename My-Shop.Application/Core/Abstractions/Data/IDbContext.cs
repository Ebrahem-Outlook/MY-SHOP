using Microsoft.EntityFrameworkCore;
using My_Shop.Domain.Core.BaseType;

namespace My_Shop.Application.Core.Abstractions.Data;

public interface IDbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : Entity;
}
