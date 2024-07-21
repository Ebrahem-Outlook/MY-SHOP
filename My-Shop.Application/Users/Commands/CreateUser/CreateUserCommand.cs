using My_Shop.Application.Core.Abstractions.Messaging;
using My_Shop.Domain.Core.BaseType.Result;
using My_Shop.Domain.Users;

namespace My_Shop.Application.Users.Commands.CreateUser;

public sealed record CreateUserCommand(
    string FirstName, 
    string LastName, 
    string Email,
    string Password) : ICommand<User>;
