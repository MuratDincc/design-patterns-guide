using Composite.Abstracts;

namespace Composite.Components;

public class Department : IEducationComponent
{
    private string _name;
    private List<IEducationComponent> _educationComponents = new List<IEducationComponent>();
    
    public Department(string name)
    {
        _name = name;
    }
    
    public void Add(IEducationComponent educationComponent)
    {
        _educationComponents.Add(educationComponent);
    }
    
    public void Display(int indent = 0)
    {
       Console.WriteLine($"{new string(' ', indent)} Department: {_name}");

       foreach (var component in _educationComponents)
       {
            component.Display(indent + 2);
       }
    }
}