using My_Shop.Application.Core.Abstractions.Messaging;
using My_Shop.Application.Users.Commands.CreateUser;
using My_Shop.Domain.Core.BaseType.Result;

namespace My_Shop.Application.Users.Commands.UpdatePassword;

public sealed record UpdatePasswordCommand(
    Guid UserId, 
    string Password) : ICommand<Result<UserDTO>>;
