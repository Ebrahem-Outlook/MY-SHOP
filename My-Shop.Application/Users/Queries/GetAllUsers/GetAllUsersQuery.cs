using My_Shop.Application.Core.Abstractions.Messaging;
using My_Shop.Application.Users.Commands.CreateUser;
using My_Shop.Domain.Core.BaseType.Result;
using My_Shop.Domain.Users;

namespace My_Shop.Application.Users.Queries.GetAllUsers;

public sealed record GetAllUsersQuery() : IQuery<Result<User>>;

internal sealed class GetAllUsersQueryHandler : IQueryHandler<GetAllUsersQuery, Result<List<User>>>
{

}
