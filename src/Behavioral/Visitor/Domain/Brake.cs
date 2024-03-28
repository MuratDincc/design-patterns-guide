using Visitor.Abstracts;

namespace Visitor.Domain;

public class Brake : IAutoPart
{
    public void Accept(IAutoPartVisitor visitor)
    {
        visitor.Visit(this);
    }
}