using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ConsoleApp.Interfaces;
using ConsoleApp.Solutions;

namespace ConsoleApp.Managers
{
    internal class SolutionManager : ISolutionManager
    {
        private readonly IInputFileRepository _inputFileRepository;
        public double LastRunTimeInMilliseconds { get; private set; }
        public double TotalRunTimeInMilliseconds { get; private set; }
        public int FirstResult { get; private set; }
        public int SecondResult { get; private set; }

        public SolutionManager(IInputFileRepository inputFileRepository)
        {
            _inputFileRepository = inputFileRepository;
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