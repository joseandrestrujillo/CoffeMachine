namespace CoffeMachine;

public class NotEnoughtStockException: Exception
{
    public NotEnoughtStockException(string message)
    {
        Console.WriteLine(message);
    }
}