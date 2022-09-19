using Exceptions.Domain.Exceptions.Instances.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Exceptions.API.Controllers;

[Route("[controller]")]
public sealed class DomainController : ControllerBase
{
    [Route("NullUsername")]
    [HttpGet]
    public IActionResult GetNullUsername()
    {
        throw new NullUsernameException("This is the message");
    }
}