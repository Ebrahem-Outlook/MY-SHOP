using My_Shop.Domain.Core.BaseType;
using My_Shop.Domain.Users.Events;

namespace My_Shop.Domain.Users;

public sealed class User : AggregateRoot
{
    private User(string firstName, string lastName, string email, string password) 
        : base(Guid.NewGuid())
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        CreatedOn = DateTime.UtcNow;
        UpdatedOn = CreatedOn;
    }

    private User() : base(){ }

    public string FirstName { get; private set; } = default!;
    public string LastName { get; private set; } = default!;
    public string Email { get; private set; } = default!;
    public string Password { get; private set; } = default!;
    public DateTime CreatedOn { get; }
    public DateTime? UpdatedOn { get; private set; } = default;


    public static User Create(string firstName, string lastName, string email, string password)
    {
        User user = new(firstName, lastName, email, password);

        user.Raise(new UserCreatedDomainEvent(user));

        return user;
    }

    public void Update(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        UpdatedOn = DateTime.UtcNow;

        Raise(new UserUpdatedDomainEvent(Id, FirstName, LastName, UpdatedOn));
    }

    public void UpdateEmail(string email)
    {
        Email = email;
        UpdatedOn = DateTime.UtcNow;

        Raise(new UserEmailUpdatedDomainEvent(Id, Email, UpdatedOn));
    }

    public void UpdatePassword(string password)
    {
        Password = password;
        UpdatedOn = DateTime.UtcNow;

        Raise(new UserPasswordUpdatedDomainEvent(Id, Password, UpdatedOn));
    }
}
