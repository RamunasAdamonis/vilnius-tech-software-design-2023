public class User
{
    public string Name { get; set; }

    public virtual void Greet()
    {
        Console.WriteLine("Hello");
    }
}