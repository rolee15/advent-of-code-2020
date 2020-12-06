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
            inputFileRepository)
        {
        }

        protected override void InitSolution()
        {
            var input = InputFileRepository.GetDayOneInput();
            Solution = SolutionDayOne.FromList(input.ToList());
        }
    }
}