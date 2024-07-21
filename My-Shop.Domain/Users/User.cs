using My_Shop.Domain.Core.BaseType;
using My_Shop.Domain.Users.Events;
using My_Shop.Domain.Users.ValueObjects;

namespace My_Shop.Domain.Users;

public sealed class User : AggregateRoot
{
    private User(FirstName firstName, LastName lastName, Email email, Password password)
        : base(Guid.NewGuid())
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }

    private User() : base(){ }

    public FirstName FirstName { get; private set; } = default!;
    public LastName LastName { get; private set; } = default!;
    public Email Email { get; private set; } = default!;
    public Password Password { get; private set; } = default!;

    public static User Create(FirstName firstName, LastName lastName, Email email, Password password)
    {
        User user = new User(firstName, lastName, email, password);

        user.Raise(new UserCreatedDomainEvent(user));

        return user;
    }

    public void Update(FirstName firstName, LastName lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        Raise(new UserUpdatedDomainEvent(Id, FirstName.Value, LastName.Value));
    }

    public void UpdateEmail(Email email)
    {
        Email = email;

        Raise(new UserEmailUpdatedDomainEvent(Id, Email.Value));
    }

    public void UpdatePassword(string password)
    {
        Password = password;
        UpdatedOn = DateTime.UtcNow;

        Raise(new UserPasswordUpdatedDomainEvent(Id, Password, UpdatedOn));
    }
}
