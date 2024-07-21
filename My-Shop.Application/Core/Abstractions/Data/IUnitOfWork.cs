using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace My_Shop.Application.Core.Abstractions.Data;

public interface IUnitOfWork
{
    Task<IDbContextTransaction> BeginTransaction(CancellationToken cancellationToken);

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}