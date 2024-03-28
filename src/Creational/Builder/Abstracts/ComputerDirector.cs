using Builder.Concreate;

namespace Builder.Abstracts;

public class ComputerDirector
{
    private IComputerBuilder _computerBuilder;
    
    public ComputerDirector(IComputerBuilder computerBuilder)
    {
        _computerBuilder = computerBuilder;
    }

    public void BuildComputer()
    {
        _computerBuilder.AddCPU();
        _computerBuilder.AddRAM();
        _computerBuilder.AddStorage();
        _computerBuilder.AddGPU();
    }
    
    public Computer GetComputer() => _computerBuilder.GetComputer();
}