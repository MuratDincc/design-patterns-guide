using Visitor.Abstracts;

namespace Visitor.Domain;

public class Engine : IAutoPart
{
    public void Accept(IAutoPartVisitor visitor)
    {
        visitor.Visit(this);
    }
}