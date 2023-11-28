using example.Models;

namespace example.tests;

public class PersonTests
{
    [Fact]
    public void Person_GivenValidInput_PopulatesPersonProperties()
    {
        // Arrange
        var personDTO = new PersonPostDTO
        {
            Name = "John",
            Surname = "Smith",
            Age = 25

        };

        // Act
        var person = new Person(personDTO);

        // Assert
        Assert.Equal(personDTO.Name, person.Name);
        Assert.Equal(personDTO.Age, person.Age);
        Assert.NotNull(person.CreatedDate);
    }

    [Fact]
    public void Person_GivenInvalidInput_ThrowAnException()
    {
        // Arrange
        var personDTO = new PersonPostDTO
        {
            Name = "John",
            Surname = "Smith",
            Age = -1
        };

        // Act and assert
        Assert.Throws<Exception>(() => new Person(personDTO));
    }
}