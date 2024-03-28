namespace Adapter.Abstracts;

public interface IDigitalBook
{
    void Download(string borrower);
    void RemoveDownload(string borrower);
}