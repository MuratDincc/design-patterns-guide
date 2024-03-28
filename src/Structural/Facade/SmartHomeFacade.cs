using Facade.Components;

namespace Facade;

public class SmartHomeFacade
{
    private Lights _lights;
    private MusicSystem _musicSystem;
    private Security _security;
    private Thermostat _thermostat;
    
    public SmartHomeFacade(Lights lights, MusicSystem musicSystem, Security security, Thermostat thermostat)
    {
        _lights = lights;
        _musicSystem = musicSystem;
        _security = security;
        _thermostat = thermostat;
    }

    public void ArriveHome()
    {
        _lights.TurnOn();
        _thermostat.SetTemperature(30);
        _security.DeactivateAlarm();
        _musicSystem.PlayMusic();
        
        Console.WriteLine("Welcome Home!");
    }
    
    public void LeaveHome()
    {
        _lights.TurnOff();
        _thermostat.SetTemperature(10);
        _security.ActivateAlarm();
        _musicSystem.StopMusic();
        
        Console.WriteLine("Goodbye! Security Mode Active");
    }
}