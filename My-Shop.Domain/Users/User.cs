using My_Shop.Domain.Core.BaseType;

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
    }

    private User() : base(){ }

    public string FirstName { get; private set; } = default!;
    public string LastName { get; private set; } = default!;
    public string Email { get; private set; } = default!;
    public string Password { get; private set; } = default!;


    public static User Create(string firstName, string lastName, string email, string password)
    {
        User user = new(firstName, lastName, email, password);

        user.Raise();

        return user;
    }
}
