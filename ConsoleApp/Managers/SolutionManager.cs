using System.Linq;
using ConsoleApp.Interfaces;
using ConsoleApp.Solutions;

namespace ConsoleApp.Managers
{
    internal class SolutionManager
    {
        private readonly IInputFileRepository _inputFileRepository;

        public SolutionManager(IInputFileRepository inputFileRepository)
        {
            this._inputFileRepository = inputFileRepository;
        }

        public int SolveDayOne()
        {
            var input = _inputFileRepository.GetDayOneInput();
            var solution = DayOneSolution.FromList(input.ToList());
            return solution.GetResult();
        }
    }
}