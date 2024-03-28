using Command;
using Command.Abstracts;
using Command.Command;
using Command.Concrete;

var livingRoomLight = new Light();

ICommand lightOn = new LightOnCommand(livingRoomLight);
ICommand lightOff = new LightOffCommand(livingRoomLight);

RemoteControl remoteControl = new RemoteControl(lightOn, lightOff);

remoteControl.PressOn();

var music = new Music();

ICommand musicOn = new MusicOnCommand(music);
ICommand musicOff = new MusicOffCommand(music);

remoteControl = new RemoteControl(musicOn, musicOff);

remoteControl.PressOn();