using My_Shop.Application.Core.Abstractions.Messaging;
using My_Shop.Domain.Core.BaseType.Result;
using My_Shop.Domain.Users;

namespace My_Shop.Application.Users.Queries.GetByName;

internal sealed class GetByNameQueryHandler : IQueryHandler<GetByNameQuery, Result<User>>
{
    public Task<Result<User>> Handle(GetByNameQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
