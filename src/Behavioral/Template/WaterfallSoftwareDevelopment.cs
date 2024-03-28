using Template.Abstracts;

namespace Template;

public class WaterfallSoftwareDevelopment : SoftwareDevelopmentLifecycle
{
    protected override void Analysis()
    {
        Console.WriteLine("Completing extensive requirement documentation");
    }

    protected override void Design()
    {
        Console.WriteLine("Designing monolithic architecture");
    }

    protected override void WriteCode()
    {
        Console.WriteLine("Write code with waterfall methodology");
    }

    protected override void Test()
    {
        Console.WriteLine("Test with manual testing");
    }

    protected override void Deploy()
    {
        Console.WriteLine("Manual deployment to production");
    }
}