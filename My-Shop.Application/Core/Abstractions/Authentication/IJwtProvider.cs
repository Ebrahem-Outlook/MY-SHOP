using My_Shop.Domain.Users;

namespace My_Shop.Application.Core.Abstractions.Authentication;

public interface IJwtProvider
{
    string GenerateToken(User user);
}
