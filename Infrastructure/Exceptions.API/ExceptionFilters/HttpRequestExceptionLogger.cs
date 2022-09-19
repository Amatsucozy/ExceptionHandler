using Exceptions.Domain.ApplicationLoggers;
using Exceptions.Domain.Exceptions.Base;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Exceptions.API.ExceptionFilters;

internal sealed class HttpRequestExceptionLogger : IExceptionFilter
{
    private readonly ApplicationExceptionLogger _logger;

    public HttpRequestExceptionLogger(ApplicationExceptionLogger logger)
    {
        _logger = logger;
    }

    public void OnException(ExceptionContext context)
    {
        switch (context.Exception)
        {
            case DomainException domainException:
            {
                _logger.Log(domainException);
                break;
            }
            case UnauthorizedException unauthorizedException:
            {
                _logger.Log(unauthorizedException);
                break;
            }
            case NotFoundException notFoundException:
            {
                _logger.Log(notFoundException);
                break;
            }
            default:
            {
                _logger.LogUnknownError(context.Exception);
                break;
            }
        }
    }
}