using System;
using System.Diagnostics;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Managers
{
    internal abstract class SolutionManagerBase : ISolutionManager
    {
        protected IInputFileRepository InputFileRepository { get; }
        protected IConsoleAdapter ConsoleAdapter { get; }
        protected Stopwatch StopWatch { get; set; }
        protected ISolution Solution { get; set; }        

        public SolutionManagerBase(
            IInputFileRepository inputFileRepository,
            IConsoleAdapter consoleAdapter)
        {
            InputFileRepository = inputFileRepository;
            ConsoleAdapter = consoleAdapter;
            StopWatch = new Stopwatch();
        }
        
        public void SolveAndPrintSolution()
        {
            InitSolution();
            SolveAndMeasure();
            PrintResults();
        }        

        protected abstract void InitSolution();
        
        protected void SolveAndMeasure()
        {
            StopWatch.Start();
            Solution.Solve();
            StopWatch.Stop();
        }

        protected abstract void PrintResults();
    }
}