using My_Shop.Application.Core.Abstractions.Messaging;
using My_Shop.Application.Users.Commands.CreateUser;
using My_Shop.Domain.Core.BaseType.Result;
using My_Shop.Domain.Users;

namespace My_Shop.Application.Users.Commands.UpdateEmail;

internal sealed class UpdateEmailCommandHandler : ICommandHandler<UpdateEmailCommand, Result<User>>
{
    public Task<Result<User>> Handle(UpdateEmailCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
