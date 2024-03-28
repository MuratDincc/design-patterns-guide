using Factory.Abstracts;

namespace Factory.Concrete;

public class RoadLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}