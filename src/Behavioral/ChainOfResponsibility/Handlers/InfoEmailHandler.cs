using ChainOfResponsibility.Abstracts;
using ChainOfResponsibility.Domain;
using ChainOfResponsibility.Enums;

namespace ChainOfResponsibility.Handlers;

public class InfoEmailHandler : EmailHandler
{
    public override void HandleRequest(Email email)
    {
        if (email.Type == EmailType.Information)
        {
            Console.WriteLine("Information email is handled");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(email);
        }
    }
}