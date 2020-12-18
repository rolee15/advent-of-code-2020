namespace ConsoleApp.Interfaces
{
    internal interface ISolution
    {
        string Title { get; }
        object SolvePartOne();
        object SolvePartTwo();
    }
}