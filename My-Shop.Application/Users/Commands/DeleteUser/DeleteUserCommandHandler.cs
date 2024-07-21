using My_Shop.Application.Core.Abstractions.Messaging;
using My_Shop.Application.Users.Commands.CreateUser;
using My_Shop.Domain.Core.BaseType.Result;
using My_Shop.Domain.Users;

namespace My_Shop.Application.Users.Commands.DeleteUser;

internal sealed class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand, Result<User>>
{
    private readonly IUserRepository _userRepository;
    public Task<Result<User>> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
