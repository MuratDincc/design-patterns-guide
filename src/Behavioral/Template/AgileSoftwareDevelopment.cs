using Template.Abstracts;

namespace Template;

public class AgileSoftwareDevelopment : SoftwareDevelopmentLifecycle
{
    protected override void Analysis()
    {
        Console.WriteLine("Gather requirements and create user stories.");
    }

    protected override void Design()
    {
        Console.WriteLine("Designing microservice architecture.");
    }

    protected override void WriteCode()
    {
        Console.WriteLine("Write code with pair programming.");
    }

    protected override void Test()
    {
        Console.WriteLine("Test with automated unit tests.");
    }

    protected override void Deploy()
    {
        Console.WriteLine("Deploy to production with continuous integration.");
    }
}