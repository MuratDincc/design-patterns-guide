namespace Visitor.Abstracts;

public interface IAutoPart
{
    void Accept(IAutoPartVisitor visitor);
}