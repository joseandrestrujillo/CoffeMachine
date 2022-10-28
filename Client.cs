namespace CoffeMachine;

public class Client
{
    public float Balance { get; private set; }

    public Client()
    {
        Balance = 0.0f;
    }
    public void Buy(IProduct p)
    {
        if (p.Price > Balance)
        {
            throw new NotEnoughtBalanceException("No tienes suficiente dinero, introduce " + (p.Price - Balance) + " euros para conseguir este café.");
        }
        if (p.Stock == 0)
        {
            throw new NotEnoughtStockException("No hay stock para este café.");
        }

        Balance -= p.Price;
        p.Stock--;
    }

    public void InsertMoney(float money)
    {
        Balance += money;
    }
}

