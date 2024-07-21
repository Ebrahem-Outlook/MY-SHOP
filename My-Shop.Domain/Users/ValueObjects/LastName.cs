using My_Shop.Domain.Core.BaseType;

namespace My_Shop.Domain.Users.ValueObjects;

public sealed class LastName : ValueObject
{
    private LastName(string value) => Value = value;

    public string Value { get; }

    public static LastName Create(string value)
    {
        return new LastName(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
