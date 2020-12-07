using System.Linq;
using ConsoleApp.Interfaces;
using ConsoleApp.Solutions;

namespace ConsoleApp.Managers
{
    internal sealed class SolutionDayTwoManager : SolutionManagerBase
    {
        public SolutionDayTwoManager(
            IInputFileRepository inputFileRepository) : base(
            inputFileRepository)
        {
        }

        protected override void InitSolution()
        {
            var input = InputFileRepository.GetDayTwoInput();
            Solution = SolutionDayTwo.FromList(input.ToList());
        }
    }
}