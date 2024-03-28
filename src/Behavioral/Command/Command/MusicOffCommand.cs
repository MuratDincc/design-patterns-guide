using Command.Abstracts;
using Command.Concrete;

namespace Command.Command;

public class MusicOffCommand : ICommand
{
    private Music _music;

    public MusicOffCommand(Music music)
    {
        _music = music;
    }
    
    public void Execute()
    {
        _music.Off();
    }
}