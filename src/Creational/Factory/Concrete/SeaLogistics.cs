using Factory.Abstracts;

namespace Factory.Concrete;

public class SeaLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}