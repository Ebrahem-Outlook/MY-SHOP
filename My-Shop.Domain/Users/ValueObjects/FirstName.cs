using My_Shop.Domain.Core.BaseType;

namespace My_Shop.Domain.Users.ValueObjects;

public sealed class FirstName : ValueObject
{
    private FirstName(string value) => Value = value;

    public string Value { get; }

    public static FirstName Create(string value)
    {
        return new FirstName(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
