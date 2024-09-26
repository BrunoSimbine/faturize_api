using Microsoft.AspNetCore.Mvc;

namespace faturize_api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    [HttpGet]
    public async Task<ActionResult<string>> Get()
    {
        return Ok("Ola Mundo!");
    }
}
