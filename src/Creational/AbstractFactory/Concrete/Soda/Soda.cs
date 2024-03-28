using AbstractFactory.Abstracts;

namespace AbstractFactory.Concrete.Soda;

public class Soda : IBeverage
{
    public void Prepare()
    {
        Console.WriteLine("Soda is preparing.");
    }
}