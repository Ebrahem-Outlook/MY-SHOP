using My_Shop.Application.Core.Abstractions.Messaging;
using My_Shop.Domain.Core.BaseType.Result;

using My_Shop.Domain.Users;

namespace My_Shop.Application.Users.Commands.UpdatePassword;

public sealed record UpdatePasswordCommand(
    Guid UserId, 
    string Password) : ICommand<Result<User>>;
