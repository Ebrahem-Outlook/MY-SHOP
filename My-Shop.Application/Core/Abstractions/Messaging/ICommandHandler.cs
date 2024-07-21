using MediatR;
using My_Shop.Domain.Core.BaseType.Result;

namespace My_Shop.Application.Core.Abstractions.Messaging;

public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
    where TCommand : ICommand<TResponse>
    where TResponse : Result
{

}
