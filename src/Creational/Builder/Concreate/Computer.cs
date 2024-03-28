namespace Builder.Concreate;

public class Computer
{
    private string computerName;
    private Dictionary<string, string> computerParts = new Dictionary<string, string>();
    
    public Computer(string computerName)
    {
        this.computerName = computerName;
    }

    public void AddPart(string key, string value)
    {
        computerParts[key] = value;
    }

    public void Print()
    {
        Console.WriteLine($"Computer Name: {computerName}");

        foreach (var part in computerParts)
        {
            Console.WriteLine($"{part.Key}: {part.Value}");
        }
    }
}