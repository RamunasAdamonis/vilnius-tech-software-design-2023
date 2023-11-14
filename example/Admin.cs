public class Admin : User
{
    public Guid EmployeeId { get; set; }

    public override void Greet()
    {
        Console.WriteLine("Good evening");
    }
}