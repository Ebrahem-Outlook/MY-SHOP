namespace My_Shop.API.Contracts;

public sealed record UpdatePasswordRequest(
    Guid UserId,
    string Password);
