namespace example.Models;

public class Person
{
    private int _age;
    private Person()
    {
        Name = default!;
        Surname = default!;
    }

    public Person(PersonPostDTO personDTO)
    {
        Id = Guid.NewGuid();
        Name = personDTO.Name;
        Surname = personDTO.Surname;
        Age = personDTO.Age;
        CreatedDate = DateTime.UtcNow;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age
    {
        get => _age;
        set
        {
            if (value < 0)
            {
                throw new Exception($"Invalid Age {value}");
            }
            _age = value;
        }
    }
    public DateTime? CreatedDate { get; set; }

    public PersonGetDTO ToPersonDTO()
    {
        return new PersonGetDTO
        {
            Id = Id,
            Name = Name,
            Surname = Surname
        };
    }
}