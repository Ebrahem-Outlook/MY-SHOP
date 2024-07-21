namespace My_Shop.Application.Core.Abstractions.Authentication;

public interface IUserIdentitferProvider
{
    Guid UserId { get; }
}
