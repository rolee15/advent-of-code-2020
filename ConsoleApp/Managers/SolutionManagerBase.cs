using System.Diagnostics;
using ConsoleApp.DTO;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Managers
{
    internal abstract class SolutionManagerBase : ISolutionManager
    {
        private readonly Results _results;
        private readonly Stopwatch _stopWatch;

        protected readonly IInputFileRepository InputFileRepository;
        protected ISolution Solution;

        protected SolutionManagerBase(
            IInputFileRepository inputFileRepository)
        {
            InputFileRepository = inputFileRepository;
            _stopWatch = new Stopwatch();
            _results = new Results();
        }

        public Results GetResults()
        {
            InitSolution();
            SolveAndMeasure();
            return _results;
        }

        protected abstract void InitSolution();

        private void SolveAndMeasure()
        {
            _stopWatch.Start();
            _results.FirstResult = Solution.SolvePartOne();
            _results.SecondResult = Solution.SolvePartTwo();
            _stopWatch.Stop();
            _results.TotalMilliseconds = _stopWatch.Elapsed.TotalMilliseconds;
        }
    }
}