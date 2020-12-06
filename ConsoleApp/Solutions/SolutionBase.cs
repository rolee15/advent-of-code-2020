using ConsoleApp.Interfaces;

namespace ConsoleApp.Solutions
{
    public abstract class SolutionBase : ISolution
    {
        public void Solve()
        {
            SolvePartOne();
            SolvePartTwo();
        }

        public int FirstResult { get; protected set; }
        public int SecondResult { get; protected set; }

        protected abstract void SolvePartTwo();

        protected abstract void SolvePartOne();
    }
}