using Visitor.Abstracts;
using Visitor.Domain;

namespace Visitor;

public class DiagnosticVisitor : IAutoPartVisitor
{
    public void Visit(Engine engine)
    {
        Console.WriteLine("Engine diagnostic");
    }

    public void Visit(Brake brake)
    {
        Console.WriteLine("Brake diagnostic");
    }

    public void Visit(Water water)
    {
        Console.WriteLine("Water diagnostic");
    }

    public void Visit(ElectronicBrain water)
    {
        Console.WriteLine("ElectronicBrain diagnostic");
    }
}