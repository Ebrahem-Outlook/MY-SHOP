using My_Shop.Domain.Core.Events;

namespace My_Shop.Domain.Products.Events;

public sealed record ProductCreatedDomainEvent(Product Product) : DomainEvent;
