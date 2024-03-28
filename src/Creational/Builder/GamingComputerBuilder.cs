using Builder.Abstracts;
using Builder.Concreate;

namespace Builder;

public class GamingComputerBuilder : IComputerBuilder
{
    private Computer _computer;

    public GamingComputerBuilder()
    {
        _computer = new Computer("Gaming Computer v2");
    }
    
    public void AddCPU() => _computer.AddPart("CPU", "Intel Core i9-9900K");

    public void AddRAM() => _computer.AddPart("RAM", "Corsair Vengeance LPX 16GB");

    public void AddStorage() => _computer.AddPart("Storage", "Samsung 970 EVO 1TB NVMe M.2 SSD");

    public void AddGPU() => _computer.AddPart("GPU", "Nvidia RTX 2080 Ti 11GB GDDR6");

    public Computer GetComputer() => _computer;
}