using ChainOfResponsibility.Domain;

namespace ChainOfResponsibility.Abstracts;

public abstract class EmailHandler
{
    protected EmailHandler _nextHandler;
    
    public void SetNextHandler(EmailHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }
    
    public abstract void HandleRequest(Email email);
}