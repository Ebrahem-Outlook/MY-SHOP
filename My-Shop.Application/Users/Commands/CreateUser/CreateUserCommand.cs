using My_Shop.Application.Core.Abstractions.Messaging;
using My_Shop.Domain.Core.BaseType.Result;

namespace My_Shop.Application.Users.Commands.CreateUser;

public sealed record CreateUserCommand(
    string FirstName, 
    string LastName, 
    string Email,
    string Password) : ICommand<Result<UserDTO>>;
