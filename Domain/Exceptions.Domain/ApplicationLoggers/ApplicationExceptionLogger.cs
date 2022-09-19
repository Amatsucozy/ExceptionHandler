using Exceptions.Domain.Exceptions.Base;
using Microsoft.Extensions.Logging;

namespace Exceptions.Domain.ApplicationLoggers;

public sealed class ApplicationExceptionLogger
{
    private readonly ILogger<ApplicationExceptionLogger> _logger;

    public ApplicationExceptionLogger(ILogger<ApplicationExceptionLogger> logger)
    {
        _logger = logger;
    }

    private void LogGeneral(MyApplicationException exception)
    {
        _logger.LogError("Error code: {errorCode}", exception.ErrorCode);
        _logger.LogError("User friendly message: {userFriendlyMessage}", exception.UserFriendlyMessage);
        // _logger.LogError("Stack trace: {stacktrace}", exception.StackTrace);
    }

    public void Log(DomainException domainException)
    {
        LogGeneral(domainException);
        _logger.LogError("Domain Exception Type: {exceptionType}", domainException.GetType().Name);
    }

    public void Log(UnauthorizedException unauthorizedException)
    {
        LogGeneral(unauthorizedException);
        _logger.LogError("Unauthorized Exception Type: {exceptionType}", unauthorizedException.GetType().Name);
    }

    public void Log(NotFoundException notFoundException)
    {
        LogGeneral(notFoundException);
        _logger.LogError("NotFound Exception Type: {exceptionType}", notFoundException.GetType().Name);
    }

    public void LogUnknownError(Exception exception)
    {
        _logger.LogError("This is unknown error");
    }
}