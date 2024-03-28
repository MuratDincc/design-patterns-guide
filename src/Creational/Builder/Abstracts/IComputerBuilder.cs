using Builder.Concreate;

namespace Builder.Abstracts;

public interface IComputerBuilder
{
    void AddCPU();
    void AddRAM();
    void AddStorage();
    void AddGPU();
    
    Computer GetComputer();
}