using Builder;
using Builder.Abstracts;

var gamingComputerBuilder = new GamingComputerBuilder();
var computerDirector = new ComputerDirector(gamingComputerBuilder);

computerDirector.BuildComputer();
var gamingComputer = computerDirector.GetComputer();
gamingComputer.Print();

Console.WriteLine("\n");

var workComputerBuilder = new WorkComputerBuilder();
computerDirector = new ComputerDirector(workComputerBuilder);
computerDirector.BuildComputer();
var workComputer = computerDirector.GetComputer();
workComputer.Print();