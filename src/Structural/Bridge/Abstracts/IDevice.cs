namespace Bridge.Abstracts;

public interface IDevice
{
    void TurnOn();
    void TurnOff();
    void SetTemperature(int temperature);
}