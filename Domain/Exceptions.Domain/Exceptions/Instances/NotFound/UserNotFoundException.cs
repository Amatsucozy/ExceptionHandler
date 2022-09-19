using Exceptions.Domain.Exceptions.Base;
using Exceptions.Domain.Exceptions.Constants;

namespace Exceptions.Domain.Exceptions.Instances.NotFound;

public sealed class UserNotFoundException : NotFoundException
{
    public UserNotFoundException(string message)
        : base(
            message,
            ErrorCodes.UserNotFound,
            "User can not be found!"
        )
    {
    }
}