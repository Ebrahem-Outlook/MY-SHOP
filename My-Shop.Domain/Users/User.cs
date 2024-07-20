namespace My_Shop.Domain.Users;

public sealed class User : AggregateRoot
{


    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
}
