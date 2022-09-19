using Exceptions.Domain.Exceptions.Base;
using Exceptions.Domain.Exceptions.Constants;

namespace Exceptions.Domain.Exceptions.Instances.Unauthorized;

public sealed class ReadException : UnauthorizedException
{
    public ReadException(string message)
        : base(
            message,
            ErrorCodes.NoWriteAccess,
            "You don't have read permission for this item!")
    {
    }
}