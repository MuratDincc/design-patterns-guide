using Visitor.Abstracts;
using Visitor.Domain;

namespace Visitor;

public class MaintenanceVisitor : IAutoPartVisitor
{
    public void Visit(Engine engine)
    {
        Console.WriteLine("Engine maintenance");
    }

    public void Visit(Brake brake)
    {
        Console.WriteLine("Brake maintenance");
    }

    public void Visit(Water water)
    {
        Console.WriteLine("Water maintenance");
    }

    public void Visit(ElectronicBrain water)
    {
        Console.WriteLine("ElectronicBrain maintenance");
    }
}