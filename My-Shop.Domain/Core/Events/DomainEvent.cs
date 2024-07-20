namespace My_Shop.Domain.Core.Events;

public record DomainEvent : IDomainEvent
{
    public DomainEvent()
    {
        Id = Guid.NewGuid();
        OccuerOn = DateTime.Now;
    }

    public Guid Id { get; }

    public DateTime OccuerOn { get; }
}
