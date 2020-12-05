using System.Linq;
using ConsoleApp.Interfaces;
using ConsoleApp.Solutions;

namespace ConsoleApp.Managers
{
    internal sealed class SolutionDayOneManager : SolutionManagerBase
    {
        public SolutionDayOneManager(
            IInputFileRepository inputFileRepository,
            IConsoleAdapter consoleAdapter) : base(
                inputFileRepository,
                consoleAdapter)
        {
        }

        protected override void InitSolution()
        {
            var input = InputFileRepository.GetDayOneInput();
            Solution = SolutionDayOne.FromList(input.ToList());
        }

        protected override void PrintResults()
        {
            ConsoleAdapter.WriteLine("--- Day 1: Report Repair --- Part 1");
            ConsoleAdapter.WriteLine("Solution: {0}", Solution.FirstResult);
            ConsoleAdapter.WriteLine();
            ConsoleAdapter.WriteLine("--- Day 1: Report Repair --- Part 2");
            ConsoleAdapter.WriteLine("Solution: {0}", Solution.SecondResult);
            ConsoleAdapter.WriteLine();
            ConsoleAdapter.WriteLine("Elapsed time: {0}ms", StopWatch.Elapsed.TotalMilliseconds);
        }
    }
}