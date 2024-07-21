using My_Shop.Application.Core.Abstractions.Messaging;
using My_Shop.Application.Users.Commands.CreateUser;
using My_Shop.Domain.Core.BaseType.Result;

namespace My_Shop.Application.Users.Commands.UpdateUser;

public sealed record UpdateUserCommand(
    Guid UserId, 
    string FirstName, 
    string LastName) : ICommand<Result<UserDTO>>;
