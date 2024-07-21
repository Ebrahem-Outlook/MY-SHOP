using My_Shop.Domain.Core.Events;

namespace My_Shop.Domain.Core.BaseType;

public abstract class AggregateRoot : Entity
{
    protected AggregateRoot(Guid id) : base(id) { }

    protected AggregateRoot() : base() { }

    private readonly List<IDomainEvent> domainEvents = new List<IDomainEvent>();

    public IReadOnlyCollection<IDomainEvent> DomainEvent => domainEvents.AsReadOnly();

    public void Raise(IDomainEvent @event) => domainEvents.Add(@event);

    public void Clear() => domainEvents.Clear();
}
