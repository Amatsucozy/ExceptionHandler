using Exceptions.Domain.Exceptions.Constants;

namespace Exceptions.Domain.Exceptions.Base;

public abstract class UnauthorizedException : MyApplicationException
{
    protected UnauthorizedException(string message, ErrorCodes errorCode)
        : base(message, errorCode)
    {
    }

    protected UnauthorizedException(string message, ErrorCodes errorCode, string userFriendlyMessage)
        : base(message, errorCode, userFriendlyMessage)
    {
    }
}