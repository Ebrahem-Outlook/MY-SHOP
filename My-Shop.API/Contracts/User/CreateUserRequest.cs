namespace My_Shop.API.Contracts;

public sealed record CreateUserRequest(
    string FirstName, 
    string LastName, 
    string Email, 
    string Password);
