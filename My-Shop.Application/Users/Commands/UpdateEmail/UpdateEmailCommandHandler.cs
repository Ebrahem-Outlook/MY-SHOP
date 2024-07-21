using My_Shop.Application.Core.Abstractions.Messaging;
using My_Shop.Application.Users.Commands.CreateUser;
using My_Shop.Domain.Core.BaseType.Result;

namespace My_Shop.Application.Users.Commands.UpdateEmail;

internal sealed class UpdateEmailCommandHandler : ICommandHandler<UpdateEmailCommand, Result<UserDTO>>
{
    public Task<Result<UserDTO>> Handle(UpdateEmailCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
