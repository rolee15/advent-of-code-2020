using System;
using System.Diagnostics;
using System.Linq;
using ConsoleApp.Adapters;
using ConsoleApp.Interfaces;
using ConsoleApp.Solutions;

namespace ConsoleApp.Managers
{
    internal class SolutionManager : ISolutionManager
    {
        private readonly IInputFileRepository _inputFileRepository;
        private readonly IConsoleAdapter _consoleAdapter;
        public double LastRunTimeInMilliseconds { get; private set; }
        public double TotalRunTimeInMilliseconds { get; private set; }
        public int FirstResult { get; private set; }
        public int SecondResult { get; private set; }

        public SolutionManager(IInputFileRepository inputFileRepository, IConsoleAdapter consoleAdapter)
        {
            _inputFileRepository = inputFileRepository;
            _consoleAdapter = consoleAdapter;
        }

        public void SolveAndPrintDayOne()
        {
            SolveDayOne();
            PrintDayOne();
        }

        public void SolveDayOne()
        {
            var input = _inputFileRepository.GetDayOneInput();
            var solution = DayOneSolution.FromList(input.ToList());

            ResetTotalRunTime();
            FirstResult = SolveAndMeasure(() => solution.GetFirstResult());
            TotalRunTimeInMilliseconds += LastRunTimeInMilliseconds;
            SecondResult = SolveAndMeasure(() => solution.GetSecondResult());
            TotalRunTimeInMilliseconds += LastRunTimeInMilliseconds;
        }

        private void PrintDayOne()
        {
            _consoleAdapter.WriteLine("--- Day 1: Report Repair --- Part 1");
            _consoleAdapter.WriteLine("Solution: {0}", FirstResult);

            _consoleAdapter.WriteLine("--- Day 1: Report Repair --- Part 2");
            _consoleAdapter.WriteLine("Solution: {0}", SecondResult);

            _consoleAdapter.WriteLine("Elapsed time: {0}ms", TotalRunTimeInMilliseconds);
        }

        private int SolveAndMeasure(Func<int> function)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int res = function.Invoke();
            stopWatch.Stop();
            LastRunTimeInMilliseconds = stopWatch.Elapsed.TotalMilliseconds;
            return res;
        }

        private void ResetTotalRunTime()
        {
            TotalRunTimeInMilliseconds = 0;
        }
    }
}