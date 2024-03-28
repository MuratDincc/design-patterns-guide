using AbstractFactory.Abstracts;

namespace AbstractFactory.Concrete.Coffee;

public class Coffee : IBeverage
{
    public void Prepare()
    {
        Console.WriteLine("Coffee is preparing.");
    }
}