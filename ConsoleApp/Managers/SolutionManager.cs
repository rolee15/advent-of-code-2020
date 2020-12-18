using System.Collections.Generic;
using System.Diagnostics;
using ConsoleApp.DTO;
using ConsoleApp.Interfaces;
using ConsoleApp.Solutions;

namespace ConsoleApp.Managers
{
    internal sealed class SolutionManager : ISolutionManager
    {
        private readonly IInputFileRepository _inputFileRepository;
        private readonly IEnumerable<ISolution> _solutions;
        private readonly Stopwatch _stopWatch;

        public SolutionManager(
            IInputFileRepository inputFileRepository)
        {
            _inputFileRepository = inputFileRepository;
            _solutions = CreateSolutions();
            _stopWatch = new Stopwatch();
        }

        public IEnumerable<Results> SolveAll()
        {
            foreach (var s in _solutions)
                yield return SolveAndMeasure(s);
        }

        private Results SolveAndMeasure(ISolution solution)
        {
            var results = new Results {Title = solution.Title};
            _stopWatch.Start();
            results.FirstResult = solution.SolvePartOne();
            results.SecondResult = solution.SolvePartTwo();
            _stopWatch.Stop();
            results.TotalMilliseconds = _stopWatch.Elapsed.TotalMilliseconds;
            return results;
        }

        private IEnumerable<ISolution> CreateSolutions()
        {
            yield return SolutionBase.CreateDayOneFrom(_inputFileRepository.GetInput("day1.txt"));
            yield return SolutionBase.CreateDayTwoFrom(_inputFileRepository.GetInput("day2.txt"));
            yield return SolutionBase.CreateDayThreeFrom(_inputFileRepository.GetInput("day3.txt"));
            yield return SolutionBase.CreateDayFourFrom(_inputFileRepository.GetInput("day4.txt"));
            yield return SolutionBase.CreateDayFiveFrom(_inputFileRepository.GetInput("day5.txt"));
        }
    }
}