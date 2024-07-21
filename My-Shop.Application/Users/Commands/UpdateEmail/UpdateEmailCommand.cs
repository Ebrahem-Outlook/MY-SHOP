using My_Shop.Application.Core.Abstractions.Messaging;
using My_Shop.Application.Users.Commands.CreateUser;
using My_Shop.Domain.Core.BaseType.Result;
using My_Shop.Domain.Users;

namespace My_Shop.Application.Users.Commands.UpdateEmail;

public sealed record UpdateEmailCommand(
    Guid UserId, 
    string Email) : ICommand<Result<User>>;
