using Microsoft.AspNetCore.Mvc;

namespace example.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private static readonly List<string>? _names = new List<string>();

    private readonly ILogger<WeatherForecastController> _logger;

    public PersonController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ActionResult<IEnumerable<string>> Get([FromQuery] string name)
    {
        return Ok(_names.Where(x => x == name));
    }

    [HttpGet("name/{name}")]
    public ActionResult<IEnumerable<string>> GetName([FromRoute] string name)
    {
        return Ok(_names.Where(x => x == name));
    }

    [HttpPost]
    public ActionResult<List<string>> CreatePerson([FromBody] PersonData data)
    {
        _names.Add(data.Name);

        return Ok(_names);
    }
}

public class PersonData
{
    public string? Name { get; set; }
}
