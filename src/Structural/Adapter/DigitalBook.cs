using Adapter.Abstracts;

namespace Adapter;

public class DigitalBook : IDigitalBook
{
    public void Download(string borrower)
    {
        Console.WriteLine($"Digital book downloaded by {borrower}");
    }

    public void RemoveDownload(string borrower)
    {
        Console.WriteLine($"Download of digital book removed by {borrower}");
    }
}