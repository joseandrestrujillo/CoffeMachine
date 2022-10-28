namespace CoffeMachine;


public interface IProduct
{
    public float Price { get; }
    public int Stock { get; set; }
}