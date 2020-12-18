using ConsoleApp.Interfaces;

namespace ConsoleApp.Solutions
{
    internal abstract partial class SolutionBase : ISolution
    {
        public abstract string Title { get; }
        public abstract object SolvePartOne();
        public abstract object SolvePartTwo();
    }
}