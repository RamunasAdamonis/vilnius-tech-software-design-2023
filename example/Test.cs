public class Test
{
    private int _number;
    public Test(int number)
    {
        _number = number;
        Console.WriteLine("I am inside a constructor");
    }

    public int Number2 { get; private set; }

    public void SetNumber(int number)
    {
        if (number < 0)
            throw new Exception("Cannot be negative");
        Number2 = number;
    }

    public void Fly()
    {
        Run(_number);
        Run(_number + 1);
    }

    private void Run(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine($"I am running #{_number}");
        }
    }


}
