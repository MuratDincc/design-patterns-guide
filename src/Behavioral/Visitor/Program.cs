using Visitor;
using Visitor.Abstracts;
using Visitor.Domain;

var parts = new List<IAutoPart>
{
    new Engine(),
    new Brake(),
    new Water(),
    new ElectronicBrain()
};

var diagnosticVisitor = new DiagnosticVisitor();
var maintenanceVisitor = new MaintenanceVisitor();

Console.WriteLine("Visit: ");

foreach (var part in parts)
{
    part.Accept(diagnosticVisitor);
    part.Accept(maintenanceVisitor);
}