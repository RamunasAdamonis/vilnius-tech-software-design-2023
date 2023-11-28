

using Microsoft.EntityFrameworkCore;

namespace example.Models;

public class PersonService
{
    private readonly PersonContext _personContext;
    public PersonService(PersonContext personContext)
    {
        _personContext = personContext;
    }

    public async Task<PersonGetDTO> CreatePerson(PersonPostDTO personDTO)
    {
        var person = new Person(personDTO);
        await _personContext.People.AddAsync(person);
        await _personContext.SaveChangesAsync();

        return person.ToPersonDTO();
    }

    public async Task<List<PersonGetDTO>> GetAllPeople()
    {
        var people = await _personContext.People
            .Select(x => x.ToPersonDTO())
            .ToListAsync();

        return people;
    }

    public async Task<PersonGetDTO> GetPerson(Guid id)
    {
        var person = await _personContext.People
            .FindAsync(id);

        if (person is null)
        {
            throw new Exception("Person not found");
        }

        return person.ToPersonDTO();
    }
}