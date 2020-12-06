using System;
using System.Diagnostics;
using ConsoleApp.DTO;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Managers
{
    internal abstract class SolutionManagerBase : ISolutionManager
    {
        protected IInputFileRepository InputFileRepository { get; }
        protected IConsoleAdapter ConsoleAdapter { get; }
        protected Stopwatch StopWatch { get; set; }
        protected ISolution Solution { get; set; }
        private Results Results { get; }

        protected SolutionManagerBase(
            IInputFileRepository inputFileRepository,
            IConsoleAdapter consoleAdapter)
        {
            InputFileRepository = inputFileRepository;
            ConsoleAdapter = consoleAdapter;
            StopWatch = new Stopwatch();
            Results = new Results();
        }

        protected abstract void InitSolution();

        private void SolveAndMeasure()
        {
            StopWatch.Start();
            Solution.Solve();
            StopWatch.Stop();
        }

        public Results GetResults()
        {
            InitSolution();
            SolveAndMeasure();
            MapResults();
            return Results;

            void MapResults()
            {
                Results.FirstResult = Solution.FirstResult;
                Results.SecondResult = Solution.SecondResult;
                Results.TotalMilliseconds = StopWatch.Elapsed.TotalMilliseconds;
            }
        }
    }
}