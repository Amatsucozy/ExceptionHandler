using Exceptions.Domain.Exceptions.Base;
using Exceptions.Domain.Exceptions.Constants;

namespace Exceptions.Domain.Exceptions.Instances.Unauthorized;

public sealed class WriteException : UnauthorizedException
{
    public WriteException(string message)
        : base(
            message,
            ErrorCodes.NoReadAccess,
            "You don't have write permission for this item!"
        )
    {
    }
}