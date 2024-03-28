using Factory.Abstracts;

namespace Factory;

public class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Ship is delivering.");
    }
}