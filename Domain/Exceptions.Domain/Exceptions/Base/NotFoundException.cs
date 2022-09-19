using Exceptions.Domain.Exceptions.Constants;

namespace Exceptions.Domain.Exceptions.Base;

public abstract class NotFoundException : MyApplicationException
{
    protected NotFoundException(string message, ErrorCodes errorCode)
        : base(message, errorCode)
    {
    }

    protected NotFoundException(string message, ErrorCodes errorCode, string userFriendlyMessage)
        : base(message, errorCode, userFriendlyMessage)
    {
    }
}