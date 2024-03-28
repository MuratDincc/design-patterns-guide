using Facade;
using Facade.Components;

Lights lights = new Lights();
MusicSystem musicSystem = new MusicSystem();
Security security = new Security();
Thermostat thermostat = new Thermostat();

SmartHomeFacade smartHome = new SmartHomeFacade(lights, musicSystem, security, thermostat);
smartHome.ArriveHome();
Console.WriteLine("-----");
smartHome.LeaveHome();