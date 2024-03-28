using Command.Abstracts;
using Command.Concrete;

namespace Command.Command;

public class MusicOnCommand : ICommand
{
    private Music _music;
    
    public MusicOnCommand(Music music)
    {
        _music = music;
    }
    
    public void Execute()
    {
        _music.On();
    }
}