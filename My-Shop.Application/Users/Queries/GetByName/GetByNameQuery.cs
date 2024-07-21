using My_Shop.Application.Core.Abstractions.Messaging;

namespace My_Shop.Application.Users.Queries.GetByName;

public sealed record GetByNameQuery(string Name) : IQuery<>
