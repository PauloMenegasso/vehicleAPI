using Microsoft.AspNetCore.Mvc;

namespace vehicleAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthCheckController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Vehicle API is up and running!");
    }
}
