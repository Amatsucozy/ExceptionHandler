using Exceptions.Domain.Exceptions.Constants;

namespace Exceptions.Domain.Exceptions.Base;

public abstract class DomainException : MyApplicationException
{
    protected DomainException(string message, ErrorCodes errorCode)
        : base(message, errorCode)
    {
    }

    protected DomainException(string message, ErrorCodes errorCode, string userFriendlyMessage)
        : base(message, errorCode, userFriendlyMessage)
    {
    }
}