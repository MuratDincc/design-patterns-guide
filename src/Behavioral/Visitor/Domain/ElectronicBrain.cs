using Visitor.Abstracts;

namespace Visitor.Domain;

public class ElectronicBrain : IAutoPart
{
    public void Accept(IAutoPartVisitor visitor)
    {
        visitor.Visit(this);
    }
}