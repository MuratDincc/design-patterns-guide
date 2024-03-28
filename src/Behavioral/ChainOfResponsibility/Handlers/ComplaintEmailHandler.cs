using ChainOfResponsibility.Abstracts;
using ChainOfResponsibility.Domain;
using ChainOfResponsibility.Enums;

namespace ChainOfResponsibility.Handlers;

public class ComplaintEmailHandler : EmailHandler
{
    public override void HandleRequest(Email email)
    {
        if (email.Type == EmailType.Complaint)
        {
            Console.WriteLine("Complaint email is handled");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(email);
        }
    }
}