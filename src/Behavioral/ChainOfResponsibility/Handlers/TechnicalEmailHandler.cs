using ChainOfResponsibility.Abstracts;
using ChainOfResponsibility.Domain;
using ChainOfResponsibility.Enums;

namespace ChainOfResponsibility.Handlers;

public class TechnicalEmailHandler : EmailHandler
{
    public override void HandleRequest(Email email)
    {
        if (email.Type == EmailType.TechnicalSupport)
        {
            Console.WriteLine("Technical support email is handled");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(email);
        }
    }
}