using Mediator.Abstracts;

namespace Mediator.Domain;

public class User
{
    public string _name { get; private set; }
    private IChatRoomMediator _chatRoomMediator;

    public User(string name, IChatRoomMediator chatRoomMediator)
    {
        _name = name;
        _chatRoomMediator = chatRoomMediator;
    }

    public void Send(string message)
    {
        _chatRoomMediator.ShowMessage(this, message);
    }
}