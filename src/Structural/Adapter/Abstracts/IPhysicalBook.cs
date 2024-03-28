namespace Adapter.Abstracts;

public interface IPhysicalBook
{
    void CheckOut(string borrower);
    void ReturnBook(string borrower);
}