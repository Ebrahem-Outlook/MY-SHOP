using My_Shop.Application.Core.Abstractions.Messaging;
using My_Shop.Application.Users.Commands.CreateUser;
using My_Shop.Domain.Core.BaseType.Result;

namespace My_Shop.Application.Users.Commands.UpdateEmail;

public sealed record UpdateEmailCommand(
    Guid UserId, 
    string Email) : ICommand<Result<UserDTO>>;
