using Adapter.Abstracts;

namespace Adapter;

public class DigitalBookAdapter : IPhysicalBook
{
    private IDigitalBook _digitalBook;

    public DigitalBookAdapter(IDigitalBook digitalBook)
    {
        _digitalBook = digitalBook;
    }
    
    public void CheckOut(string borrower)
    {
        _digitalBook.Download(borrower);
    }

    public void ReturnBook(string borrower)
    {
        _digitalBook.RemoveDownload(borrower);
    }
}