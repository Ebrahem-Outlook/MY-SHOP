using MediatR;

namespace My_Shop.Domain.Core.Events;

public interface IDomainEvent : INotification
{
    Guid Id { get; }

    DateTime OccuerOn { get; }
}
