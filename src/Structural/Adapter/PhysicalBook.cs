using Adapter.Abstracts;

namespace Adapter;

public class PhysicalBook : IPhysicalBook
{
    public void CheckOut(string borrower)
    {
        Console.WriteLine($"Checking out book to {borrower}");
    }

    public void ReturnBook(string borrower)
    {
        Console.WriteLine($"Returning book from {borrower}");
    }
}