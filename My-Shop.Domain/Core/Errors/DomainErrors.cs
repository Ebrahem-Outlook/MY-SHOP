using My_Shop.Domain.Core.BaseType;

namespace My_Shop.Domain.Core.Errors;

public static class DomainErrors 
{
    public static class User
    {
        public static Error NotFound => new Error("User.NotFound", "User with the specified Id does not exsit");
    }
}
