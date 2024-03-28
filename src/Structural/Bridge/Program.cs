using Bridge;
using Bridge.Abstracts;
using Bridge.Devices;

IDevice light = new Light();
IDevice thermostat = new Thermostat();

RemoteControl lightControl = new AdvanedRemoteControl(light);
lightControl.TurnOn();
lightControl.SetTemperature(25);

RemoteControl thermostatControl = new AdvanedRemoteControl(thermostat);
thermostatControl.TurnOn();
thermostatControl.SetTemperature(32);