using AbstractFactory.Abstracts;

namespace AbstractFactory.Concrete.Coffee;

public class CoffeeFactory : IBeverageFactory
{
    public IBeverage CreateBeverage()
    {
        return new Coffee();
    }
}