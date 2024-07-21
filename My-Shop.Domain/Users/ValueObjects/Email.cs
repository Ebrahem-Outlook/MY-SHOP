using My_Shop.Domain.Core.BaseType;

namespace My_Shop.Domain.Users.ValueObjects;

public sealed class Email : ValueObject
{
    private Email(string value) => Value = value;

    public string Value { get; }

    public static Email Create(string value)
    {
        return new Email(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
