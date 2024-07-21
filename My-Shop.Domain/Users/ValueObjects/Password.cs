namespace My_Shop.Domain.Users.ValueObjects;

public sealed class Password : ValueObject
{
    private Password(string value) => Value = value;

    public string Value { get; }

    public static Password Create(string value)
    {
        return new Password(value);
    }

}
