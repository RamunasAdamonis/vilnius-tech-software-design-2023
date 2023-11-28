using example.Models;
using Microsoft.AspNetCore.Mvc;

namespace example.Controllers;

[ApiController]
[Route("api/v1/person")]
public class PersonController : ControllerBase
{
    private readonly PersonService _personService;

    private readonly ILogger<PersonController> _logger;

    public PersonController(ILogger<PersonController> logger, PersonService personService)
    {
        _logger = logger;
        _personService = personService;
    }

    [HttpGet]
    public async Task<ActionResult<List<PersonGetDTO>>> GetPeople()
    {
        var people = await _personService.GetAllPeople();

        return Ok(people);
    }

    [HttpGet("name/{id}")]
    public async Task<ActionResult<PersonGetDTO>> GetPerson([FromRoute] Guid id)
    {
        var person = await _personService.GetPerson(id);
        Console.WriteLine(person.Name);
        return Ok(person);
    }

    [HttpPost]
    public async Task<ActionResult<PersonGetDTO>> CreatePerson([FromBody] PersonPostDTO personDTO)
    {
        var person = await _personService.CreatePerson(personDTO);


        return Ok(person);
    }
}
