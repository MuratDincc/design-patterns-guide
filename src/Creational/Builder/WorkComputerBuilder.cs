using Builder.Abstracts;
using Builder.Concreate;

namespace Builder;

public class WorkComputerBuilder : IComputerBuilder
{
    private Computer _computer;

    public WorkComputerBuilder()
    {
        _computer = new Computer("Work Computer v1");
    }
    
    public void AddCPU() => _computer.AddPart("CPU", "Intel Core i7-9700KXX");

    public void AddRAM() => _computer.AddPart("RAM", "Corsair Vengeance LPX 32GB");

    public void AddStorage() => _computer.AddPart("Storage", "Samsung 970 EVO 2TB NVMe M.2 SSD");

    public void AddGPU() => _computer.AddPart("GPU", "Nvidia RTX 2080 Ti 16GB GDDR6");

    public Computer GetComputer() => _computer;
}