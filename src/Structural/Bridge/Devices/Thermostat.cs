using Bridge.Abstracts;

namespace Bridge.Devices;

public class Thermostat : IDevice
{
    public void TurnOn() => Console.WriteLine("Thermostat: Turned On");

    public void TurnOff() => Console.WriteLine("Thermostat: Turned Off");

    public void SetTemperature(int temperature) => Console.WriteLine($"Thermostat: Set level to {temperature} °C");
}