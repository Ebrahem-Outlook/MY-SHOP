using My_Shop.Domain.Core.BaseType;

namespace My_Shop.Domain.Core.Exceptions;

public abstract class DomainException : Exception
{
    protected DomainException(Error error) : base(error.Message)
    {
        
    }
}
