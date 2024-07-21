using My_Shop.Domain.Core.Events;

namespace My_Shop.Domain.Users.Events;

public sealed record UserUpdatedDomainEvent(
    Guid UserId,
    string FirstName,
    string LastName,
    DateTime UpdatedOn) : DomainEvent;
