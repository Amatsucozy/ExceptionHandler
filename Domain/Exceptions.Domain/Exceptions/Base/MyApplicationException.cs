using Exceptions.Domain.Exceptions.Constants;

namespace Exceptions.Domain.Exceptions.Base;

public abstract class MyApplicationException : Exception
{
    protected MyApplicationException(string message, ErrorCodes errorCode) : base(message)
    {
        ErrorCode = errorCode;
    }

    protected MyApplicationException(string message, ErrorCodes errorCode, string userFriendlyMessage) : base(message)
    {
        ErrorCode = errorCode;
        UserFriendlyMessage = userFriendlyMessage;
    }

    public ErrorCodes ErrorCode { get; }
    public string? UserFriendlyMessage { get; }
}