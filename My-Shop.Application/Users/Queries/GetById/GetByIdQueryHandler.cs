using My_Shop.Application.Core.Abstractions.Messaging;
using My_Shop.Domain.Core.BaseType.Result;
using My_Shop.Domain.Users;

namespace My_Shop.Application.Users.Queries.GetById;

internal sealed class GetByIdQueryHandler : IQueryHandler<GetByIdQuery, Result<User>>
{
    public Task<Result<User>> Handle(GetByIdQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
