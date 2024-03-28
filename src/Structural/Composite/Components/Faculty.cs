using Composite.Abstracts;

namespace Composite.Components;

public class Faculty : IEducationComponent
{
    private string _name;
    private List<IEducationComponent> _departments = new List<IEducationComponent>();
    
    public Faculty(string name)
    {
        _name = name;
    }
    
    public void Add(IEducationComponent department)
    {
        _departments.Add(department);
    }
    
    public void Display(int indent = 0)
    {
        Console.WriteLine($"{new string(' ', indent)} Faculty: {_name}");

        foreach (var department in _departments)
        {
            department.Display(indent + 2);
        }
    }
}