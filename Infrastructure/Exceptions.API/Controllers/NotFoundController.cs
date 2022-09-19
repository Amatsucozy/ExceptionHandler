using Exceptions.Domain.Exceptions.Instances.NotFound;
using Microsoft.AspNetCore.Mvc;

namespace Exceptions.API.Controllers;

[Route("[controller]")]
public sealed class NotFoundController : ControllerBase
{
    [Route("UserNotFound")]
    [HttpGet]
    public IActionResult GetUserNotFound()
    {
        throw new UserNotFoundException("This is the message");
    }
}