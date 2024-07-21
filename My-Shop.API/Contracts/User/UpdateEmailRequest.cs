namespace My_Shop.API.Contracts;

public sealed record UpdateEmailRequest(
    Guid UserId,
    string Email);
