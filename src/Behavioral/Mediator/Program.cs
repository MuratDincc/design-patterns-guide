using Mediator;
using Mediator.Domain;

var mediator = new ChatRoom();

var murat = new User("Murat D.", mediator);
var ahmet = new User("Ahmet D.", mediator);

murat.Send("Hello, Ahmet!");
ahmet.Send("Hello, Murat!");