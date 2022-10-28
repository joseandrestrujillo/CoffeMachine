namespace CoffeMachine;

public class NotEnoughtBalanceException : Exception
{
    public NotEnoughtBalanceException(string message)
    {
        Console.WriteLine(message);
    }
}
