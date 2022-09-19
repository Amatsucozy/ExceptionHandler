using Exceptions.Domain.Exceptions.Instances.Unauthorized;
using Microsoft.AspNetCore.Mvc;

namespace Exceptions.API.Controllers;

[Route("[controller]")]
public sealed class UnauthorizedController : ControllerBase
{
    [Route("Read")]
    [HttpGet]
    public IActionResult GetRead()
    {
        throw new ReadException("This is the message");
    }

    [Route("Write")]
    [HttpGet]
    public IActionResult GetWrite()
    {
        throw new WriteException("This is the message");
    }
}