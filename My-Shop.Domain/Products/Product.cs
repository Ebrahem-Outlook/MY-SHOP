using My_Shop.Domain.Core.BaseType;
using My_Shop.Domain.Products.Events;

namespace My_Shop.Domain.Products;

public sealed class Product : AggregateRoot
{
    private Product(string name, string description, decimal price, int stock) 
        : base(Guid.NewGuid())
    {
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        CreatedOn = DateTime.UtcNow;
        UpdatedOn = CreatedOn;
    }

    private Product() : base() { }

    public string Name { get; private set; } = default!;
    public string Description { get; private set; } = default!;
    public decimal Price { get; private set; }
    public int Stock { get; private set; }
    public DateTime CreatedOn { get; }
    public DateTime UpdatedOn { get; private set; }

    public static Product Create(string name, string description, decimal price, int stock)
    {
        Product product = new(name, description, price, stock);

        product.Raise(new ProductCreatedDomainEvent(product));

        return product;
    }

    public void Update(string name, string description, decimal price, int stock)
    {
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        UpdatedOn = DateTime.UtcNow;

        Raise(new ProductUpdatedDomainEvent(this));
    }
}
