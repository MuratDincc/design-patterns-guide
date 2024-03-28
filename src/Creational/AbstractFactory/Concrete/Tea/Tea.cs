using AbstractFactory.Abstracts;

namespace AbstractFactory.Concrete.Tea;

public class Tea : IBeverage
{
    public void Prepare()
    {
        Console.WriteLine("Tea is preparing.");
    }
}