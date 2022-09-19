using System.Net;
using Exceptions.Domain.Exceptions.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Exceptions.API.ExceptionFilters;

internal sealed class HttpRequestExceptionHandler : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.ExceptionHandled) return;

        context.Result = context.Exception switch
        {
            DomainException => new BadRequestResult(),
            NotFoundException => new NotFoundResult(),
            UnauthorizedException => new UnauthorizedResult(),
            _ => new StatusCodeResult((int)HttpStatusCode.InternalServerError)
        };
        context.ExceptionHandled = true;
    }
}