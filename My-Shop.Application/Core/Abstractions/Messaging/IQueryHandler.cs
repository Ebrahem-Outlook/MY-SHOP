using MediatR;
using My_Shop.Domain.Core.BaseType.Result;

namespace My_Shop.Application.Core.Abstractions.Messaging;

public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
    where TQuery : IQuery<TResponse>
    where TResponse : Result
{

}
