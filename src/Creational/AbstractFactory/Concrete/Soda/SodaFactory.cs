using AbstractFactory.Abstracts;

namespace AbstractFactory.Concrete.Soda;

public class SodaFactory : IBeverageFactory
{
    public IBeverage CreateBeverage()
    {
        return new Soda();
    }
}