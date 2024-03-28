using Visitor.Abstracts;

namespace Visitor.Domain;

public class Water : IAutoPart
{
    public void Accept(IAutoPartVisitor visitor)
    {
        visitor.Visit(this);
    }
}