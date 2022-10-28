namespace CoffeMachine;

public class Coffee: IProduct
{
    public string Name { get; private set; }
    public float Price { get; private set; }
    public int Stock { get; set; }

    public Coffee(string name, float price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }
}