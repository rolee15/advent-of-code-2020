using System.Collections.Generic;
using System.Linq;
using ConsoleApp.Interfaces;
using ConsoleApp.Solutions;

namespace ConsoleApp.Managers
{
    internal class SolutionManager : ISolutionManager
    {
        private readonly IInputFileRepository _inputFileRepository;
        private IEnumerable<int> _input;

        public SolutionManager(IInputFileRepository inputFileRepository)
        {
            _inputFileRepository = inputFileRepository;
        }

        public int SolveDayOne()
        {
            _input ??= _inputFileRepository.GetDayOneInput();
            var solution = DayOneSolution.FromList(_input.ToList());
            return solution.GetFirstResult(true);
        }

        public int SolveDayTwo()
        {
            _input ??= _inputFileRepository.GetDayOneInput();
            var solution = DayOneSolution.FromList(_input.ToList());
            return solution.GetSecondResult();
        }
    }
}