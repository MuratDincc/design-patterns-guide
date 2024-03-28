using Bridge.Abstracts;

namespace Bridge.Devices;

public class Light : IDevice
{
    public void TurnOn() => Console.WriteLine("Light: Turned On");

    public void TurnOff() => Console.WriteLine("Light: Turned Off");

    public void SetTemperature(int temperature) => Console.WriteLine($"Light: Set level to {temperature}%");
}