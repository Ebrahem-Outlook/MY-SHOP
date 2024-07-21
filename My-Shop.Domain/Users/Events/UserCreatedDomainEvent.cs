using My_Shop.Domain.Core.Events;

namespace My_Shop.Domain.Users.Events;

public sealed record UserCreatedDomainEvent(
    Guid UserId,
    string FirstName, 
    string LastName, 
    string Email, 
    string Password,
    DateTime CreatedOn) : DomainEvent;
