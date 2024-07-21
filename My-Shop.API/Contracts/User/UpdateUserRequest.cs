namespace My_Shop.API.Contracts;

public sealed record UpdateUserRequest(
    Guid UserId, 
    string FirstName, 
    string LastName);
