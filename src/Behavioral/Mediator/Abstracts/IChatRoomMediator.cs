using Mediator.Domain;

namespace Mediator.Abstracts;

public interface IChatRoomMediator
{
    void ShowMessage(User user, string message);
}