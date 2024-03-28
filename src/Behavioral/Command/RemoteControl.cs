using Command.Abstracts;

namespace Command;

public class RemoteControl
{
    private ICommand _onCommand;
    private ICommand _offCommand;
    
    public RemoteControl(ICommand onCommand, ICommand offCommand)
    {
        _onCommand = onCommand;
        _offCommand = offCommand;
    }

    public void PressOn()
    {
        _onCommand.Execute();
    }
    
    public void PressOff()
    {
        _offCommand.Execute();
    }
}