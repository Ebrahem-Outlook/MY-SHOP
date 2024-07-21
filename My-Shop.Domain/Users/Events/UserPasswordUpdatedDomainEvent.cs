using My_Shop.Domain.Core.Events;

namespace My_Shop.Domain.Users.Events;

public sealed record UserPasswordUpdatedDomainEvent(
    Guid UserId,
    string Password,
    DateTime? UpdateOn) : DomainEvent;
