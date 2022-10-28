using CoffeMachine;

Coffee manchado = new Coffee("Manchado", 0.8f, 3);
Coffee cafesolo = new Coffee("Café Solo", 0.6f, 5);
Coffee capuccino = new Coffee("Capuccino", 1.3f, 1);

Client client = new Client();
bool exit = false;
while (!exit)
{
    Console.WriteLine("SALDO: " + client.Balance + " euros.");
    Console.WriteLine("Seleccione una opción");
    Console.WriteLine("1. Pedir un manchado");
    Console.WriteLine("2. Pedir un café solo");
    Console.WriteLine("3. Pedir un capuccino");
    Console.WriteLine("4. Insertar dinero");
    Console.WriteLine("5. Salir");
    var option = Console.ReadLine();
    try
    {
        switch (option)
        {
            case "1":
                client.Buy(manchado);
                break;
            case "2":
                client.Buy(cafesolo);
                break;
            case "3":
                client.Buy(capuccino);
                break;
            case "4":
                Console.WriteLine("Cuanto desea introducir?");
                var input = Console.ReadLine();
                float howmuch = input != null ? float.Parse(input) : 0.0f;
                client.InsertMoney(howmuch);
                break;
            case "5":
                exit = true;
                break;
            default:
                break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
}