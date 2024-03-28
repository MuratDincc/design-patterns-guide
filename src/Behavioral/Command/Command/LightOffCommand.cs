using Command.Abstracts;
using Command.Concrete;

namespace Command.Command;

public class LightOffCommand : ICommand
{
    private Light _light;
    
    public LightOffCommand(Light light)
    {
        _light = light;
    }
    
    public void Execute()
    {
        _light.Off();
    }
}