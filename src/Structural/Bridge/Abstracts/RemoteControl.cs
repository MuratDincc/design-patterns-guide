namespace Bridge.Abstracts;

public abstract class RemoteControl
{
    protected IDevice _device;
    
    public RemoteControl(IDevice device)
    {
        _device = device;
    }
    
    public abstract void TurnOn();
    public abstract void TurnOff();
    public abstract void SetTemperature(int temperature);
}