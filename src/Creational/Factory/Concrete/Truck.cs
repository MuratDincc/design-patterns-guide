using Factory.Abstracts;

namespace Factory;

public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Truck is delivering.");
    }
}