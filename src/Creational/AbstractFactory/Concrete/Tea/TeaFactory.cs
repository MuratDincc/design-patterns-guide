using AbstractFactory.Abstracts;

namespace AbstractFactory.Concrete.Tea;

public class TeaFactory : IBeverageFactory
{
    public IBeverage CreateBeverage()
    {
        return new Tea();
    }
}