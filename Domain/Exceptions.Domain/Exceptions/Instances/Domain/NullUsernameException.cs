using Exceptions.Domain.Exceptions.Base;
using Exceptions.Domain.Exceptions.Constants;

namespace Exceptions.Domain.Exceptions.Instances.Domain;

public sealed class NullUsernameException : DomainException
{
    public NullUsernameException(string message)
        : base(
            message,
            ErrorCodes.NullUsername,
            "Username can not be null or contain only whitespaces!")
    {
    }
}