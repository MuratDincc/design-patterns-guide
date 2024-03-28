using Visitor.Domain;

namespace Visitor.Abstracts;

public interface IAutoPartVisitor
{
    void Visit(Engine engine);
    void Visit(Brake brake);
    void Visit(Water water);
    void Visit(ElectronicBrain water);
}