using MediatR;
using My_Shop.Domain.Core.BaseType.Result;

namespace My_Shop.Application.Core.Abstractions.Messaging;

public interface IQuery<out TResponse> : IRequest<TResponse>
    where TResponse : Result
{

}
