using AbstractFactory.Abstracts;

namespace AbstractFactory.Concrete.Lemonade;

public class Lemonade : IBeverage
{
    public void Prepare()
    {
        Console.WriteLine("Lemonade is preparing.");
    }
}