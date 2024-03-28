using Mediator.Abstracts;
using Mediator.Domain;

namespace Mediator;

public class ChatRoom : IChatRoomMediator
{
    public void ShowMessage(User user, string message)
    {
        Console.WriteLine($"{DateTime.Now} [{user._name}]: {message}");
    }
}