using My_Shop.Domain.Core.Events;

namespace My_Shop.Domain.Users.Events;

public sealed record UserEmailUpdatedDomainEvent(
    Guid UserId,
    string Email,
    DateTime? UpdatedOn) : DomainEvent;
