using My_Shop.Application.Core.Abstractions.Messaging;
using My_Shop.Domain.Core.BaseType.Result;
using My_Shop.Domain.Users;

namespace My_Shop.Application.Users.Queries.GetByEmail;

internal sealed class GetByEmailQueryHandler : IQueryHandler<GetByEmailQuery, Result<User>>
{
    public Task<Result<User>> Handle(GetByEmailQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
