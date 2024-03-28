using Composite.Abstracts;

namespace Composite.Components;

public class Course : IEducationComponent
{
    private string _name;

    public Course(string name)
    {
        _name = name;
    }
    
    public void Display(int indent = 0)
    {
        Console.WriteLine($"{new string('-', indent)} Course: {_name}");
    }
}