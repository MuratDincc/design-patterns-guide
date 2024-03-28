using AbstractFactory.Abstracts;

namespace AbstractFactory.Concrete.Lemonade;

public class LemonadeFactory : IBeverageFactory
{
    public IBeverage CreateBeverage()
    {
        return new Lemonade();
    }
}