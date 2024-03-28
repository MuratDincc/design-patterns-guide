using Decorator.Abstracts;

namespace Decorator;

public class BasicCoffee : Coffee
{
    public override string Description => "Basic Coffee";
    
    public override double Cost()
    {
        return 1.00;
    }
}