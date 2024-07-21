using MediatR;
using Microsoft.EntityFrameworkCore.Storage;
using My_Shop.Application.Core.Abstractions.Data;
using My_Shop.Application.Core.Abstractions.Messaging;
using My_Shop.Domain.Core.BaseType.Result;

namespace My_Shop.Application.Core.Behaviors;

public sealed class TransactionBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : ICommand<TResponse>
    where TResponse : Result

{
    private readonly IUnitOfWork _unitOfWork;

    public TransactionBehavior(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (request is not ICommand<TResponse>)
        {
            return await next();
        }

        await using IDbContextTransaction transaction = await _unitOfWork.BeginTransaction(cancellationToken);

        try
        {
            TResponse response = await next();

            await transaction.CommitAsync(cancellationToken);

            return response;
        }
        catch(Exception)
        {
            await transaction.RollbackAsync(cancellationToken);

            throw;
        }
    }
}
