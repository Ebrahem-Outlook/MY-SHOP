using My_Shop.Application.Core.Abstractions.Messaging;
using My_Shop.Domain.Core.BaseType.Result;
using My_Shop.Domain.Users;

namespace My_Shop.Application.Users.Queries.GetAllUsers;

internal sealed class GetAllUsersQueryHandler : IQueryHandler<GetAllUsersQuery, Result<List<User>>>
{
    private readonly IUserRepository userRepository;

    public Task<Result<List<User>>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
