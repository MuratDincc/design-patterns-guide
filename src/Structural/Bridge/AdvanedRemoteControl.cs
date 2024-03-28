using Bridge.Abstracts;

namespace Bridge;

public class AdvanedRemoteControl : RemoteControl
{
    public AdvanedRemoteControl(IDevice device) : base(device) { }

    public override void TurnOn() => _device.TurnOn();

    public override void TurnOff() => _device.TurnOff();

    public override void SetTemperature(int temperature) => _device.SetTemperature(temperature);
}